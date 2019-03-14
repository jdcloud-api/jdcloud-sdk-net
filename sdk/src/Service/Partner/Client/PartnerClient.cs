/*
 * Copyright 2018 JDCLOUD.COM
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http:#www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * 渠道合作伙伴管理平台API
 * 欢迎使用京东云渠道合作伙伴 API 服务。 本文档提供的 API 可供渠道合作伙伴使用请求调用的方式来管理客户。渠道合作伙伴 API全新发布，提供更加规范和全面的 API 接口文档，统一的参数风格和公共错误码，统一的 SDK/CLI 版本与 API 文档严格一致，给您带来简单快捷的使用体验；支持全地域就近接入让您更快连接京东云产品。
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Partner.Apis;
using JDCloudSDK.Partner.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Partner.Client
{
    /// <summary>
    ///  渠道合作伙伴管理平台API
    ///  欢迎使用京东云渠道合作伙伴 API 服务。 本文档提供的 API 可供渠道合作伙伴使用请求调用的方式来管理客户。渠道合作伙伴 API全新发布，提供更加规范和全面的 API 接口文档，统一的参数风格和公共错误码，统一的 SDK/CLI 版本与 API 文档严格一致，给您带来简单快捷的使用体验；支持全地域就近接入让您更快连接京东云产品。
    ///  Partner Api 客户端
    ///</summary>
    public class PartnerClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private PartnerClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public PartnerClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
            this.environment = environment;
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="credentialsProvider">认证信息</param>
        public PartnerClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public PartnerClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.9
        ///</summary>
        public const string ClientVersion = "1.0.9";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "partner.jdcloud-api.com";
        private const string serviceName = "partner";
        private const string userAgent = userAgentPrefix + "/" + ClientVersion + " " + serviceName + "/" + apiVersion;


        private SDKEnvironment environment = new SDKEnvironment(defaultEndpoint);
        private CredentialsProvider credentialsProvider;
        private HttpRequestConfig httpRequestConfig;

        /// <summary>
        ///  获取证书信息
        ///</summary>
        public override CredentialsProvider CredentialsProvider   { get { return credentialsProvider; } }

        /// <summary>
        ///  获取http 客户端配置信息
        ///</summary>
        public override HttpRequestConfig HttpRequestConfig { get { return httpRequestConfig; } }

        /// <summary>
        ///  获取sdk环境配置信息
        ///</summary>
        public override SDKEnvironment SDKEnvironment { get { return environment; } }

        /// <summary>
        ///  获取用户自定义浏览器识别字符串
        ///</summary>
        public override string UserAgent { get { return userAgent; } }

        /// <summary>
        ///  获取服务名称
        ///</summary>
        public override string ServiceName { get { return serviceName; } }

        /// <summary>
        ///  获取版本号
        ///</summary>
        public override string Version { get { return apiVersion; } }



#if NET40||NET35
        /// <summary>
        ///  查询客户信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryMyCustomerListResponse QueryMyCustomerList(QueryMyCustomerListRequest request) {
            return  new QueryMyCustomerListExecutor().Client(this).Execute<QueryMyCustomerListResponse, QueryMyCustomerListResult, QueryMyCustomerListRequest>(request);
        }
#else
        /// <summary>
        ///  查询客户信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryMyCustomerListResponse> QueryMyCustomerList(QueryMyCustomerListRequest request) {
            return await new QueryMyCustomerListExecutor().Client(this).Execute<QueryMyCustomerListResponse, QueryMyCustomerListResult, QueryMyCustomerListRequest>(request);
        }
#endif

            /// <summary>
            ///  默认PartnerClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>partnerClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>partnerClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>partnerClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造PartnerClient 对象
                ///</summary>
                PartnerClient Build();
            }

            /// <summary>
            ///  默认PartnerClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  PartnerClient service client
                /// </summary>
                private  PartnerClient partnerClient;

                /// <summary>
                ///  默认PartnerClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    partnerClient = new PartnerClient();
                }

                /// <summary>
                ///  构造PartnerClient 对象
                ///</summary>
                public PartnerClient Build()
                {
                    if (partnerClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        partnerClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (partnerClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("PartnerClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (partnerClient.HttpRequestConfig == null)
                    {
                        partnerClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (partnerClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("PartnerClient build error: http request config not set");
                        }
                    }
                    return partnerClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>partnerClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    partnerClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>partnerClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    partnerClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>partnerClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    partnerClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}