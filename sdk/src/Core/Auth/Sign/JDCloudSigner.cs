using JDCloudSDK.Core.Model;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Common;
using JDCloudSDK.Core.Utils;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Globalization;

namespace JDCloudSDK.Core.Auth.Sign
{
    /// <summary>
    /// 京东云网关签名类
    /// </summary>
    public class JDCloudSigner: IJDCloudSigner
    {
        /// <summary>
        /// 要进行忽略的签名头信息
        /// </summary>
        private static readonly string[] LIST_OF_HEADERS_TO_IGNORE_IN_LOWER_CASE = { "connection","x-jdcloud-trace-id"};
          

        /// <summary>
        /// URL 进行二次加密
        /// </summary>
        public bool DoubleUrlEncode { get; set; }=false;
        
        /// <summary>
        /// 签名注释
        /// </summary>
        public JDCloudSigner()
        {
        }

        /// <summary>
        /// 进行二次url endcode 加密的签名
        /// </summary>
        /// <param name="doubleUrlEncode"></param>
        public JDCloudSigner(bool doubleUrlEncode)
        {
             DoubleUrlEncode = doubleUrlEncode;
        }

        /// <summary>
        /// 进行请求签名
        /// </summary>
        /// <param name="requestModel"></param>
        /// <param name="credentials"></param>
        /// <returns></returns>
        public SignedRequestModel Sign(RequestModel requestModel, Credential credentials) {
            string nonceId =Guid.NewGuid().ToString().ToLower();
            var signDate = requestModel.OverrddenDate == null ? DateTime.Now:requestModel.OverrddenDate.Value;
            string formattedSigningDateTime = signDate.ToString(ParameterConstant.DATA_TIME_FORMAT);
            string formattedSigningDate = signDate.ToString(ParameterConstant.HEADER_DATA_FORMAT);
            string scope = GenerateScope(formattedSigningDate, requestModel.ServiceName, requestModel.RegionName);
            var requestHeader = requestModel.Header;
            requestHeader.Add(ParameterConstant.X_JDCLOUD_DATE,
                              new List<string> { formattedSigningDateTime } );
            requestHeader.Add(ParameterConstant.X_JDCLOUD_NONCE, 
                              new List<string> { nonceId });
            var contentSHA256 = CalculateContentHash(requestModel);
            var canonicalRequest = CreateCanonicalRequest(requestModel, contentSHA256);
            var stringToSign = CreateStringToSign(canonicalRequest, formattedSigningDateTime, scope);

            byte[] kSecret = System.Text.Encoding.UTF8.GetBytes($"JDCLOUD2{credentials.SecretAccessKey}");
            byte[] kDate =SignUtil.Sign(formattedSigningDate, kSecret, ParameterConstant.SIGN_SHA256);
            byte[] kRegion = SignUtil.Sign(requestModel.RegionName, kDate, ParameterConstant.SIGN_SHA256);
            byte[] kService = SignUtil.Sign(requestModel.ServiceName, kRegion, ParameterConstant.SIGN_SHA256);
            byte[] signingKey = SignUtil.Sign(ParameterConstant.JDCLOUD_TERMINATOR, kService, ParameterConstant.SIGN_SHA256);
            byte[] signature = ComputeSignature(stringToSign, signingKey);
           // Console.WriteLine($" kSecret={ BitConverter.ToString(kSecret).Replace("-", "")}");
           // Console.WriteLine($" kDate={ BitConverter.ToString(kDate).Replace("-", "")}");
           // Console.WriteLine($" kRegion={ BitConverter.ToString(kRegion).Replace("-", "")}");
           // Console.WriteLine($" kService={ BitConverter.ToString(kService).Replace("-", "")}");
           // Console.WriteLine($" signingKey={ BitConverter.ToString(signingKey).Replace("-", "")}");
           // Console.WriteLine($" signature={ BitConverter.ToString(signature).Replace("-", "")}");

            string signingCredentials = credentials.AccessKeyId + "/" + scope;
            string credential = "Credential=" + signingCredentials;
            string signerHeaders = "SignedHeaders=" + GetSignedHeadersString(requestModel);
            string signatureHeader = "Signature=" + StringUtils.ByteToHex(signature, true);

            var signHeader = new StringBuilder().Append(ParameterConstant.JDCLOUD2_SIGNING_ALGORITHM)
                    .Append(" ")
                    .Append(credential)
                    .Append(", ")
                    .Append(signerHeaders)
                    .Append(", ")
                    .Append(signatureHeader)
                    .ToString();
           
            requestModel.AddHeader(ParameterConstant.AUTHORIZATION, signHeader);
            SignedRequestModel signedRequestModel = new SignedRequestModel();
            signedRequestModel.CanonicalRequest = canonicalRequest;
            signedRequestModel.ContentSHA256 = contentSHA256;
            foreach (var header in requestModel.Header) {
                signedRequestModel.RequestHead.Add(header.Key, string.Join(",", header.Value.ToArray()));
            }
            signedRequestModel.RequestNonceId = nonceId; 
            signedRequestModel.SignedHeaders = signHeader;
            signedRequestModel.StringSignature = stringToSign;
            signedRequestModel.StringToSign = stringToSign;
            
            return signedRequestModel;
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
            return SignUtil.Sign(stringToSignBytes, signingKey, ParameterConstant.SIGN_SHA256);
        }




