using System;
using System.Collections.Generic;
#if NET40||NET35
#else
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
#endif
using System.Text;
using System.Linq;
using System.IO;
using System.Net;
using System.Reflection;
using System.Collections.Specialized;

namespace JDCloudSDK.Core.Utils
{

    /// <summary>
    /// Http client 工具
    /// </summary>
    public class HttpClientUtil
    {
#if NET40 || NET35

        /// <summary>
        /// Http 请求客户端
        /// </summary>
        /// <param name="url"> 请求的url</param>
        /// <param name="bodyContent">请求的包体内容</param>
        /// <param name="headers">请求的头信息</param>
        /// <param name="httpMethod">请求的方法</param>
        /// <param name="timeoutSeconds">请求的超时时间 单位：秒 默认 10s</param>
        /// <returns>返回请求结果 Tuple 对象 
        ///             item1 HttpStatusCode ，
        ///             item2 http 请求的结果
        /// </returns>
        public static JDCloudSdkResult ExecuteHttpRequest(string url, byte[] bodyContent, Dictionary<string, string> headers, string httpMethod, int timeoutSeconds = 10)
        {

            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);

                if (headers != null && headers.Count > 0)
                {
                    foreach (var item in headers)
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
                            var  requestHeaders =  webRequest.Headers;
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
                webRequest.Method = httpMethod;
                webRequest.Timeout = timeoutSeconds * 1000;

                if (bodyContent != null && bodyContent.Length > 0)
                {
                    webRequest.ContentLength = bodyContent.Length;
                    webRequest.GetRequestStream().Write(bodyContent, 0, bodyContent.Length);
                }
                try
                {
                    using (HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse())
                    {
                        if (httpWebResponse != null)
                        {
                            HttpSDKResponse httpSDKResponse = new HttpSDKResponse();
                            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
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
                                string responseContent = streamReader.ReadToEnd();
                                httpSDKResponse.ResponseContent = Encoding.UTF8.GetBytes(responseContent);
                                //return new Tuple<HttpStatusCode, string>(httpWebResponse.StatusCode, responseContent);
                                return new JDCloudSdkResult { StatusCode = httpWebResponse.StatusCode, ReturnValue = responseContent ,HttpSDKResponse = httpSDKResponse };
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
                                return new JDCloudSdkResult { StatusCode = exceptionResponce.StatusCode, ReturnValue = responseContent, HttpSDKResponse = httpSDKResponse };
                                //return new Tuple<HttpStatusCode, string>(exceptionResponce.StatusCode, responseContent);
                            }
                        }
                    }
                }

                webRequest.Abort();
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(" Execute the http request error.", ex);
            }
             
        }
#else

        /// <summary>
        /// Http 请求客户端
        /// </summary>
        /// <param name="httpClient"> 请求使用的http 客户端 </param>
        /// <param name="url"> 请求的url</param>
        /// <param name="bodyContent">请求的包体内容</param>
        /// <param name="headers">请求的头信息</param>
        /// <param name="httpMethod">请求的方法</param>
        /// <returns>
        ///             返回请求结果 Tuple 对象 
        ///             item1 HttpStatusCode ，
        ///             item2 http 请求的结果
        /// </returns>
        public async static Task<JDCloudSdkResult> ExecuteHttpRequest(HttpClient httpClient, string url, byte[] bodyContent, Dictionary<string, string> headers, string httpMethod)
        {
            string result = null;
            try
            {
                HttpResponseMessage message = null;
                //  httpClient.Timeout = TimeSpan.FromSeconds(timeoutSeconds); 

                HttpMethod methodInfo = GetHttpMethod(httpMethod);
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage(methodInfo, url))
                {
                    if (headers != null && headers.Count > 0)
                    {
                        foreach (var item in headers)
                        {
                            if (item.Key.ToLower() != "content-type")
                            {
                                httpRequestMessage.Headers.TryAddWithoutValidation(item.Key, item.Value);
                            }
                        }
                    }
                    if (methodInfo != HttpMethod.Get && methodInfo != HttpMethod.Head && methodInfo != HttpMethod.Delete)
                    {
                        using (HttpContent content = new ByteArrayContent(bodyContent == null ? new byte[0] : bodyContent))
                        {
                            var contentTypeHeader = headers.Where(p => p.Key.ToLower() == "content-type").FirstOrDefault();
                            if (!default(KeyValuePair<string, string>).Equals(contentTypeHeader))
                            {
                                content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeHeader.Value);
                            }
                            httpRequestMessage.Content = content;
                            message = await httpClient.SendAsync(httpRequestMessage);
                        }
                    }
                    else
                    {
                        message = await httpClient.SendAsync(httpRequestMessage);
                    }
                }
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
                return new JDCloudSdkResult { StatusCode = message.StatusCode, ReturnValue = result,HttpSDKResponse = httpSDKResponse };
            }
            catch (Exception ex)
            {
                throw new Exception(" Execute the http request error.", ex);
            }

        }

        /// <summary>
        /// 获取请求方法枚举值
        /// </summary>
        /// <param name="httpMothedStr">Http请求方法的字符串</param>
        /// <returns> System.Net.Http.HttpMethod </returns>
        public static HttpMethod GetHttpMethod(string httpMothedStr)
        {
            if (string.IsNullOrWhiteSpace(httpMothedStr))
            {
                throw new ArgumentNullException("http method must be set,it can not be null");
            }
            switch (httpMothedStr.ToUpper())
            {
                case "GET":
                    return HttpMethod.Get;
                case "POST":
                    return HttpMethod.Post;
                case "PUT":
                    return HttpMethod.Put;
                case "HEAD":
                    return HttpMethod.Head;
                case "PATCH":
                    return new HttpMethod("PATCH");
                case "OPTIONS":
                    return HttpMethod.Options;
                case "DELETE":
                    return HttpMethod.Delete;
                default:
                    return HttpMethod.Get;
            }
        }

#endif


    }

#if NET35
    /// <summary>
    /// 自定义头信息
    /// </summary>
    public class CusteredHeaderCollection : WebHeaderCollection
    {
        /// <summary>
        /// 替换的头信息
        /// </summary>
        public bool HostHeaderValueReplaced { get; private set; }

        /// <summary>
        /// 关联url
        /// </summary>
        public string ClusterUrl { get; private set; }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="commonClusterUrl">HOST 信息</param>
        public CusteredHeaderCollection(string commonClusterUrl) : base()
        {
            if (string.IsNullOrEmpty(commonClusterUrl))
                throw new ArgumentNullException("commonClusterUrl");

            this.ClusterUrl = commonClusterUrl;
        }

        /// <summary>
        /// 字符串信息
        /// </summary>
        /// <returns>返回tostring 方法字符串</returns>
        public override string ToString()
        {
            this["Host"] = this.ClusterUrl;
            string tmp = base.ToString();
            this.HostHeaderValueReplaced = true; 
            return tmp;
        }

    }
#endif

    /// <summary>
    /// sdk http 请求结果信息
    /// </summary>
    public class JDCloudSdkResult
    {
        /// <summary>
        /// 请求的http 状态码
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        public String ReturnValue { get; set; }


        public HttpSDKResponse HttpSDKResponse { get; set; }

    }


    public class HttpSDKResponse{

        public Dictionary<string, List<string>> Header { get; set; } = new Dictionary<string, List<string>>();

        public byte[] ResponseContent { get; set; }

        public int StatusCode { get; set; }

        public void AddHeader(string key ,List<string > value)
        {
            if (Header == null)
            {
                Header = new Dictionary<string, List<string>>();
            }
            Header.Add(key, value);
        }


    }
}
