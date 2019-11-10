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
            string nonceId = "";
            if (requestModel.NonceId.IsNullOrWhiteSpace())
            {
                nonceId = Guid.NewGuid().ToString().ToLower();
            }
            else {
                nonceId = requestModel.NonceId;
            }
            
            var signDate = requestModel.OverrddenDate == null ? DateTime.Now:requestModel.OverrddenDate.Value;
            string formattedSigningDateTime = signDate.ToString(ParameterConstant.DATA_TIME_FORMAT);
            string formattedSigningDate = signDate.ToString(ParameterConstant.HEADER_DATA_FORMAT);
            string scope = SignUtil.GenerateScope(formattedSigningDate, requestModel.ServiceName, requestModel.RegionName);
            var requestHeader = requestModel.Header;
            requestHeader.Add(ParameterConstant.X_JDCLOUD_DATE,
                              new List<string> { formattedSigningDateTime } );
            requestHeader.Add(ParameterConstant.X_JDCLOUD_NONCE, 
                              new List<string> { nonceId });
            var contentSHA256 = SignUtil.CalculateContentHash(requestModel.Content);
            var requestParameters = OrderRequestParameters(requestModel.QueryParameters);
            string path = "";
            StringBuilder stringBuilder = new StringBuilder();
            if (!requestModel.ResourcePath.TrimStart().StartsWith("/")) {
                stringBuilder.Append("/");
            }
            stringBuilder.Append(requestModel.ResourcePath);
            path = stringBuilder.ToString();
            var canonicalRequest = SignUtil.CreateCanonicalRequest(requestParameters,
                GetCanonicalizedResourcePath(path,false),
                requestModel.HttpMethod.ToUpper()
                ,GetCanonicalizedHeaderString(requestModel),
                GetSignedHeadersString(requestModel), contentSHA256);
            var stringToSign = SignUtil.CreateStringToSign(canonicalRequest, formattedSigningDateTime, scope);

            byte[] kSecret = System.Text.Encoding.UTF8.GetBytes($"JDCLOUD2{credentials.SecretAccessKey}");
            byte[] kDate =SignUtil.Sign(formattedSigningDate, kSecret, ParameterConstant.SIGN_SHA256);
            byte[] kRegion = SignUtil.Sign(requestModel.RegionName, kDate, ParameterConstant.SIGN_SHA256);
            byte[] kService = SignUtil.Sign(requestModel.ServiceName, kRegion, ParameterConstant.SIGN_SHA256);
            byte[] signingKey = SignUtil.Sign(ParameterConstant.JDCLOUD_TERMINATOR, kService, ParameterConstant.SIGN_SHA256);
            byte[] signature = SignUtil.ComputeSignature(stringToSign, signingKey);
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
            string stringToSign = new StringBuilder(ParameterConstant.SIGN_SHA256)
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
        /// sign with all param 
        /// </summary>
        /// <param name="host"> request host</param>
        /// <param name="port"> request port</param>
        /// <param name="path"> request path</param>
        /// <param name="queryString">request query string</param>
        /// <param name="serviceName">the request service name</param>
        /// <param name="httpRequestMethod">the request http method</param>
        /// <param name="regionName">the source region name</param>
        /// <param name="apiVersion">the api version</param>
        /// <param name="credentials">the jdcloud credentials</param>
        /// <param name="content">the request body content</param>
        /// <param name="contentType">the request body content type</param>
        /// <param name="header">the request header</param>
        /// <param name="nonceId">the request nonce id</param>
        /// <param name="overrddenDate">the sgin overrdden date</param>
        /// <returns></returns>
        public SignedRequestModel Sign(string host, string port, string path, string queryString, 
            string serviceName, string httpRequestMethod, string regionName, string apiVersion, Credential credentials,
            byte[] content = null,
            string contentType = "application/json",
            Dictionary<string, List<string>> header = null,
            string nonceId=null, DateTime? overrddenDate = null)
        {
            RequestModel requestModel = new RequestModel();
            requestModel.ServiceName = serviceName;
            requestModel.RegionName = regionName;
            if (header != null && header.Count > 0) {
                requestModel.Header.Concat(header).ToDictionary(k => k.Key, v => v.Value);
            }
            requestModel.Content = content;
            requestModel.ContentType = contentType;
            requestModel.HttpMethod = httpRequestMethod;
            requestModel.OverrddenDate = overrddenDate;
            requestModel.ApiVersion = apiVersion;
            requestModel.SignType = JDCloudSignVersionType.JDCloud_V2;
            path = path.StartsWith("/") ? path : "/" + path;
            queryString = queryString.StartsWith("?") ? queryString : "?" + queryString;
            int portValue = 0;
            port = port == null || int.TryParse(port, out portValue) ? null : ":" + port;
            var requestUrl = $"http://{host}{port}{path}{queryString}";
            Uri uri = new Uri(requestUrl);
            requestModel.Uri = uri;// uri.Host
             
            requestModel.QueryParameters = queryString;

            if (!(uri.Scheme.ToLower() == "http" && uri.Port == 80) &&
               !(uri.Scheme.ToLower() == "https" && uri.Port == 443))
            {
                requestModel.RequestPort = uri.Port;
            }
            requestModel.ResourcePath = path;
            return Sign(requestModel, credentials);
            
        }
    }

}
