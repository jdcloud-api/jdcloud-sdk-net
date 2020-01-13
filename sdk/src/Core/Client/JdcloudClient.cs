using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Common.Profile;
using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
#if NET40 || NET35 ||NET30 ||NET20
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


        private ClientProfile _ClientProfile;

        /// <summary>
        /// 客户端配置
        /// </summary>
        public  ClientProfile ClientProfile {
            get {
                if(_ClientProfile == null)
                {
                    _ClientProfile = new ClientProfile();
                    if (HttpRequestConfig != null) {
                        if (HttpRequestConfig.RequestTimeout > _ClientProfile.HttpProfile.Timeout) {
                            _ClientProfile.HttpProfile.Timeout = HttpRequestConfig.RequestTimeout;
                        } 
                        _ClientProfile.HttpProfile.Protocol = HttpRequestConfig.Protocol.ToString();
                    }
                }
                return _ClientProfile;

            } set {
                _ClientProfile = value;
            }
        }


        private Credential _Credential;

        /// <summary>
        /// 客户端认证信息
        /// </summary>
        public   Credential Credential {
            get {
                if (_Credential == null) {
                    _Credential = CredentialsProvider.GetCredentials();
                }
                return _Credential;
            } set {
                this._Credential = value;
            }
        }


        /// <summary>
        /// 请求终结点配置
        /// </summary>
        public virtual SDKEnvironment SDKEnvironment { get; set; }



        /// <summary>
        /// 获取终节点信息
        /// </summary>
        public string Endpoint
        {
            get
            {
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
            get
            {
                if (SDKEnvironment != null)
                {
                    return SDKEnvironment.RealEndPoints;
                }
                return null;
            }

        }

#if NET40 || NET35 || NET30 ||NET20
#else
        /// <summary>
        /// Api 请求 使用的HttpClient
        /// </summary>
        public  HttpClient HttpClient;

        /// <summary>
        /// http客户端配置信息
        /// </summary>
        public HttpClientHandler httpClientHandler;

        /// <summary>
        /// 获取调用客户端
        /// </summary>
        public HttpClient RequestHttpClient
        {
            get
            {
                if (HttpClient == null)
                {
                    if (httpClientHandler == null)
                    {
                        if (ClientProfile == null || ClientProfile.HttpProfile == null || !string.IsNullOrWhiteSpace(ClientProfile.HttpProfile.WebProxy))
                        {
                            HttpClient = new HttpClient();
                        }
                        else
                        {
                            HttpClientHandler httpClientHandler = new HttpClientHandler();
                            if (!string.IsNullOrWhiteSpace(ClientProfile.HttpProfile.WebProxy)) {
                                httpClientHandler.UseProxy = true;
                                httpClientHandler.Proxy = new WebProxy(ClientProfile.HttpProfile.WebProxy);

                            }
                            HttpClient = new HttpClient(httpClientHandler);
                        }
                    }
                    else
                    {
                        HttpClient = new HttpClient(httpClientHandler);
                    }

                }
                else
                {
                    SDKEnvironment.Endpoint = HttpClient.BaseAddress.ToString();
                }
                if (HttpClient.Timeout == null)
                {
                    HttpClient.Timeout = TimeSpan.FromSeconds(ClientProfile.HttpProfile.Timeout);
                    HttpClient.DefaultRequestHeaders.Connection.Add("keep-alive");
                } 
                return HttpClient;
            }
        }

#endif

        /// <summary>
        /// 设置用户自定义请求头
        /// </summary>
        /// <param name="key">头的Head</param>
        /// <param name="value">值</param>
        public void SetCustomHeader(string key, string value)
        {
            this.CustomHeader.Add(key, value);
        }

        /// <summary>
        /// 获取用户自定义头信息
        /// </summary>
        /// <returns>获取用户自定义的头信息</returns>
        public Dictionary<string, string> CustomHeader { get; } = new Dictionary<string, string>();


        /// <summary>
        /// 证书信息
        /// </summary>
        public abstract CredentialsProvider CredentialsProvider { get; }


        /// <summary>
        /// Http 请求配置信息
        /// </summary>
        public abstract HttpRequestConfig HttpRequestConfig { get; }


    }
}
