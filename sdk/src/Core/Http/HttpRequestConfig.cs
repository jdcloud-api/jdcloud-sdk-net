using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Http
{

    /// <summary>
    /// http 请求配置信息
    /// </summary>
    public class HttpRequestConfig
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public HttpRequestConfig() {

        }

        /// <summary>
        /// 设置请求超时时间
        /// </summary>
        /// <param name="requestTimeout">超时时间</param>
        public HttpRequestConfig(int requestTimeout)
        {
            RequestTimeout = requestTimeout;
        }

        /// <summary>
        /// 构造函数，默认执行5秒超时
        /// </summary>
        /// <param name="protocol">http 请求协议</param>
        /// <param name="requestTimeout">请求超时时间</param>
        public HttpRequestConfig(Protocol protocol, int requestTimeout=5)
        {
            this.Protocol = protocol;
            this.RequestTimeout = requestTimeout;
        }

        /// <summary>
        /// 请求超时时间
        /// </summary>
        public int RequestTimeout { get; set; } = 5;

        /// <summary>
        /// 请求协议 http or https
        /// </summary>
        public Protocol Protocol { get; set; } = Protocol.HTTPS;

    }
}
