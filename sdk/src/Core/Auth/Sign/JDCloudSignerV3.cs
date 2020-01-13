using System;
using System.Collections.Generic;
using JDCloudSDK.Core.Model;
#if !NET20&&!NET30
using System.Linq;
#endif
using JDCloudSDK.Core.Utils;
using System.Text;
using JDCloudSDK.Core.Common;
using System.Globalization;
using System.Collections;

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
            "accept","authorization","proxy-authorization","from","referer","user-agent","x-jdcloud-request-id","connection"};
        private static readonly string[] NOT_SIGN_REQUEST_HEAD_START = { "x-b3-" };
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
            var requestHeader = ProcessRequestHeaderKeyToLower(requestModel.Header);
            if (requestModel.NonceId.IsNullOrWhiteSpace())
            {
                nonceId = Guid.NewGuid().ToString().ToLower();
            } else if (requestHeader != null &&
                requestHeader.Count>0&&
                requestHeader.ContainsKey(ParameterConstant.X_JDCLOUD_NONCE.ToLower())) {
                List<string> headValues = requestHeader[ParameterConstant.X_JDCLOUD_NONCE.ToLower()];
                if (headValues != null && headValues.Count > 0)
                {
                    nonceId = headValues[0];
                }
                else {
                    nonceId = Guid.NewGuid().ToString().ToLower();
                } 
            }
            else
            {
                nonceId = requestModel.NonceId;
            }

            DateTime? signDate = null;
            if (requestHeader != null &&
                requestHeader.Count > 0 &&
                requestHeader.ContainsKey(ParameterConstant.X_JDCLOUD_DATE.ToLower()))
            {
                List<string> headerValues = requestHeader[ParameterConstant.X_JDCLOUD_DATE.ToLower()];
                if (headerValues != null && headerValues.Count > 0)
                {
                    string dateString = headerValues[0];
                    if (!dateString.IsNullOrWhiteSpace())
                    {
                        var tryParseDate = DateTime.Now;
                        if (DateTime.TryParseExact(dateString, ParameterConstant.DATA_TIME_FORMAT,
                            CultureInfo.GetCultureInfo("en-US"), System.Globalization.DateTimeStyles.None,
                                   out tryParseDate))
                        {
                            signDate = tryParseDate;
                        }
                    }
                }
            }
            else {
                if (requestModel.OverrddenDate != null && requestModel.OverrddenDate.HasValue)
                {
                    signDate = requestModel.OverrddenDate.Value;
                }
            }
            if (signDate == null||!signDate.HasValue) {
                signDate = DateTime.UtcNow;
            } 
            string formattedSigningDateTime = signDate.Value.ToString(ParameterConstant.DATA_TIME_FORMAT);
            string formattedSigningDate = signDate.Value.ToString(ParameterConstant.HEADER_DATA_FORMAT);
            string scope = SignUtil.GenerateScope(formattedSigningDate, requestModel.ServiceName, requestModel.RegionName,ParameterConstant.JDCLOUD_TERMINATOR_V3);
            
            requestHeader.Add(ParameterConstant.X_JDCLOUD_DATE,
                              new List<string> { formattedSigningDateTime });
            requestHeader.Add(ParameterConstant.X_JDCLOUD_NONCE,
                              new List<string> { nonceId });
            if (requestHeader.ContainsKey(ParameterConstant.X_JDCLOUD_ALGORITHM.ToLower()))
            {
                requestHeader[ParameterConstant.X_JDCLOUD_ALGORITHM.ToLower()] = new List<string> { ParameterConstant.JDCLOUD3_SIGNING_ALGORITHM_V3 };
            }
            else {
                requestHeader.Add(ParameterConstant.X_JDCLOUD_ALGORITHM.ToLower(), new List<string> { ParameterConstant.JDCLOUD3_SIGNING_ALGORITHM_V3 });
            }
            var contentSHA256 = "";
            if (requestHeader.ContainsKey(ParameterConstant.X_JDCLOUD_CONTENT_SHA256)) {
                List<string> contentSha256Value = requestHeader[ParameterConstant.X_JDCLOUD_CONTENT_SHA256];
                if (contentSha256Value != null && contentSha256Value.Count > 0) {
                    contentSHA256 = contentSha256Value[0];
                }
                
            }
            if (contentSHA256.IsNullOrWhiteSpace()) {
                contentSHA256 = SignUtil.CalculateContentHash(requestModel.Content);
            }  
            string queryParams = ProcessQueryString(requestModel.QueryParameters);
            string requestPath = ProcessRequestPath(requestModel.ResourcePath);
            string requestMethod = ProcessRequestMethod(requestModel.HttpMethod);
            Dictionary<string, string> processHeader = ProcessRequstHeader(ProcessRequestHeaderWithMoreValue(requestModel.Header));
            string signHeaderString = GetSignedHeadersString(processHeader);
            string signHeaderKeyString = GetSignedHeadersKeyString(processHeader);
            var canonicalRequest = SignUtil.CreateCanonicalRequest(queryParams, requestPath, requestMethod, signHeaderString, signHeaderKeyString, contentSHA256);
            var stringToSign = SignUtil.CreateStringToSign(canonicalRequest, formattedSigningDateTime, scope,ParameterConstant.JDCLOUD3_SIGNING_ALGORITHM_V3);

            byte[] kSecret = System.Text.Encoding.UTF8.GetBytes($"JDCLOUD3{credentials.SecretAccessKey}");
            byte[] kDate = SignUtil.Sign(formattedSigningDate, kSecret, ParameterConstant.SIGN_SHA256);
            byte[] kRegion = SignUtil.Sign(requestModel.RegionName, kDate, ParameterConstant.SIGN_SHA256);
            byte[] kService = SignUtil.Sign(requestModel.ServiceName, kRegion, ParameterConstant.SIGN_SHA256);
            byte[] signingKey = SignUtil.Sign(ParameterConstant.JDCLOUD_TERMINATOR_V3, kService, ParameterConstant.SIGN_SHA256);
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

            var signHeader = new StringBuilder().Append(ParameterConstant.JDCLOUD3_SIGNING_ALGORITHM_V3)
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
#if !NET20 && !NET30
            if (!REQUEST_METHOD.Contains(requestMethod))
            {
                throw new ArgumentException($" request method :{requestMethod} not support");
            }
