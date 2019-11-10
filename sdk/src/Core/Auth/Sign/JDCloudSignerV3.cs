using System;
using System.Collections.Generic;
using JDCloudSDK.Core.Model;
using System.Linq;
using JDCloudSDK.Core.Utils;
using System.Text;
using JDCloudSDK.Core.Common;
using System.Globalization;

namespace JDCloudSDK.Core.Auth.Sign
{
    /// <summary>
    /// jdcloud signer v3 
    /// </summary>
    public class JDCloudSignerV3 : IJDCloudSigner
    {

        private static readonly string[] REQUEST_METHOD = { "GET", "POST", "PUT", "HEAD", "PATCH", "DELETE", "CONNECT", "OPTIONS", "TRACE" };

        private static readonly string[] NOT_SIGN_REQUEST_HEAD = { "cache-control","content-type","content-length",
            "host","expect","max-forwards","pragma","range","te","if-match","if-none-match","if-modified-since","if-unmodified-since","if-range",
            "accept","authorization","proxy-authorization","from","referer","user-agent","x-jdcloud-request-id"};

        /// <summary>
        /// signer v3 code
        /// </summary>
        public JDCloudSignerV3()
        {
        }

        /// <summary>
        /// sign with RequestModel
        /// </summary>
        /// <param name="requestModel"></param>
        /// <param name="credentials"></param>
        /// <returns></returns>
        public SignedRequestModel Sign(RequestModel requestModel, Credential credentials)
        {

            string nonceId = "";
            if (requestModel.NonceId.IsNullOrWhiteSpace())
            {
                nonceId = Guid.NewGuid().ToString().ToLower();
            }
            else
            {
                nonceId = requestModel.NonceId;
            }

            var signDate = requestModel.OverrddenDate == null ? DateTime.Now : requestModel.OverrddenDate.Value;
            string formattedSigningDateTime = signDate.ToString(ParameterConstant.DATA_TIME_FORMAT);
            string formattedSigningDate = signDate.ToString(ParameterConstant.HEADER_DATA_FORMAT);
            string scope = SignUtil.GenerateScope(formattedSigningDate, requestModel.ServiceName, requestModel.RegionName);
            var requestHeader = requestModel.Header;
            requestHeader.Add(ParameterConstant.X_JDCLOUD_DATE,
                              new List<string> { formattedSigningDateTime });
            requestHeader.Add(ParameterConstant.X_JDCLOUD_NONCE,
                              new List<string> { nonceId });
            var contentSHA256 = SignUtil.CalculateContentHash(requestModel.Content);


            string queryParams = ProcessQueryString(requestModel.QueryParameters);
            string requestPath = ProcessRequestPath(requestModel.ResourcePath);
            string requestMethod = ProcessRequestMethod(requestModel.HttpMethod);
            Dictionary<string, string> processHeader = ProcessRequstHeader(ProcessRequestHeaderWithMoreValue(requestModel.Header));
            string signHeaderString = GetSignedHeadersString(processHeader);
            string signHeaderKeyString = GetSignedHeadersKeyString(processHeader);
            var canonicalRequest = SignUtil.CreateCanonicalRequest(queryParams, requestPath, requestMethod, signHeaderString, signHeaderKeyString, contentSHA256);
            var stringToSign = SignUtil.CreateStringToSign(canonicalRequest, formattedSigningDateTime, scope);

            byte[] kSecret = System.Text.Encoding.UTF8.GetBytes($"JDCLOUD3{credentials.SecretAccessKey}");
            byte[] kDate = SignUtil.Sign(formattedSigningDate, kSecret, ParameterConstant.SIGN_SHA256);
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
            string signerHeaders = "SignedHeaders=" + signHeaderKeyString;
            string signatureHeader = "Signature=" + StringUtils.ByteToHex(signature, true);

            var signHeader = new StringBuilder().Append(ParameterConstant.JDCLOUD2_SIGNING_ALGORITHM_V3)
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
            foreach (var header in requestModel.Header)
            {
                signedRequestModel.RequestHead.Add(header.Key, string.Join(",", header.Value.ToArray()));
            }
            signedRequestModel.RequestNonceId = nonceId;
            signedRequestModel.SignedHeaders = signHeader;
            signedRequestModel.StringSignature = stringToSign;
            signedRequestModel.StringToSign = stringToSign;

            return signedRequestModel; 
        }





        private static string ProcessRequestMethod(string requestMethod)
        {

            if (requestMethod.IsNullOrWhiteSpace())
            {
                return requestMethod;
            }

            requestMethod = requestMethod.ToUpper();

            if (!REQUEST_METHOD.Contains(requestMethod))
            {
                throw new ArgumentException($" request method :{requestMethod} not support");
            }

            return requestMethod;
        }

