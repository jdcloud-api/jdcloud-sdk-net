using JDCloudSDK.Core.Auth;
using System;
using System.Collections.Generic;

#if NET35 || NET40
using System.Net;
#else
using System.Net.Http;
#endif
using System.Text;

namespace JDCloudSDK.Core.Extensions
{
    /// <summary>
    /// http 请求客户端签名扩展类
    /// </summary>
    public static class HttpExtensions
    {

#if NET35 || NET40

        /// <summary>
        /// 扩展签名方法
        /// </summary>
        /// <param name="httpWebRequest">当前请求客户端</param>
        /// <param name="credentials">认证参数信息</param>
        /// <returns></returns>
        public static HttpWebRequest DoSign(this HttpWebRequest httpWebRequest, Credentials credentials) {
            return httpWebRequest;
        }

#else
        /// <summary>
        /// 扩展签名方法
        /// </summary>
        /// <param name="httpClient">当前请求客户端</param>
        /// <param name="credentials">认证参数信息</param>
        /// <returns></returns>
        public static HttpClient DoSign(this HttpClient httpClient, Credentials credentials)
        {
            HttpClientWrapper httpClientWrapper = new HttpClientWrapper(httpClient, credentials); 
            return httpClientWrapper;
        }
#endif

    }
}
