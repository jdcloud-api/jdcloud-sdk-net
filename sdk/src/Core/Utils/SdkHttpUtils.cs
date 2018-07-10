using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace JDCloudSDK.Core.Utils
{

    /// <summary>
    /// SDK http 工具类
    /// </summary>
    public class SdkHttpUtils
    {
        /// <summary>
        /// 默认的编码格式UTF-8
        /// </summary>
       private static readonly Encoding DEFAULT_ENCODING = Encoding.UTF8;

      


        /// <summary>
        /// 进行特别方式的url 编码转换，使用的是url 私有的编码
        /// </summary>
        /// <param name="value">需要进行url 编码的值</param>
        /// <param name="path">是否为url请求路径</param>
        /// <returns>编码后的值</returns>
        public static string UrlEncode(string value, bool path)
        {
#if NET35
            if (string.IsNullOrEmpty(value)||string.IsNullOrEmpty(value.Trim()))
#else
            if(string.IsNullOrWhiteSpace(value))
#endif
            {
                return "";
            } 
            try
            {
                string encode = System.Web.HttpUtility.UrlEncode(value, DEFAULT_ENCODING);
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
                throw new Exception(" encode the url return exception",ex);
            }

          
        }

        /// <summary>
        /// 判断uri 是否使用的是默认协议的端口
        /// </summary>
        /// <param name="uri">请求的uri</param>
        /// <returns>是否使用的是默认的端口</returns>
        public static bool IsUsingNonDefaultPort(Uri uri)
        {
            String scheme =uri.Scheme.ToLower();
            int port = uri.Port;

            if (port <= 0)
            {
                return false;
            }
            if (scheme=="http" && port == 80)
            {
                return false;
            }
            if ("https"==scheme && port == 443)
            {
                return false;
            } 
            return true;
        }

        /// <summary>
        ///  Append the given path to the given baseUri.
        ///  By default, all slash characters in path will not be url-encoded.
        /// </summary>
        /// <param name="baseUri">base uri</param>
        /// <param name="path">resource path</param>
        /// <returns>Append the given path to the given baseUri. str</returns>
        public static string AppendUri(String baseUri, String path)
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
        public static string AppendUri( string baseUri, string path,  bool escapeDoubleSlash)
        {
            String resultUri = baseUri;
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
}