        /// <summary>
        /// jdcloud v3 sign method
        /// </summary>
        /// <param name="host">request url host</param>
        /// <param name="port">request url port</param>
        /// <param name="path">request url path</param>
        /// <param name="queryString">request url query string</param>
        /// <param name="serviceName">the service name for jdcloud</param>
        /// <param name="httpRequestMethod">the http request method</param>
        /// <param name="regionName">the region name for jdcloud</param>
        /// <param name="apiVersion">the api version</param>
        /// <param name="credentials">the jdcloud user credentials</param>
        /// <param name="content">the request body content</param>
        /// <param name="contentType">the request body content type</param>
        /// <param name="header">the request header</param>
        /// <param name="overrddenDate">the sign date overrdden value</param>
        /// <param name="nonceId">the nonce id the request need</param>
        /// <returns></returns>
        public SignedRequestModel Sign(string host, string port, string path, string queryString, string serviceName,
            string httpRequestMethod, string regionName,
            string apiVersion, Credential credentials,  byte[] content = null,
            string contentType = "application/json",
            Dictionary<string, List<string>> header = null,
            string nonceId = null, DateTime? overrddenDate = null)
        {
            httpRequestMethod = ProcessRequestMethod(httpRequestMethod);
            if (path.IsNullOrWhiteSpace())
            {
                path = "/";
            } 
            RequestModel requestModel = new RequestModel();
            requestModel.ServiceName = serviceName;
            requestModel.RegionName = regionName;
            if (header != null && header.Count > 0)
            {
                requestModel.Header.Concat(header).ToDictionary(k => k.Key, v => v.Value);
            }
            requestModel.Content = content;
            requestModel.ContentType = contentType;
            requestModel.HttpMethod = httpRequestMethod;
            requestModel.OverrddenDate = overrddenDate;
            requestModel.ApiVersion = apiVersion;
            requestModel.SignType = JDCloudSignVersionType.JDCloud_V3;
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

        /// <summary>
        /// get header signed string
        /// </summary>
        /// <param name="needSignHeaders">the headers while sign</param>
        /// <returns></returns>

        public static string GetSignedHeadersString(Dictionary<string, string> needSignHeaders) {
            if (needSignHeaders == null | needSignHeaders.Count == 0)
            {
                return null;
            }
            needSignHeaders = needSignHeaders.OrderBy(p => p.Key).ToDictionary(k => k.Key, v => v.Value);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in needSignHeaders) {
                string key = item.Key.ToLower(CultureInfo.GetCultureInfo("en-US"));
                stringBuilder.Append(key).Append(":").Append(item.Value).Append("\n");
            }
            return stringBuilder.ToString();

        }

        /// <summary>
        /// get need sign header key 
        /// </summary>
        /// <param name="needSignHeaders"></param>
        /// <returns></returns>
        public static string GetSignedHeadersKeyString(Dictionary<string, string> needSignHeaders) {
            if (needSignHeaders == null | needSignHeaders.Count == 0) {
                return null;
            }
            needSignHeaders = needSignHeaders.OrderBy(p => p.Key).ToDictionary(k => k.Key, v => v.Value);
            string[] signHeaderKey = needSignHeaders.Keys.ToArray();
            string signHeader = string.Join(";", signHeaderKey); 
            return signHeader; 
        }

        /// <summary>
        /// convert header more then one value to a string value
        /// </summary>
        /// <param name="header"> the request header </param>
        /// <returns></returns>
        public static Dictionary<string, string> ProcessRequestHeaderWithMoreValue(Dictionary<string, List<string>> header) {
            Dictionary<string, string> result = new Dictionary<string, string>();

            if (header != null && header.Count > 0) {
                foreach (var item in header) {
                    if (!item.Key.IsNullOrWhiteSpace()) {
                        if (item.Value != null && item.Value.Count > 0)
                        {
                            string value = string.Join(",", item.Value.Select(p => p.Trim()).ToArray());
                            result.Add(item.Key, value);
                        }
                        else {
                            result.Add(item.Key, string.Empty);
                        }
                        
                    }
                }
            }
            return result;

        }

        /// <summary>
        /// process request head info
        /// </summary>
        /// <param name="header"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ProcessRequstHeader(Dictionary<string, string> header) {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (header != null && header.Count > 0) {

                foreach (var item in header) {
                    if (!item.Key.IsNullOrWhiteSpace()) {
                        string key = item.Key.ToLower().Trim();
                        if (!NOT_SIGN_REQUEST_HEAD.Contains(key)) {
                            result.Add(key, item.Value.Trim());
                        }
                    }
                } 
            }
            
