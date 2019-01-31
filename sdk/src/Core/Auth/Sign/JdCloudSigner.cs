using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Constant;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Core.Utils;
using System.Linq;
using System.Globalization;

namespace JDCloudSDK.Core.Auth.Sign
{

    /// <summary>
    /// jd云签名算法
    /// </summary>
    public class JdCloudSigner : AbstractSigner, ServiceSigner, RegionSigner
    {
        /// <summary>
        /// 要忽略的签名头信息
        /// </summary>
        public static readonly string[] LIST_OF_HEADERS_TO_IGNORE_IN_LOWER_CASE = { "connection", "x-jdcloud-trace-id" };

        /// <summary>
        /// 服务名称
        /// </summary>
        protected string ServiceName { get; set; }


        /// <summary>
        /// 服务区域名称
        /// </summary>
        protected string RegionName { get; set; }


        /// <summary>
        /// 为了兼容.net的写法，可以对日期进行赋为空值的操作
        /// TODO 后期验证需要进行修改
        /// </summary>
        private DateTime? _overrddenDate;

        /// <summary>
        /// 是否进行二次加密
        /// </summary>
        private bool _doubleUrlEncode;

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public JdCloudSigner()
        {

        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="doubleUrlEncode">是否进行url 二次encode</param>
        public JdCloudSigner(bool doubleUrlEncode)
        {
            this._doubleUrlEncode = doubleUrlEncode;
        }
        /// <summary>
        /// 设置重写时间戳
        /// </summary>
        /// <param name="dateTime">要设置的时间</param>
        public void SetOverriddenDate(DateTime dateTime)
        {
            if (dateTime != null)
            {
                this._overrddenDate = dateTime;
            }
            else
            {
                this._overrddenDate = null;
            }
        }  

        /// <summary>
        /// 设置地域信息
        /// </summary>
        /// <param name="regionName">地域信息</param>
        public void SetRegionName(string regionName)
        {
            this.RegionName = regionName;
        }

        /// <summary>
        /// 设置服务名称
        /// </summary>
        /// <param name="serviceName">服务名称</param>
        public void SetServiceName(string serviceName)
        {
            this.ServiceName = serviceName;
        }

        /// <summary>
        /// 进行签名
        /// </summary>
        /// <param name="builder">http 请求使用的信息</param>
        /// <param name="credentials">请求的认证信息</param>
        /// <returns>签名后得到的http 请求信息</returns>
        public override SdkHttpFullRequest Sign(SdkHttpFullRequestBuilder builder, Credentials credentials)
        {
            return DoSign(builder, credentials).Build();
        }

        /// <summary>
        /// 添加session 认证信息
        /// </summary>
        /// <param name="mutableRequest">http请求信息</param>
        /// <param name="credentials">session 认证信息</param>
        protected override void AddSessionCredentials(SdkHttpFullRequestBuilder mutableRequest, SessionCredentials credentials)
        {
            mutableRequest.Header(ParameterConstant.X_JDCLOUD_SECURITY_TOKEN, credentials.SessionToken());
        }

        /// <summary>
        /// 签名的具体实现
        /// </summary>
        /// <param name="builder">http请求信息</param>
        /// <param name="credentials">证书信息</param>
        /// <returns>请求后的http 信息</returns>
        private SdkHttpFullRequestBuilder DoSign( SdkHttpFullRequestBuilder builder, Credentials credentials)
        {
            Credentials sanitizedCredentials = SanitizeCredentials(credentials);
            if (credentials.GetType() == typeof(SessionCredentials))
            {
                AddSessionCredentials(builder, (SessionCredentials)credentials);
            }
            //20180627T065220Z
            //_overrddenDate = new DateTime(2018,6,27,6, 52, 20);
            SignerRequestParams signerRequestParams = new SignerRequestParams(builder, _overrddenDate,
                RegionName, ServiceName, ParameterConstant.JDCLOUD2_SIGNING_ALGORITHM);
            // SignerRequestParams
            AddHostHeader(ref builder);
            builder.Header(ParameterConstant.X_JDCLOUD_DATE, signerRequestParams.FormattedSigningDateTime); 
            string contentSha256 = string.Empty;
            if (builder.GetHeaders() != null && builder.GetHeaders().ContainsKey(ParameterConstant.X_JDCLOUD_CONTENT_SHA256) &&
                builder.GetHeaders()[ParameterConstant.X_JDCLOUD_CONTENT_SHA256] != null &&
                builder.GetHeaders()[ParameterConstant.X_JDCLOUD_CONTENT_SHA256].Count > 0)
            {
                contentSha256 = builder.GetHeaders()[ParameterConstant.X_JDCLOUD_CONTENT_SHA256][0];
            }
            else {
                contentSha256 = CalculateContentHash(builder);
            }
            string canonicalRequest = CreateCanonicalRequest(builder, contentSha256);
            string stringToSign = CreateStringToSign(canonicalRequest, signerRequestParams);
            byte[] signingKey = deriveSigningKey(credentials, signerRequestParams);
            byte[] signature = ComputeSignature(stringToSign,signingKey);
            builder.Header(ParameterConstant.AUTHORIZATION, BuildAuthorizationHeader(builder, signature,credentials, signerRequestParams));

            return builder;
        }

        /// <summary>
        /// 构建Authorization头信息
        /// </summary>
        /// <param name="builder">请求参数封装信息</param>
        /// <param name="signature">签名信息</param>
        /// <param name="credentials">证书信息</param>
        /// <param name="signerParams">签名参数信息</param>
        /// <returns>http头 Authorization 信息字符串</returns>
        private string BuildAuthorizationHeader(SdkHttpFullRequestBuilder builder, byte[] signature, ICredentials credentials,
                                            SignerRequestParams signerParams)
        {
            string signingCredentials = credentials.AccessKeyId() + "/" + signerParams.Scope;
            string credential = "Credential=" + signingCredentials;
            string signerHeaders = "SignedHeaders=" + GetSignedHeadersString(builder);
            string signatureHeader = "Signature=" + StringUtils.ByteToHex(signature, true);

            return new StringBuilder().Append(ParameterConstant.JDCLOUD2_SIGNING_ALGORITHM)
                    .Append(" ")
                    .Append(credential)
                    .Append(", ")
                    .Append(signerHeaders)
                    .Append(", ")
                    .Append(signatureHeader)
                    .ToString();
        }

        /// <summary>
        /// 计算签名
        /// </summary>
        /// <param name="stringToSign">需要签名的字符串</param>
        /// <param name="signingKey">签名使用的key</param>
        /// <returns>签名后的字节数组信息</returns>
        private byte[] ComputeSignature(string stringToSign, byte[] signingKey)
        {
            byte[] stringToSignBytes = System.Text.Encoding.UTF8.GetBytes(stringToSign);

            return Sign(stringToSignBytes, signingKey, SigningAlgorithm.HMACSHA256);
        }


        /// <summary>
        /// 计算参与签名的密钥验证
        /// </summary>
        /// <param name="credentials">证书信息</param>
        /// <param name="signerRequestParams">需要签名的请求参数信息</param>
        /// <returns>计算后的签名信息字节数组</returns>
        private byte[] deriveSigningKey(ICredentials credentials, SignerRequestParams signerRequestParams)
        {
            byte[] signingKey = NewSigningKey(credentials, signerRequestParams.FormattedSigningDate,
                signerRequestParams.RegionName, signerRequestParams.ServiceName);
            return signingKey;
        }

        /// <summary>
        /// 计算参与签名的秘钥验证
        /// </summary>
        /// <param name="credentials">证书信息</param>
        /// <param name="dateStamp">时间戳</param>
        /// <param name="regionName">区域名称</param>
        /// <param name="serviceName">服务名称</param>
        /// <returns>计算后的签名信息字节数组</returns>
        private byte[] NewSigningKey(ICredentials credentials, String dateStamp, String regionName, String serviceName)
        {
            byte[] kSecret = System.Text.Encoding.UTF8.GetBytes($"JDCLOUD2{credentials.SecretAccessKey()}");
            byte[] kDate = Sign(dateStamp, kSecret, SigningAlgorithm.HMACSHA256);
            byte[] kRegion = Sign(regionName, kDate, SigningAlgorithm.HMACSHA256);
            byte[] kService = Sign(serviceName,kRegion, SigningAlgorithm.HMACSHA256);
            return Sign(ParameterConstant.JDCLOUD_TERMINATOR,kService, SigningAlgorithm.HMACSHA256);
        }

        /// <summary>
        /// 添加头信息
        /// </summary>
        /// <param name="builder">http请求信息</param>
        private void AddHostHeader(ref SdkHttpFullRequestBuilder builder)
        {

            var endPoint = builder.GetEndpoint();
            if (endPoint == null)
            {
                throw new ArgumentNullException(" can not get the uri from de SdkHttpFullRequestBuilder , please check the param set ");
            }
            StringBuilder hostHeaderBuilder = new StringBuilder(endPoint.Host);
            if (SdkHttpUtils.IsUsingNonDefaultPort(endPoint))
            {
                hostHeaderBuilder.Append(":").Append(endPoint.Port);
            }

            builder.Header(ParameterConstant.HOST, hostHeaderBuilder.ToString());
            string contentSha256 = CalculateContentHash(builder); 

        }


        /// <summary>
        /// 计算http content SHA256 hash 校验值
        /// </summary>
        /// <param name="builder">http  请求信息</param>
        /// <returns>计算后的16进制加密的 content 信息</returns>
        protected string CalculateContentHash(SdkHttpFullRequestBuilder builder)
        {
            try
            {
                string content = builder.GetContent();
#if NET35
                if (string.IsNullOrEmpty(content)||string.IsNullOrEmpty(content.Trim()))
#else
                if (string.IsNullOrWhiteSpace(content))
#endif     
                {
                    content = string.Empty;
                  
                } 
                string contentSha256 = StringUtils.ByteToHex(SignHash(content),true);
                return contentSha256;

            }
            catch (Exception ex)
            {

                throw new Exception("get the request content sha256 error", ex);
            }
        }

        /// <summary>
        ///  获得待计算签名的字符串
        /// </summary>
        /// <param name="canonicalRequest">canonicalRequest 字符串</param>
        /// <param name="signerParams">需要签名的参数信息</param>
        /// <returns>计算签名的字符串</returns>
        private string CreateStringToSign(String canonicalRequest,
                                     SignerRequestParams signerParams)
        {

              string stringToSign = new StringBuilder(signerParams.SigningAlgorithm)
                    .Append(ParameterConstant.LINE_SEPARATOR)
                    .Append(signerParams.FormattedSigningDateTime)
                    .Append(ParameterConstant.LINE_SEPARATOR)
                    .Append(signerParams.Scope)
                    .Append(ParameterConstant.LINE_SEPARATOR)
                    .Append(StringUtils.ByteToHex(SignHash(canonicalRequest), true))
                    .ToString();
            return stringToSign;
        }

        /// <summary>
        /// 生成预签名头信息
        /// </summary>
        /// <param name="builder">http 请求信息</param>
        /// <param name="contentSha256">http  content  计算过 hmac sha256 的内容信息</param>
        /// <returns>预签名头信息字符串</returns>
        private string CreateCanonicalRequest(SdkHttpFullRequestBuilder builder,string contentSha256)
        {
            string parameters = builder.GetParameters();
#if NET35
            if (!string.IsNullOrEmpty(parameters)&& !string.IsNullOrEmpty(parameters.Trim()))
#else
            if (!string.IsNullOrWhiteSpace(parameters))
#endif
            {
                if (parameters.StartsWith("?"))
                {
                    parameters = parameters.Substring(1);
                }
            }
            string path = SdkHttpUtils.AppendUri(builder.GetEndpoint().AbsolutePath, builder.GetResourcePath());
            string canonicalRequest = new StringBuilder(builder.GetHttpMethod().ToString().ToUpper())
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(GetCanonicalizedResourcePath(path,_doubleUrlEncode))
                .Append(ParameterConstant.LINE_SEPARATOR) 
                .Append(parameters)
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(GetCanonicalizedHeaderString(builder))
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(GetSignedHeadersString(builder))
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(contentSha256)
                .ToString();

            return canonicalRequest;
        }

        /// <summary>
        /// 生成签名头信息字符串
        /// </summary>
        /// <param name="builder">http 请求信息</param>
        /// <returns>签名头信息字符串</returns>
        private string GetSignedHeadersString(SdkHttpFullRequestBuilder builder)
        {
            var headers = builder.GetHeaders();
            var keys = headers.Keys;
            List<string> keysList = keys.ToList().OrderBy(p => p.ToLower(CultureInfo.GetCultureInfo("en-US"))).ToList();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (String header in keysList)
            {
                if (ShouldExcludeHeaderFromSigning(header))
                {
                    continue;
                }
                if (stringBuilder.Length > 0)
                {
                    stringBuilder.Append(";");
                }
                stringBuilder.Append(header.ToLower(CultureInfo.GetCultureInfo("en-US")));
            } 
            return stringBuilder.ToString(); 
        }

        /// <summary>
        /// 获取规范化的头信息
        /// </summary>
        /// <param name="builder">http 请求信息</param>
        /// <returns>规范化头信息字符串</returns>
        private string GetCanonicalizedHeaderString(SdkHttpFullRequestBuilder builder)
        {
            var headers = builder.GetHeaders();
            var keys = headers.Keys;
            List<string> keysList = keys.ToList().OrderBy(p=>p.ToLower(CultureInfo.GetCultureInfo("en-US"))).ToList();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in keysList)
            {
                if (ShouldExcludeHeaderFromSigning(item))
                {
                    continue;
                }
                string key = item.ToLower(CultureInfo.GetCultureInfo("en-US"));

               foreach(var headerValue in headers[item])
                {
                    string headerCompactedValue = StringUtils.AppendCompactedString(key);
                    stringBuilder.Append(key).Append(":");
                    if (headerValue != null)
                    {
                       string headerValueCompactedValue = StringUtils.AppendCompactedString(headerValue);
                        stringBuilder.Append(headerValueCompactedValue);
                    }
                    stringBuilder.Append("\n");
                }
            }
           

            return stringBuilder.ToString();
        } 

        /// <summary>
        /// 是否属于被排除的报文头
        /// </summary>
        /// <param name="header">头信息字符串</param>
        /// <returns>是否是需要排除的头信息</returns>
        private bool ShouldExcludeHeaderFromSigning(string header)
        {
            return LIST_OF_HEADERS_TO_IGNORE_IN_LOWER_CASE.Contains(header.ToLower());
        }
    }
}
