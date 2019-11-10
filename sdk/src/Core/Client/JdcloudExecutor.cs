using JDCloudSDK.Core.Annotation;
using JDCloudSDK.Core.Common;
using JDCloudSDK.Core.Service;
using JDCloudSDK.Core.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using JDCloudSDK.Core.Extensions;
using System.IO;

#if NET35 || NET40
using System.Net;
#else
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
#endif

namespace JDCloudSDK.Core.Client
{
    /// <summary>
    /// 执行接口抽象类
    /// </summary>
    public abstract class JdcloudExecutor
    {


        /// <summary>
        /// JdcloudClient 对象信息
        /// </summary>
        protected JdcloudClient JdcloudClient;

        /// <summary>
        /// http 请求的方法
        /// </summary>
        public virtual string Method { get; }


        /// <summary>
        /// 请求url
        /// </summary>
        public virtual string Url { get; }


        /// <summary>
        /// 设置请求的 JdcloudClient 对象
        /// </summary>
        /// <param name="client">请求的 JdcloudClient </param>
        /// <returns>JdcloudExecutor 对象信息</returns>
        public JdcloudExecutor Client(JdcloudClient client)
        {
            this.JdcloudClient = client;
            return this;
        }

        /// <summary>
        ///  执行api 请求方法
        ///  在.NET 4.5 以上版本使用Httpclient 进行调用
        ///  在.Net 4 版本 使用HttpWebRequest 进行调用
        /// </summary>
        /// <typeparam name="R">继承 JdcloudResponse 的类 包含错误的结果信息 </typeparam>
        /// <typeparam name="R2"> 继承JdcloudResult  请求的结果信息</typeparam>
        /// <typeparam name="T">请求参数对象 继承JdcloudRequest</typeparam>
        /// <param name="request">请求参数</param>
        /// <returns>
        ///  如果Http 请求状态为ok(200) 返回 成功请求后得到的结果 如果返回 200 内容为null返回null
        ///  如果Http 请求返回状态不为（OK）200 则返回错误信息，Error内的code 返回 Http 请求的错误码，message 返回服务器返回的异常
        /// </returns>
#if NET40 || NET35
        public R Execute<R, R2, T>(T request) where T : JdcloudRequest where R2 : JdcloudResult where R : JdcloudResponse<R2>, new()
#else
        public async Task<R> Execute<R, R2, T>(T request) where T : JdcloudRequest where R2 : JdcloudResult where R : JdcloudResponse<R2>, new()
#endif
        {
            string version = request.Version;
            version = CheckImportantParams(version);
            CheckRequest(request);
            try
            {
                var clientProfile = JdcloudClient.ClientProfile;
                string uri = Url;
                uri = ReplaceUrl(uri, request);
                string protocol = JdcloudClient.ClientProfile.HttpProfile.Protocol.ToString();
                string endPoint = JdcloudClient.SDKEnvironment.Endpoint;
                string realEndPoint = JdcloudClient.SDKEnvironment.RealEndPoints;
                int timeout = clientProfile.HttpProfile.Timeout;
                StringBuilder host = new StringBuilder()
                  .Append(protocol)
                  .Append("://")
                  .Append(endPoint);
                StringBuilder signingHost = new StringBuilder()
               .Append(protocol)
               .Append("://")
               .Append(realEndPoint.IsNullOrWhiteSpace() ? endPoint : realEndPoint);
                StringBuilder path = new StringBuilder()
                .Append("/")
                .Append(version)
                .Append(uri);

                //生成请求参数
                string paramsStr = GetParams(request);

                //生成请求body
                byte[] bodyContent = null;
                string contentStr = GetContent(request);


                if (!contentStr.IsNullOrWhiteSpace())

                {
                    bodyContent = Encoding.UTF8.GetBytes(contentStr);
                }
                string url = host.ToString() + path.ToString() + paramsStr;
#if NET35 || NET40
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);

                if (JdcloudClient.CustomHeader != null && JdcloudClient.CustomHeader.Count > 0)
                {
                    foreach (var item in JdcloudClient.CustomHeader)
                    {
                        if (item.Key.ToLower() == "content-type")
                        {
                            webRequest.ContentType = item.Value;
                        }

                        else if (item.Key.ToLower() == "host")
                        {
#if NET40
                            webRequest.Host = item.Value; 
#elif NET35
                            //因为 dotnet3.5 默认不支持设置header 的host 属性，在使用签名的时候需要添加host 属性的信息，因此使用反射设置对象的值 ，会有性能损失。
                            FieldInfo headersFieldInfo = webRequest.GetType().GetField("_HttpRequestHeaders", System.Reflection.BindingFlags.NonPublic
                                        | System.Reflection.BindingFlags.Instance
                                        | System.Reflection.BindingFlags.GetField);
                            var requestHeaders = webRequest.Headers;
                            CusteredHeaderCollection wssHeaders = new CusteredHeaderCollection(item.Value);

                            foreach (var headersKey in requestHeaders.AllKeys)
                            {
                                var value = requestHeaders[headersKey];
                                wssHeaders.Add(headersKey, value);
                            }
                            headersFieldInfo.SetValue(webRequest, wssHeaders);
                            //webRequest.Proxy = null;
#endif
                        }
                        else if (item.Key.ToLower() == "user-agent")
                        {
                            webRequest.UserAgent = item.Value;
                        }
                        else
                        {
                            webRequest.Headers.Add(item.Key, item.Value);
                        }

                    }
                }
                webRequest.Method = Method;
                webRequest.Timeout = 15 * 1000;
                webRequest.DoSign(JdcloudClient.Credential, JdcloudClient.ServiceName, bodyContent, false);
                try
                {
                    using (HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse())
                    {
                        HttpSDKResponse httpSDKResponse = new HttpSDKResponse();
                        if (httpWebResponse != null)
                        {
                            httpSDKResponse.StatusCode = (int)httpWebResponse.StatusCode;
                            if (httpWebResponse.Headers != null && httpWebResponse.Headers.Count > 0)
                            {

                                for (int i = 0; i < httpWebResponse.Headers.Keys.Count; i++)
                                {
                                    var key = httpWebResponse.Headers.Keys[i];
                                    string[] values = httpWebResponse.Headers.GetValues(key);
                                    if (values != null && values.Length > 0)
                                    {
                                        httpSDKResponse.AddHeader(key, values.ToList());
                                    }

                                }
                            }
                            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                            {
                                string responseContent = streamReader.ReadToEnd();
                                httpSDKResponse.ResponseContent = Encoding.UTF8.GetBytes(responseContent);

                                //return new Tuple<HttpStatusCode, string>(httpWebResponse.StatusCode, responseContent);
                                var jDCloudSdkResult = new JDCloudSdkResult { StatusCode = httpWebResponse.StatusCode, ReturnValue = responseContent, HttpSDKResponse = httpSDKResponse };
                                return ProcessJDcloudRequestResult<R, R2>(jDCloudSdkResult);
                            }
                        }
                    }
                }
                catch (WebException webException)
                {
                    using (HttpWebResponse exceptionResponce = (HttpWebResponse)webException.Response)
                    {
                        if (exceptionResponce != null)
                        {
                            HttpSDKResponse httpSDKResponse = new HttpSDKResponse();
                            using (StreamReader streamReader = new StreamReader(exceptionResponce.GetResponseStream()))
                            {
                                httpSDKResponse.StatusCode = (int)exceptionResponce.StatusCode;
                                if (exceptionResponce.Headers != null && exceptionResponce.Headers.Count > 0)
                                {

                                    for (int i = 0; i < exceptionResponce.Headers.Keys.Count; i++)
                                    {
                                        var key = exceptionResponce.Headers.Keys[i];
                                        string[] values = exceptionResponce.Headers.GetValues(key);
                                        if (values != null && values.Length > 0)
                                        {
                                            httpSDKResponse.AddHeader(key, values.ToList());
                                        }

                                    }
                                }
                                string responseContent = streamReader.ReadToEnd();
                                httpSDKResponse.ResponseContent = Encoding.UTF8.GetBytes(responseContent);
                                var jDCloudSdkResult = new JDCloudSdkResult { StatusCode = exceptionResponce.StatusCode, ReturnValue = responseContent };
                                return ProcessJDcloudRequestResult<R, R2>(jDCloudSdkResult);
                            }
                        }
                    }
                }

                webRequest.Abort();
                return null;
#else

                // 生成请求header
                var httpClient = JdcloudClient.RequestHttpClient;
                if (httpClient == null)
                {
                    httpClient = new System.Net.Http.HttpClient();
                }
                HttpMethod httpMethod = GetHttpMethod(Method);
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage(httpMethod, url);
                if (JdcloudClient.CustomHeader.Count > 0)
                {
                    foreach (var item in JdcloudClient.CustomHeader)
                    {
                        if (item.Key.ToLower() != "content-type")
                        {
                            httpRequestMessage.Headers.TryAddWithoutValidation(item.Key, item.Value);
                        }
                    }
                }
                if (!contentStr.IsNullOrWhiteSpace() && contentStr.Length > 0)
                {
                    if (httpMethod != HttpMethod.Get && httpMethod != HttpMethod.Head && httpMethod != HttpMethod.Delete)
                    {
                        using (HttpContent content = new ByteArrayContent(bodyContent == null ? new byte[0] : bodyContent))
                        {
                            var contentTypeHeader = JdcloudClient.CustomHeader.Where(p => p.Key.ToLower() == "content-type").FirstOrDefault();

                            if (!default(KeyValuePair<string, string>).Equals(contentTypeHeader))
                            {
                                content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeHeader.Value);
                            }
                            else
                            {
                                content.Headers.ContentType = new MediaTypeHeaderValue(ParameterConstant.MIME_JSON);
                            }
                            httpRequestMessage.Content = content;
                        }
                    }
                }
                var signRequestMessage = httpRequestMessage.DoRequestMessageSign(JdcloudClient.Credential, JdcloudClient.ServiceName, null);
                HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(signRequestMessage).ConfigureAwait(false);
                JDCloudSdkResult jDCloudSdkResult = await ProcessHttpResponseMessage(httpResponseMessage).ConfigureAwait(false);
                return ProcessJDcloudRequestResult<R, R2>(jDCloudSdkResult);
#endif
            }
            catch (Exception ex)
            {
                throw new Exception("call sign and Http send request Error", ex);
            }
        }


        private R ProcessJDcloudRequestResult<R, R2>(JDCloudSdkResult result) where R2 : JdcloudResult where R : JdcloudResponse<R2>, new()
        {
            if (result != null)
            {
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (result.ReturnValue != null)
                    {
                        string resultStr = result.ReturnValue;

                        if (!resultStr.IsNullOrWhiteSpace())

                        {
                            var response = JsonConvert.DeserializeObject<R>(resultStr);
                            response.HttpResponse = result.HttpSDKResponse;
                            return response;
                        }
                    }
                    return null;

                }
                else
                {

                    if (result.ReturnValue != null && result.ReturnValue.Count() > 0)
                    {
                        string resultStr = result.ReturnValue;

                        if (!resultStr.IsNullOrWhiteSpace())

                        {
                            var response = JsonConvert.DeserializeObject<R>(resultStr);
                            response.HttpResponse = result.HttpSDKResponse;
                            return response;
                        }
                    }
                    return new R() { Error = new ServiceError() { Code = (int)result.StatusCode, Message = $"the gateway return {result.StatusCode.ToString() }" } };
                }

            }
            return null;
        }


