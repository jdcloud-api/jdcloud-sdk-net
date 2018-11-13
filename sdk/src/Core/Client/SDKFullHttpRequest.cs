using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace JDCloudSDK.Core.Client
{
    /// <summary>
    /// 构造最后请求的详细信息
    /// </summary>
    public class SDKFullHttpRequest
    {
        /// <summary>
        /// 请求头信息
        /// </summary>
        public Dictionary<String, List<String>> Header { get; set; } = new Dictionary<string, List<string>>();

        /// <summary>
        /// 资源路径
        /// </summary>
        public string ResourcePath { get; set; }


        /// <summary>
        /// url 参数
        /// </summary>
        public string QueryParameters { get; set; }

        /// <summary>
        /// 请求方法名
        /// </summary>
        public HttpMethod HttpMethod { get; set; }

        /// <summary>
        /// request body
        /// </summary>
        public string Content { get; set; }


        /// <summary>
        /// 添加请求头
        /// </summary>
        /// <param name="key">请求头的key</param>
        /// <param name="value">请求头的value</param>
        /// <returns></returns>
        public Dictionary<string, List<string>> AddHeader(string key, string value)
        {
            if (Header == null)
            {
                Header = new Dictionary<string, List<string>>();
            }

            List<string> headerValues = Header[key];
            if (headerValues == null)
            {
                headerValues = new List<string>();
                headerValues.Add(value);
                Header.Add(key, headerValues);
            }
            else {
                headerValues.Add(value);
                Header[key] = headerValues;
            }
            return Header;
        }
    }
}
