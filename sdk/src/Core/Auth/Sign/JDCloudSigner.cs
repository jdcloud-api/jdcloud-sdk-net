using JDCloudSDK.Core.Model;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Common;
using JDCloudSDK.Core.Utils;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

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
        public SignedRequestModel Sign(RequestModel requestModel, Credentials credentials) {
            string nonceId = Guid.NewGuid().ToString().ToLower();
            var signDate = requestModel.OverrddenDate == null ? DateTime.Now:requestModel.OverrddenDate.Value;
            string formattedSigningDatetime = signDate.ToString(ParameterConstant.DATA_TIME_FORMAT);
            string formattedSigningDate = signDate.ToString(ParameterConstant.HEADER_DATA_FORMAT);
            string scope = GenerateScope(formattedSigningDate, requestModel.ServiceName, requestModel.RegionName);
            var requestHeader = requestModel.Header;
            requestHeader.Add(ParameterConstant.X_JDCLOUD_DATE,
                              new List<string> { formattedSigningDatetime } );
            requestHeader.Add(ParameterConstant.X_JDCLOUD_NONCE, 
                              new List<string> { nonceId });

            var contentSHA256 = CalculateContentHash(requestModel);
            var canonicalRequest = CreateCanonicalRequest(requestModel, contentSHA256);

            return null;
        }


        private string CreateCanonicalRequest(RequestModel requestModel, string contentSha256) {
            var requestParameters = requestModel.QueryParameters;
            if (!requestParameters.IsNullOrWhiteSpace()) {
                if (requestParameters.StartsWith("?")) {
                    requestParameters = requestParameters.Substring(1);
                }
            }
            string path = "";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(requestModel.Uri.Host);
            if (requestModel.RequestPort != null && requestModel.RequestPort > 0) {
                stringBuilder.Append(":").Append(requestModel.RequestPort);
            }
            stringBuilder.Append("/");
            stringBuilder.Append(requestModel.ResourcePath);
            path = stringBuilder.ToString();
            string canonicalRequest = new StringBuilder(requestModel.HttpMethod.ToString().ToUpper())
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(GetCanonicalizedResourcePath(path, false))
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(requestParameters)
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(GetCanonicalizedHeaderString(builder))
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(GetSignedHeadersString(builder))
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(contentSha256)
                .ToString();


            return string.Empty;
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
        /// 获取当前传入的区域信息
        /// </summary>
        /// <param name="host">http 请求host</param>
        /// <param name="regionNameOverride">  region name 字符串</param>
        /// <returns>格式化后的region 信息 </returns>
        private string ParseRegion(string host, string regionNameOverride)
        {
 
            return !regionNameOverride.IsNullOrWhiteSpace() ? regionNameOverride
                    : HostNameUtils.ParseRegion(host,this.ServiceName);

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