#if NET35 || NET40
#else



        private async Task<JDCloudSdkResult> ProcessHttpResponseMessage(HttpResponseMessage message)
        {
            string result = null;
            try
            {
                HttpSDKResponse httpSDKResponse = new HttpSDKResponse();
                if (message != null)
                {
                    using (message)
                    {
                        httpSDKResponse.StatusCode = (int)message.StatusCode;
                        if (message.Content != null)
                        {
                            if (message != null && message.Headers.Count() > 0)
                            {
                                foreach (var item in message.Headers)
                                {
                                    if (item.Value.Count() > 0)
                                    {
                                        httpSDKResponse.AddHeader(item.Key, item.Value.ToList());
                                    }

                                }
                            }
                            using (Stream responseStream = await message.Content.ReadAsStreamAsync())
                            {
                                if (responseStream != null)
                                {
                                    byte[] responseData = new byte[responseStream.Length];
                                    responseStream.Read(responseData, 0, responseData.Length);
                                    if (responseData != null && responseData.Length > 0)
                                    {
                                        httpSDKResponse.ResponseContent = responseData;
                                        result = Encoding.UTF8.GetString(responseData);
                                    }
                                }
                            }
                        }
                    }
                }
                return new JDCloudSdkResult { StatusCode = message.StatusCode, ReturnValue = result, HttpSDKResponse = httpSDKResponse };
            }
            catch (Exception ex)
            {
                throw new Exception(" Execute the http request error.", ex);
            }
        }
        private static HttpMethod GetHttpMethod(string httpMethod)
        {
            switch (httpMethod.Trim().ToUpper())
            {
                case "GET":
                    return HttpMethod.Get;
                case "POST":
                    return HttpMethod.Post;
                case "PUT":
                    return HttpMethod.Put;
                case "DELETE":
                    return HttpMethod.Delete;
                case "HEAD":
                    return HttpMethod.Head;
                case "TRACE":
                    return HttpMethod.Trace;
                case "OPTIONS":
                    return HttpMethod.Options;
                default:
                    return HttpMethod.Get;
            }
        }
