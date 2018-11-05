using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace JDCloudSDK.Core.Common.Profile
{
    /// <summary>
    /// web 请求代理服务
    /// </summary>
    public class WebProxy : IWebProxy
    {

        private readonly Uri Uri;
        private readonly bool ByPass;

        /// <summary>
        /// 直接配置代理地址的使用方式
        /// </summary>
        /// <param name="proxyUri"></param>
        public WebProxy(string proxyUri): this(new Uri(proxyUri))
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="uri">代理地址</param>
        /// <param name="credentials">认证信息</param>
        /// <param name="bypass">是否需要认证</param>
        public WebProxy(Uri uri, ICredentials credentials = null, bool bypass = false)
        {
            Uri = uri;
            ByPass = bypass;
            Credentials = credentials;
        }

        /// <summary>
        /// 证书认证信息
        /// </summary>
        public ICredentials Credentials { get ; set ; }

        /// <summary>
        /// 获取代理地址信息
        /// </summary>
        /// <param name="destination"></param>
        /// <returns></returns>
        public Uri GetProxy(Uri destination)
        {
            return Uri;
        }

        /// <summary>
        /// 获取是否需要认证信息
        /// </summary>
        /// <param name="host">请求url</param>
        /// <returns></returns>
        public bool IsBypassed(Uri host)
        {
            return ByPass;
        }
    }
}