            return result;
        }

        /// <summary>
        /// process requst url query string value
        /// </summary>
        /// <param name="queryString">request query string </param>
        /// <returns></returns>
       public static string ProcessQueryString(string queryString) {

            if (queryString.IsNullOrWhiteSpace()) {

                return string.Empty;
            }
            if (queryString.StartsWith("?")) {
                queryString = queryString.Remove(0,1);
            }
            queryString = queryString.Replace("+", " ");
            var queryStringArray = queryString.Split('&'); 
            List<QueryParam> queryParamList = new List<QueryParam>();
            if(queryStringArray!=null && queryStringArray.Length > 0)
            {
                foreach (var item in queryStringArray) {
                    if (!item.IsNullOrWhiteSpace()) {
                        var paramKV = item.Split('=');
                        if (paramKV != null&& paramKV.Length>0) {
                            if (paramKV.Length == 1&& ! paramKV[0].IsNullOrWhiteSpace())
                            {
                                string value = JDCloudSignV3Util.UnescapeDataStringRfc3986(paramKV[0]);
                                QueryParam queryParam = new QueryParam {Key = JDCloudSignV3Util.EscapeUriDataStringRfc3986(value),Value=string.Empty };
                                queryParamList.Add(queryParam);
                            }
                            else if (paramKV.Length == 2 && !paramKV[0].IsNullOrWhiteSpace()) {
                                string key = JDCloudSignV3Util.UnescapeDataStringRfc3986(paramKV[0]);
                                string value = JDCloudSignV3Util.UnescapeDataStringRfc3986(paramKV[1]);
                                QueryParam queryParam = new QueryParam { Key = JDCloudSignV3Util.EscapeUriDataStringRfc3986(key),
                                    Value = JDCloudSignV3Util.EscapeUriDataStringRfc3986(value) };
                                queryParamList.Add(queryParam);
                            }
                            else {
                                if (!paramKV[0].IsNullOrWhiteSpace()) {

                                    string key = JDCloudSignV3Util.UnescapeDataStringRfc3986(paramKV[0]);
                                    string queryParamValue = string.Join("=", paramKV.Skip(1).Take(paramKV.Length - 1).ToArray());
                                    string value = JDCloudSignV3Util.UnescapeDataStringRfc3986(queryParamValue);
                                    QueryParam queryParam = new QueryParam
                                    {
                                        Key = JDCloudSignV3Util.EscapeUriDataStringRfc3986(key),
                                        Value = JDCloudSignV3Util.EscapeUriDataStringRfc3986(value)
                                    };
                                    queryParamList.Add(queryParam);
                                } 
                            }
                        } 
                    }
                }
            }

            if (queryParamList.Count > 0) {
                queryParamList = queryParamList.OrderBy(p => p.Key).ThenBy(p => p.Value).ToList();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var item in queryParamList) {
                    stringBuilder.Append(item.Key).Append("=");
                    if (item.Value.IsNullOrWhiteSpace())
                    {
                        stringBuilder.Append(string.Empty).Append("&");
                    }
                    else {
                        stringBuilder.Append(item.Value).Append("&");
                    }
                }
                var queryStringEncode = stringBuilder.ToString();
                if (!queryStringEncode.IsNullOrWhiteSpace())
                {
                    if (queryStringEncode.EndsWith("&"))
                    {
                        queryStringEncode = queryStringEncode.TrimEnd('&');
                    }
                }
                else {
                    queryStringEncode = string.Empty;
                }

                return queryStringEncode;
            }
            return string.Empty;
        }

        private static string ProcessRequestPath(string requestPath) {
            var path = requestPath.Replace("+", " ");
            var pathArray = path.Split('/');
            var pathDecodeArray = pathArray.Select(p => JDCloudSignV3Util.UnescapeDataStringRfc3986(p)).ToList();
            var pathList = pathDecodeArray.Select(p => JDCloudSignV3Util.EscapeUriDataStringRfc3986(p)).ToList();
            pathList.RemoveAll(p => p.Equals(string.Empty));
            path = string.Join("/", pathList.ToArray());
            if (!path.StartsWith("/"))
            {
                path = $"/{path}";
            }
            return path;
        }
    }

    /// <summary>
    /// model use save query param
    /// </summary>
    internal class QueryParam { 
        /// <summary>
        /// query string key
        /// </summary>
        public string Key { get; set; }


        /// <summary>
        /// query string value
        /// </summary>
        public string Value { get; set; }
    }
}