        /// <summary>
        ///  获得待计算签名的字符串
        /// </summary>
        /// <param name="canonicalRequest">canonicalRequest 字符串</param>
        /// <param name="formattedSigningDateTime">签名时间信息</param>
        /// <param name="scope">签名 scope 信息</param>
        /// <returns>计算签名的字符串</returns>
        private string CreateStringToSign(string canonicalRequest,
                                     string formattedSigningDateTime,string scope)
        {
            string stringToSign = new StringBuilder(ParameterConstant.JDCLOUD2_SIGNING_ALGORITHM)
                  .Append(ParameterConstant.LINE_SEPARATOR)
                  .Append(formattedSigningDateTime)
                  .Append(ParameterConstant.LINE_SEPARATOR)
                  .Append(scope)
                  .Append(ParameterConstant.LINE_SEPARATOR)
                  .Append(StringUtils.ByteToHex(SignUtil.SignHash(canonicalRequest), true))
                  .ToString();
            return stringToSign;
        }
        /// <summary>
        /// order request parameters
        /// </summary>
        /// <param name="requestQueryParameters"></param>
        /// <returns></returns>
        private static string OrderRequestParameters(string requestQueryParameters) {
            if (requestQueryParameters.IsNullOrWhiteSpace()) {
                return string.Empty;
            }
            if (!requestQueryParameters.IsNullOrWhiteSpace())
            {
                if (requestQueryParameters.StartsWith("?"))
                {
                    requestQueryParameters = requestQueryParameters.Substring(1);
                }
            }
            Dictionary<string, string> paramDic = new Dictionary<string, string>();
            var paramArray = requestQueryParameters.Split('&');
            if (paramArray != null && paramArray.Length > 0) {
                foreach (var paramKeyValue in paramArray) {
                    var keyValue = paramKeyValue.Split('=');
                    if (keyValue != null && keyValue.Length > 0) {
                        if (keyValue.Length == 1)
                        {
                            paramDic.Add(keyValue[0], string.Empty);
                        }
                        else if (keyValue.Length == 2)
                        {
                            paramDic.Add(keyValue[0], keyValue[1]);
                        }
                        else {
                            StringBuilder stringBuilder = new StringBuilder();
                            for (int i = 1; i < keyValue.Length; i++) {
                                if (i == keyValue.Length - 1)
                                {
                                    stringBuilder.Append(keyValue[i]);
                                }
                                else {
                                    stringBuilder.Append(keyValue[i]).Append("=");
                                }
                            } 
                            paramDic.Add(keyValue[0], stringBuilder.ToString());
                        }
                    }
                }
            }
            if (paramDic != null && paramDic.Count > 0) {
                StringBuilder resultBuilder = new StringBuilder();
                var orderParamDic = paramDic.OrderBy(p => p.Key);
                foreach (var param in orderParamDic) {
                    resultBuilder.Append(param.Key).Append("=").Append(param.Value);
                    resultBuilder.Append("&");
                }
                return resultBuilder.ToString().TrimEnd('&');
            } 
            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestModel"></param>
        /// <param name="contentSha256"></param>
        /// <returns></returns>
        private string CreateCanonicalRequest(RequestModel requestModel, string contentSha256) {
            var requestParameters = OrderRequestParameters(requestModel.QueryParameters);
            string path = "";
            StringBuilder stringBuilder = new StringBuilder();
          //  stringBuilder.Append(requestModel.Uri.Host);
          //  if (requestModel.RequestPort != null && requestModel.RequestPort > 0) {
          //      stringBuilder.Append(":").Append(requestModel.RequestPort);
          //  }
            if (!requestModel.ResourcePath.TrimStart().StartsWith("/")) {
                stringBuilder.Append("/");
            } 
            stringBuilder.Append(requestModel.ResourcePath);
            path = stringBuilder.ToString();
            string canonicalRequest = new StringBuilder(requestModel.HttpMethod)
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(GetCanonicalizedResourcePath(path, false))
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(requestParameters)
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(GetCanonicalizedHeaderString(requestModel))
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(GetSignedHeadersString(requestModel))
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(contentSha256)
                .ToString(); 
            return canonicalRequest;
        }


        /// <summary>
        /// 生成签名头信息字符串
        /// </summary>
        /// <param name="requestModel">http 请求信息</param>
        /// <returns>签名头信息字符串</returns>
        private string GetSignedHeadersString(RequestModel requestModel)
        {
            var headers = requestModel.Header;
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
        /// <param name="requestModel">签名请求信息</param>
        /// <returns>规范化头信息字符串</returns>
        private string GetCanonicalizedHeaderString(RequestModel requestModel)
        {
            var headers = requestModel.Header;
            var keys = headers.Keys;
            List<string> keysList = keys.ToList().OrderBy(p => p.ToLower(CultureInfo.GetCultureInfo("en-US"))).ToList();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in keysList)
            {
                if (ShouldExcludeHeaderFromSigning(item))
                {
                    continue;
                }
                string key = item.ToLower(CultureInfo.GetCultureInfo("en-US"));

                foreach (var headerValue in headers[item])
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


        /// <summary>
        /// 进行请求path 转换
        /// </summary>
        /// <param name="path">请求path</param>
        /// <param name="doubleUrlEncode">是否进行二次编码</param>
        /// <returns>转换后的path</returns>
        protected string GetCanonicalizedResourcePath(string path, bool doubleUrlEncode)
        {
 
            if (path.IsNullOrWhiteSpace()) 
            {
                return "/";
            }
            else
            {
                string value = doubleUrlEncode ?Uri.EscapeDataString(path).Replace("%2F","/"): path;
                if (value.StartsWith("/"))
                {
                    return value;
                }
                else
                {
                    return $"/{value}";
                }
            }
        }

        /// <summary>
        /// 计算http content SHA256 hash 校验值
        /// </summary>
        /// <param name="requestModel">http  请求信息</param>
        /// <returns>计算后的16进制加密的 content 信息</returns>
        protected string CalculateContentHash(RequestModel requestModel)
        {
            try
            {
                byte[] content = requestModel.Content;
                if (content != null && content.Length>0)
                {
                    content = new byte[0];
                }
                string contentSha256 = StringUtils.ByteToHex(SignUtil.SignHash(content), true);
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
        /// <param name="requestModel">需要签名的参数信息</param>
        /// <returns>计算签名的字符串</returns>
        private string CreateStringToSign(string canonicalRequest,
                                     RequestModel requestModel)
        {

            string formatDate = requestModel.OverrddenDate == null || !requestModel.OverrddenDate.HasValue ?
               DateTime.UtcNow.ToString(ParameterConstant.HEADER_DATA_FORMAT) : requestModel.OverrddenDate.Value.ToString(ParameterConstant.HEADER_DATA_FORMAT);
            StringBuilder scopeBuilder = new StringBuilder();
            scopeBuilder.Append(formatDate)
                .Append("/")
                .Append(requestModel.RegionName)
                .Append("/")
                .Append(requestModel.ServiceName)
                .Append("/")
                .Append(ParameterConstant.JDCLOUD_TERMINATOR);
          
            //需要构造scope
            string scope = scopeBuilder.ToString();
            string stringToSign = new StringBuilder(requestModel.SignType)
                  .Append(ParameterConstant.LINE_SEPARATOR)
                  .Append(requestModel.Header[ParameterConstant.X_JDCLOUD_DATE][0])
                  .Append(ParameterConstant.LINE_SEPARATOR)
                  .Append(scope)
                  .Append(ParameterConstant.LINE_SEPARATOR)
                  .Append(StringUtils.ByteToHex(SignUtil.SignHash(canonicalRequest), true))
                  .ToString();
            return stringToSign;
        }


    

        /// <summary>
        /// 添加时间请求头信息
        /// </summary>
        /// <param name="requestModel">请求信息</param>
        /// <returns></returns>
        private RequestModel AddRequestDateHeader(RequestModel requestModel)
        {
            string formatDateTime = requestModel.OverrddenDate == null || !requestModel.OverrddenDate.HasValue ?
                DateTime.UtcNow.ToString(ParameterConstant.DATA_TIME_FORMAT) : requestModel.OverrddenDate.Value.ToString(ParameterConstant.DATA_TIME_FORMAT);
            requestModel.AddHeader(ParameterConstant.X_JDCLOUD_DATE, formatDateTime); 
            return requestModel;
        }

        /// <summary>
        /// 添加ContentType头信息
        /// </summary>
        /// <param name="requestModel">请求信息</param>
        /// <returns></returns>
        private RequestModel AddContentTypeHeader(RequestModel requestModel)
        {
            if (requestModel.ContentType.IsNullOrWhiteSpace())
            {
                requestModel.ContentType = ParameterConstant.MIME_JSON;
            }
            requestModel.AddHeader(ParameterConstant.CONTENT_TYPE, requestModel.ContentType);

            return requestModel;
        }

        /// <summary>
        /// 添加host 请求信息
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        private RequestModel AddHostHeader(RequestModel requestModel)
        {
            string url = requestModel.Uri.Host;
            if (url.IsNullOrWhiteSpace())
            {
                throw new ArgumentNullException("the request url is not set,please check the client url config");
            }
            if ( requestModel.Uri.IsDefaultPort)
            {
                requestModel.AddHeader(ParameterConstant.HOST, requestModel.Uri.Host);
                
            }else
            {
                StringBuilder signHostBuilder = new StringBuilder();
                signHostBuilder.Append(requestModel.Uri.Host).Append(":").Append(requestModel.Uri.Port);
                requestModel.AddHeader(ParameterConstant.HOST, signHostBuilder.ToString());
            }

            return requestModel;
        } 
        /// <summary>
        /// Returns the scope to be used for the signing.
        /// </summary>
        /// <param name="dateStamp">日期戳</param>
        /// <param name="serviceName">服务名</param>
        /// <param name="regionName">区域名</param>
        /// <returns>Scope 字符串</returns>
        private string GenerateScope(string dateStamp, string serviceName, string regionName)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(dateStamp)
                .Append("/")
                .Append(regionName)
                .Append("/")
                .Append(serviceName)
                .Append("/")
                .Append(ParameterConstant.JDCLOUD_TERMINATOR);
            return stringBuilder.ToString();
        }



    }

}
