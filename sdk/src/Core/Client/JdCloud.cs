using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Client
{
    /// <summary>
    /// 全局配置类， 使用单例模式
    /// </summary>
    public class JdCloud
    {

        /// <summary>
        /// 认证信息
        /// </summary>
        private CredentialsProvider _credentialsProvider;

        /// <summary>
        /// http 请求配置信息
        /// </summary>
        private HttpRequestConfig _httpRequestConfig;

        /// <summary>
        /// 使用的锁对象
        /// </summary>
        private static readonly object obj =new object();


        /// <summary>
        /// 单例对象
        /// </summary>
        private static JdCloud instance;

        /// <summary>
        /// 构造方法
        /// </summary>
        private JdCloud() { }

        /// <summary>
        /// 获取单例对象
        /// </summary>
        public static JdCloud DefaultInstance
        {
            get {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new JdCloud();
                            //保障HttpConfig 在用户不配置的情况下默认是初始化的
                            instance._httpRequestConfig = new HttpRequestConfig();
                        }
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// 获取认证信息
        /// </summary>
        /// <returns>获取认证信息</returns>
        public CredentialsProvider GetCredentialsProvider()
        {
            return this._credentialsProvider;
        }


        /// <summary>
        /// 获取http 配置信息
        /// </summary>
        /// <returns>http 配置信息</returns>
        public HttpRequestConfig GetHttpRequestConfig()
        {
            return this._httpRequestConfig;
        }


        /// <summary>
        /// 设置认证信息
        /// </summary>
        /// <param name="credentialsProvider">设置认证信息</param>
        public static void CredentialsProvider(CredentialsProvider credentialsProvider)
        {
            DefaultInstance._credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 设置http 请求信息
        /// </summary>
        /// <param name="httpRequestConfig">设置http 请求信息</param>
        public static void HttpRequestConfig(HttpRequestConfig httpRequestConfig)
        {
            DefaultInstance._httpRequestConfig = httpRequestConfig;
        }
    }
}
