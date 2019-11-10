using System;
using System.Collections.Generic;  

namespace JDCloudSDK.Core.Model
{
    /// <summary>
    /// 构造最后请求的详细信息
    /// </summary>
    public class RequestModel
    {
        /// <summary>
        /// 请求头信息
        /// </summary>
        public Dictionary<string, List<string>> Header { get; set; } = new Dictionary<string, List<string>>();

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
        public string HttpMethod { get; set; }

        /// <summary>
        /// request body
        /// </summary>
        public byte[] Content { get; set; }


        /// <summary>
        /// 请求body 类型
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// 重写 请求日期
        /// </summary>
        public DateTime? OverrddenDate { get; set; }

        /// <summary>
        /// 请求url
        /// </summary>
        public Uri Uri { get; set; }

        /// <summary>
        /// 签名方法
        /// </summary>
        public JDCloudSignVersionType SignType { get; set; }


        /// <summary>
        /// 请求服务名称
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 请求区域名称
        /// </summary>
        public string RegionName { get; set; }


        /// <summary>
        /// the sgin api version info
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// the request port
        /// </summary>
        public int? RequestPort { get; set; }

        /// <summary>
        /// the request nonce id
        /// </summary>
        public string NonceId { get; set; } 



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
            List<string> headerValues = null;
            if (Header.ContainsKey(key)) {
                headerValues = Header[key];
            } 
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