#else
            var contains = false;
            foreach (var item in REQUEST_METHOD) {
                if (item.ToLower() == requestMethod.ToLower()) {
                    contains = true;
                }
            }

            if (!contains)
            {
                throw new ArgumentException($" request method :{requestMethod} not support");
            }
#endif
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
#if !NET30 && !NET20
                requestModel.Header.Concat(header).ToDictionary(k => k.Key, v => v.Value);
#else
                foreach (var item in header)
                {
                    requestModel.Header.Add(item.Key, item.Value);
                }
#endif
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

        public static string GetSignedHeadersString(IDictionary<string, string> needSignHeaders) {
            if (needSignHeaders == null | needSignHeaders.Count == 0)
            {
                return null;
            }
#if !NET20 && !NET30
            needSignHeaders = needSignHeaders.OrderBy(p => p.Key).ToDictionary(k => k.Key, v => v.Value);
#else
            var sortDic = new SortedDictionary<string, string>();
            foreach (var item in needSignHeaders) {
                sortDic.Add(item.Key, item.Value);
            }
            needSignHeaders = sortDic;
#endif
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
#if !NET30 && !NET20
            needSignHeaders = needSignHeaders.OrderBy(p => p.Key).ToDictionary(k => k.Key, v => v.Value);
            string[] signHeaderKey = needSignHeaders.Keys.ToArray();
#else
            string[] signHeaderKey = new string[needSignHeaders.Count];
            int i = 0;
            foreach (var item in needSignHeaders) {
                signHeaderKey[i] =  item.Key;
                i += 1;
            }
            Array.Sort(signHeaderKey);
           
             
#endif

            string signHeader = string.Join(";", signHeaderKey); 
            return signHeader; 
        }

        /// <summary>
        /// process request header key to lower
        /// </summary>
        /// <param name="header"></param>
        /// <returns></returns>
        public static Dictionary<string, List<string>> ProcessRequestHeaderKeyToLower(Dictionary<string, List<string>> header) {
            if (header == null)
            {
                return null;
            }
            else if(header.Count == 0){
                return header;
            } 
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            foreach (var item in header) {
                if (result.ContainsKey(item.Key.ToLower()))
                {
                    if (result[item.Key.ToLower()] != item.Value) {
                         result[item.Key.ToLower()].AddRange(item.Value);
                    }
                }
                else {
                    result.Add(item.Key.ToLower(), item.Value);
                } 
            } 
            return result;
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
#if !NET20 && !NET30
                            string value = string.Join(",", item.Value.Select(p => p.Trim()).ToArray());
#else 
                            string[] tmpList = new string[item.Value.Count];
                            int i = 0;
                            foreach (var tempItem in item.Value) {
                                tmpList[i] = tempItem.Trim();
                                i += 1;
                            }
                            string value = string.Join(",", tmpList);
#endif
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
#if !NET20 && !NET30
                        if (!NOT_SIGN_REQUEST_HEAD.Contains(key)&&
                            !NOT_SIGN_REQUEST_HEAD_START.Any(p=>key.Trim().StartsWith(p))) {
                            result.Add(key, item.Value.Trim());
                        }
#else
                        var headContains = false;
                        var headStartWith = false;
                        foreach (var headerKey in NOT_SIGN_REQUEST_HEAD) {
                            if (headerKey.ToLower() == key) {
                                headContains = true;
                            }
                        }
                        foreach (var headerStartKey in NOT_SIGN_REQUEST_HEAD_START) {
                            if (key.TrimStart().ToLower().StartsWith(headerStartKey.ToLower())) {
                                headStartWith = true;
                            }
                        }
                        if (!headContains && !headStartWith){
                            result.Add(key, item.Value.Trim());
                        }
#endif
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
                                // queryString = queryString.Replace("+", " ");
                                string keyValue = paramKV[0].Replace("+", " ");
                                keyValue = JDCloudSignV3Util.UnescapeDataStringRfc3986(keyValue);
                                QueryParam queryParam = new QueryParam {Key = JDCloudSignV3Util.EscapeUriDataStringRfc3986(keyValue),Value=string.Empty };
                                queryParamList.Add(queryParam);
                            }
                            else if (paramKV.Length == 2 && !paramKV[0].IsNullOrWhiteSpace()) {
                                string keyValue = paramKV[0].Replace("+", " ");
                                keyValue = JDCloudSignV3Util.UnescapeDataStringRfc3986(keyValue);
                                string value =  paramKV[1].Replace("+", " ");
                                value = JDCloudSignV3Util.UnescapeDataStringRfc3986(value);
                                QueryParam queryParam = new QueryParam { Key = JDCloudSignV3Util.EscapeUriDataStringRfc3986(keyValue),
                                    Value = JDCloudSignV3Util.EscapeUriDataStringRfc3986(value) };
                                queryParamList.Add(queryParam);
                            }
                            else {
                                if (paramKV[0]!=null&&paramKV[0]!=string.Empty) {

                                    string key = JDCloudSignV3Util.UnescapeDataStringRfc3986(paramKV[0]);
#if !NET20 && !NET30
                                    string queryParamValue = string.Join("=", paramKV.Skip(1).Take(paramKV.Length - 1).ToArray());
#else
                                    string[] queryParamVlueArray = new string[paramKV.Length - 1];
                                    for (int i = 1; i < paramKV.Length; i++) {
                                        queryParamVlueArray[i - 1] = paramKV[i];
                                    }
                                    string queryParamValue = string.Join("=", queryParamVlueArray);
#endif
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
#if !NET20 && !NET30
                queryParamList = queryParamList.OrderBy(p => p.Key).ThenBy(p => p.Value).ToList();
#else
                queryParamList.Sort();
#endif
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
            var decodePath = JDCloudSignV3Util.UnescapeDataStringRfc3986(path);
            var pathArray = decodePath.Split('/');
            //var pathDecodeArray = pathArray.Select(p => JDCloudSignV3Util.UnescapeDataStringRfc3986(p)).ToList();
#if !NET30 && !NET20
            var pathList = pathArray.Select(p => JDCloudSignV3Util.EscapeUriDataStringRfc3986(p)).ToList();
            pathList.RemoveAll(p => p.Equals(string.Empty));
            path = string.Join("/", pathList.ToArray());
#else
            var pathList = new List<string>();
            foreach (var item in pathArray) {
                if (item != null && item != string.Empty) {
                    pathList.Add(JDCloudSignV3Util.EscapeUriDataStringRfc3986(item));
                }
            }
            if (pathList.Count > 0) {
                string[] pathArrays = new string[pathList.Count];
                int i = 0;
                foreach (var item in pathList) {
                    pathArrays[i] = item;
                    i += 1;
                }
                path = string.Join("/", pathArrays);
            }

#endif

            if (!path.StartsWith("/"))
            {
                path = $"/{path}";
            }
            if (requestPath.TrimEnd().EndsWith("/")|| requestPath.TrimEnd().EndsWith("%2F")) {
                path = $"{path}/";
            }
            return path;
        }
    }

    /// <summary>
    /// model use save query param
    /// </summary>
    internal class QueryParam : IComparer<QueryParam>
    { 
        /// <summary>
        /// query string key
        /// </summary>
        public string Key { get; set; }


        /// <summary>
        /// query string value
        /// </summary>
        public string Value { get; set; }

       

        public int Compare(QueryParam x, QueryParam y)
        {
            if (x.Key != y.Key)
            {
                return x.Key.CompareTo(y.Key);
            }
            else {
                return x.Value.CompareTo(y.Value);
            }
             
        }
    }
}
