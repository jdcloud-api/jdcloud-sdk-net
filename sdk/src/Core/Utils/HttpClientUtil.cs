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
        public string ReturnValue { get; set; }


        /// <summary>
        /// response Data
        /// </summary>
        public HttpSDKResponse HttpSDKResponse { get; set; }

    }

    /// <summary>
    /// response Data
    /// </summary>
    public class HttpSDKResponse
    {
        /// <summary>
        /// the http response headers
        /// </summary>
        public Dictionary<string, List<string>> Header { get; set; } = new Dictionary<string, List<string>>();

        /// <summary>
        /// the http response content
        /// </summary>
        public byte[] ResponseContent { get; set; }


        /// <summary>
        /// the response status code
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// add the response head to instance
        /// </summary>
        /// <param name="key">the header key</param>
        /// <param name="value">the header value</param>
        public void AddHeader(string key, List<string> value)
        {
            if (Header == null)
            {
                Header = new Dictionary<string, List<string>>();
            }
            Header.Add(key, value);
        }


    }
}
