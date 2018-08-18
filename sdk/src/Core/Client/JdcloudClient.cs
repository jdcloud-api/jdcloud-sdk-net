using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Common.Profile;
using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
#if NET40 || NET35
#else
using System.Net.Http;
#endif
using System.Text;

namespace JDCloudSDK.Core.Client
{
    /// <summary>
    /// 调用client 抽象类
    /// </summary>
   public abstract class JdcloudClient
    {

        /// <summary>
        /// 用户Http 请求 浏览器user-agent 配置字符串
        /// </summary>
        public abstract string UserAgent { get; }

        /// <summary>
        /// 请求的服务名称
        /// </summary>
        public abstract string ServiceName { get; }


        /// <summary>
        /// 请求的api 接口版本
        /// </summary>
        public abstract string Version { get; }


        /// <summary>
        /// Api 请求 content type 定义
        /// </summary>
        public const string MIME_JSON = "application/json";

        /// <summary>
        /// 客户端配置
        /// </summary>
        public virtual ClientProfile ClientProfile { get; set; }

        /// <summary>
        /// 客户端认证信息
        /// </summary>
        public virtual   Credential Credential { get; set; }

        /// <summary>
        /// http请求头
        /// </summary>
        private readonly Dictionary<String, String> customHeader = new Dictionary<string, string>();


        /// <summary>
        /// 请求终结点配置
        /// </summary>
        public virtual SDKEnvironment SDKEnvironment { get; set; }

#if NET40 || NET35
#else
        /// <summary>
        /// Api 请求 使用的HttpClient
        /// </summary>
        private readonly static HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// 获取调用客户端
        /// </summary>
        public HttpClient HttpClient
        {
            get
            {
                if (_httpClient.Timeout == null)
                {
                    _httpClient.Timeout = TimeSpan.FromSeconds(this.ClientProfile.HttpProfile.Timeout);
                    _httpClient.DefaultRequestHeaders.Connection.Add("keep-alive");
                }
                return _httpClient;
            }
        }

#endif

        /// <summary>
        /// 设置用户自定义请求头
        /// </summary>
        /// <param name="key">头的Head</param>
        /// <param name="value">值</param>
        public void SetCustomHeader(String key, String value)
        {
            this.customHeader.Add(key, value);
        }

        /// <summary>
        /// 获取用户自定义头信息
        /// </summary>
        /// <returns>获取用户自定义的头信息</returns>
        public Dictionary<String, String> CustomHeader
        {
            get { return this.customHeader; } 
        }


    }
}
