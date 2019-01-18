using JDCloudSDK.Core.Auth;
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
    ///  调用抽象类客户端
    /// </summary>
    public abstract class JdcloudClient
    {
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
                    _httpClient.Timeout = TimeSpan.FromSeconds(HttpRequestConfig.RequestTimeout);
                    _httpClient.DefaultRequestHeaders.Connection.Add("keep-alive");
                }
                return _httpClient;
            }
        }

#endif
        /// <summary>
        /// Api 请求 content type 定义
        /// </summary>
        public const string MIME_JSON = "application/json";
        
        /// <summary>
        /// 自定义Http请求头 
        /// </summary>
        private Dictionary<string, string> customHeader = new Dictionary<string, string>();




        /// <summary>
        /// 获取终节点信息
        /// </summary>
        public string  Endpoint
        {
            get{
                if (SDKEnvironment != null)
                {
                    return SDKEnvironment.Endpoint;
                }
                return null;
            }
          
        }

        /// <summary>
        /// 获取真实节点信息
        /// </summary>
        public string RealEndPoints
        {
            get { 
                if (SDKEnvironment != null)
                {
                    return SDKEnvironment.RealEndPoints;
                }
                return null;
            }
          
        }



        /// <summary>
        /// 证书信息
        /// </summary>
        public abstract CredentialsProvider CredentialsProvider {  get;  }


        /// <summary>
        /// Http 请求配置信息
        /// </summary>
        public abstract HttpRequestConfig HttpRequestConfig { get;  }

        /// <summary>
        /// SDK 环境配置信息
        /// </summary>
        public abstract SDKEnvironment SDKEnvironment { get; }

        /// <summary>
        /// 用户Http 请求 浏览器user-agent 配置字符串
        /// </summary>
        public abstract string UserAgent { get;  }

        /// <summary>
        /// 请求的服务名称
        /// </summary>
        public abstract string ServiceName { get;  }


        /// <summary>
        /// 请求的api 接口版本
        /// </summary>
        public abstract string Version { get;  }

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
        public Dictionary<String, String> GetCustomHeader()
        {
            return this.customHeader;
        }

    }
}