#endif
        /// <summary>
        /// 请求url 参数格式化替换
        /// </summary>
        /// <param name="httpUrl">要替换的url</param>
        /// <param name="request">请求的参数信息</param>
        /// <returns>替换后的url 信息</returns>
        public string ReplaceUrl(string httpUrl, JdcloudRequest request)
        {

            if (httpUrl.IsNullOrWhiteSpace())

            {
                return string.Empty;
            }
            if (httpUrl.IndexOf("{") < 0)
            {
                return httpUrl;
            }
            var matchs = Regex.Matches(httpUrl, ParameterConstant.PATTERN);
            if (matchs != null && matchs.Count > 0)
            {
                int i = 1;
                foreach (Match item in matchs)
                {
                    i++;

                    string fieldName = item.Groups[1].Value;
                    string value = GetRequestValue(fieldName, request);
                    string pathValue = Uri.EscapeUriString(value);
                    httpUrl = httpUrl.Replace(item.Value, pathValue);
                }
            }
            return httpUrl;
        }

        /// <summary>
        /// 检查参数是否填写完整
        /// 此方法与java 定义的不同 java 为feild .net 使用property
        /// </summary>
        /// <param name="request">请求的参数信息</param>
        public void CheckRequest(Object request)
        {
            try
            {
                var properties = request.GetType().GetProperties();
                foreach (var item in properties)
                {
#if NET40 || NET35

                    var requiredAttribute = item.GetCustomAttributes(typeof(RequiredAttribute), false);
                    if (requiredAttribute != null && requiredAttribute.Length > 0)
                    {
                        var value = item.GetValue(request, null);
                        if (value == null)
                        {
                            throw new ArgumentNullException($"field {item.Name} can not be null,please set value for it.");
                        }
                    }
#else
                    var required = item.GetCustomAttribute<RequiredAttribute>();
                    if (required != null)
                    {
                        var value = item.GetValue(request);
                        if (value == null)
                        {
                            throw new ArgumentNullException($"field {item.Name} can not be null,please set value for it.");
                        }
                    }

#endif
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// 检查版本号等重要参数信息
        /// </summary>
        /// <param name="v">版本号</param>
        /// <returns>版本号信息</returns>
        protected string CheckImportantParams(string v)
        {
            if (JdcloudClient == null)
            {
                throw new ArgumentNullException("JdcloudClient not set.");
            }

            if (v.IsNullOrWhiteSpace())
            {
                v = JdcloudClient.Version;
            }

            if (v.IsNullOrWhiteSpace())
            {
                throw new ArgumentNullException("Version not set.");
            }

            if (JdcloudClient.SDKEnvironment.Endpoint.IsNullOrWhiteSpace())

            {
                throw new ArgumentNullException("endpoint not set.");
            }

            if (JdcloudClient.ServiceName.IsNullOrWhiteSpace())

            {
                throw new ArgumentNullException("serviceName not set.");
            }

            return v;
        }

        /// <summary>
        /// 获取参数对应的值信息
        /// </summary>
        /// <param name="propertyName">参数名称</param>
        /// <param name="request">请求参数封装类</param>
        /// <returns>请求参数的值</returns>
        private string GetRequestValue(string propertyName, JdcloudRequest request)
        {

            PropertyInfo propertyInfo = null;
            var properties = request.GetType().GetProperties();
            if (properties != null && properties.Length > 0)
            {
                propertyInfo = properties.Where(p => p.Name.ToLower() == propertyName.ToLower()).FirstOrDefault();
            }

            if (propertyInfo == null)
            {
                throw new Exception($"can not get the propertyInfo of {propertyName},please check.");
            }
            object value = CommonUtils.GetPropertyInfoValue(propertyInfo, request);

            if (value == null)
            {
                throw new Exception($"field {propertyName} not set.");
            }

            return value.ToString();
        }

        /// <summary>
        /// 获取请求的Http body 的内容
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求body 内容</returns>
        private string GetContent(JdcloudRequest request)
        {
            if (request == null)
            {
                return string.Empty;
            }

            string method = Method;
            if ("DELETE".ToLower() == method.ToLower()
             || "GET".ToLower() == method.ToLower()
             || "HEAD".ToLower() == method.ToLower())
            {
                return null;
            }
            string contentStr = JsonUtil.ObjectToJson(request);
            if (!contentStr.IsNullOrWhiteSpace())

            {
                contentStr = contentStr.Replace(Environment.NewLine, "");
            }
            return contentStr;
        }

        /// <summary>
        /// 获取 url 连接串参数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求 quary param string </returns>
        private string GetParams(JdcloudRequest request)
        {
            if (request == null)
            {
                return string.Empty;
            }

            string method = Method;
            if ("DELETE".ToLower() == method.ToLower()
                || "GET".ToLower() == method.ToLower()
                || "HEAD".ToLower() == method.ToLower())
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                //json 格式化，转换为小驼峰的形式
                jsonSerializer.ContractResolver = new CamelCasePropertyNamesContractResolver();
                JObject jObject = JObject.FromObject(request, jsonSerializer);
                Dictionary<string, string> paramDic = new Dictionary<string, string>();
                string paramsStr = "";
                paramDic = CreateParam(jObject);
                if (paramDic != null)
                {
                    var paramDicOrder = paramDic.OrderBy(p => p.Key);
                    StringBuilder paramStrBuilder = new StringBuilder();
                    foreach (var item in paramDicOrder)
                    {
                        string value = HttpClientUtil.UrlEncode(item.Value, false);
                        paramStrBuilder.Append("&").Append(item.Key).Append("=").Append(item.Value);
                    }
                    paramsStr = paramStrBuilder.ToString();
                }

                if (!paramsStr.IsNullOrWhiteSpace())

                {
                    return "?" + paramsStr.Substring(1);
                }
                else
                {
                    return string.Empty;
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// 创建get 等请求使用的query string
        /// </summary>
        /// <param name="jObject">Json 对象</param>
        /// <param name="superName">上一级的名称</param>
        /// <returns>query string</returns>
        private Dictionary<string, string> CreateParam(JToken jObject, string superName = "")
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (jObject.GetType() == typeof(JArray))
            {
                var arrayParamDic = ArrayParam(jObject, superName);
                if (arrayParamDic != null)
                {
                    foreach (var item in arrayParamDic)
                    {
                        dic.Add(item.Key, item.Value);
                    }
                }
            }
            else
            {
                var objectParamDic = ObjectParam(jObject, superName);
                if (objectParamDic != null)
                {
                    foreach (var item in objectParamDic)
                    {
                        dic.Add(item.Key, item.Value);
                    }
                }
            }
            return dic;
        }


        /// <summary>
        /// 创建get 等请求使用的query string ， 解析数组对象
        /// </summary>
        /// <param name="jObject">Json 对象</param>
        /// <param name="superName">上一级的名称</param>
        /// <returns>query string</returns>
        private Dictionary<string, string> ArrayParam(JToken jObject, string superName = "")
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (jObject.GetType() != typeof(JArray))
            {
                return null;
            }
            var jArrayObject = (JArray)jObject;
            for (int i = 0; i < jArrayObject.Count; i++)
            {
                if (jArrayObject != null && jArrayObject.Count > 0)
                {
                    if (jArrayObject[i].GetType() == typeof(JValue))
                    {
                        StringBuilder stringBuilder = new StringBuilder();

                        stringBuilder.Append(superName);
                        stringBuilder.Append(".");
                        stringBuilder.Append(i + 1);
                        string encodeStr = Regex.Replace(jArrayObject[i].ToString(), "^\"|\"$", "");
                        string value = HttpClientUtil.UrlEncode(encodeStr, false);
                        dic.Add(stringBuilder.ToString(), value);
                    }
                    else
                    {
                        var createParamDic = CreateParam(jArrayObject[i], superName + "." + (i + 1));
                        if (createParamDic != null)
                        {
                            foreach (var item in createParamDic)
                            {
                                dic.Add(item.Key, item.Value);
                            }
                        }
                    }
                }
            }
            return dic;
        }


        /// <summary>
        /// 创建get 等请求使用的query string，解析Object 对象
        /// </summary>
        /// <param name="jToken">json 对象</param> 
        /// <param name="superName">父类名称</param>
        private Dictionary<string, string> ObjectParam(JToken jToken, string superName = "")
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var jObject = (JObject)jToken;
            foreach (var item in jObject)
            {
                string name = item.Key;
                if (Url.IndexOf("{" + name + "}") > -1)
                {
                    continue;
                }
                var valueJObject = item.Value;
                string pname = CreateParamKey(superName, name);
                if (valueJObject.GetType() == typeof(JValue))
                {
                    if (valueJObject != null && !valueJObject.ToString().IsNullOrWhiteSpace())
                    {

                        string encodeStr = Regex.Replace(valueJObject.ToString(), "^\"|\"$", "");
                        string value = HttpClientUtil.UrlEncode(encodeStr, false);
                        dic.Add(pname, value);
                    }
                }
                else
                {
                    var createParamDic = CreateParam(valueJObject, pname);
                    if (createParamDic != null)
                    {
                        foreach (var paramDic in createParamDic)
                        {
                            dic.Add(paramDic.Key, paramDic.Value);
                        }
                    }
                }

            }
            return dic;
        }

        /// <summary>
        /// 生成query param 的 key值
        /// </summary>
        /// <param name="superName">父类名称</param>
        /// <param name="name">当前字段名称</param>
        /// <returns>query param 的 key值</returns>
        private string CreateParamKey(string superName, string name)
        {
            if (superName.IsNullOrWhiteSpace())
            {
                return name;
            }
            return $"{superName}.{name}";
        }
    }

}

