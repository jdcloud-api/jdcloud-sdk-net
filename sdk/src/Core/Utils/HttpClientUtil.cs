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
using System.Text.RegularExpressions;
using JDCloudSDK.Core.Common;

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
                            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                            {
                                string responseContent = streamReader.ReadToEnd();
                                //return new Tuple<HttpStatusCode, string>(httpWebResponse.StatusCode, responseContent);
                                return new JDCloudSdkResult { StatusCode = httpWebResponse.StatusCode, ReturnValue = responseContent };
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
                            using (StreamReader streamReader = new StreamReader(exceptionResponce.GetResponseStream()))
                            {
                                string responseContent = streamReader.ReadToEnd();
                                return new JDCloudSdkResult { StatusCode = exceptionResponce.StatusCode, ReturnValue = responseContent };
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
   

#endif
        /// <summary>
        /// 进行特别方式的url 编码转换，使用的是url 私有的编码
        /// </summary>
        /// <param name="value">需要进行url 编码的值</param>
        /// <param name="path">是否为url请求路径</param>
        /// <returns>编码后的值</returns>
        public static string UrlEncode(string value, bool path)
        {
            if (value.IsNullOrWhiteSpace())

            {
                return "";
            }
            try
            {
                string encode = System.Web.HttpUtility.UrlEncode(value, ParameterConstant.DEFAULT_ENCODING);
                encode = encode.Replace("+", "%20").Replace("*", "%2A").Replace("%7E", "~").Replace("%7e", "~");
                if (path)
                {
                    encode = encode.Replace("%2F", "/").Replace("%2f", "/");
                }
                Regex reg = new Regex(@"%[a-f0-9]{2}");
                encode = reg.Replace(encode, m => m.Value.ToUpperInvariant());
                return encode;
            }
            catch (Exception ex)
            {
                throw new Exception(" encode the url return exception", ex);
            }


        }
        /// <summary>
        ///  Append the given path to the given baseUri.
        ///  By default, all slash characters in path will not be url-encoded.
        /// </summary>
        /// <param name="baseUri">base uri</param>
        /// <param name="path">resource path</param>
        /// <returns>Append the given path to the given baseUri. str</returns>
        public static string AppendUri(string baseUri, string path)
        {
            return AppendUri(baseUri, path, false);
        }

        /// <summary>
        /// Append the given path to the given baseUri.
        /// </summary>
        /// <param name="baseUri">The URI to append to (required, may be relative)</param>
        /// <param name="path"> The path to append (may be null or empty).  Path should be pre-encoded.</param>
        /// <param name="escapeDoubleSlash">Whether double-slash in the path should be escaped to "/%2F"</param>
        /// <returns>The baseUri with the path appended</returns>
        public static string AppendUri(string baseUri, string path, bool escapeDoubleSlash)
        {
            string resultUri = baseUri;
            if (path != null && path.Length > 0)
            {
                if (path.StartsWith("/"))
                {
                    // trim the trailing slash in baseUri, since the path already starts with a slash
                    if (resultUri.EndsWith("/"))
                    {
                        resultUri = resultUri.Substring(0, resultUri.Length - 1);
                    }
                }
                else if (!resultUri.EndsWith("/"))
                {
                    resultUri += "/";
                }
                if (escapeDoubleSlash)
                {
                    resultUri += path.Replace("//", "/%2F");
                }
                else
                {
                    resultUri += path;
                }
            }
            else if (!resultUri.EndsWith("/"))
            {
                resultUri += "/";
            }

            return resultUri;
        }

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

    }
}
