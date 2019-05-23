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
 * 计费
 * 计费系统API接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Billing.Apis;
using JDCloudSDK.Billing.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Billing.Client
{
    /// <summary>
    ///  计费
    ///  计费系统API接口
    ///  Billing Api 客户端
    ///</summary>
    public class BillingClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private BillingClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public BillingClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public BillingClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public BillingClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.1.0
        ///</summary>
        public const string ClientVersion = "1.1.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "billing.jdcloud-api.com";
        private const string serviceName = "billing";
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
        ///  查询账单资源汇总数据
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryBillSummaryResponse QueryBillSummary(QueryBillSummaryRequest request) {
            return  new QueryBillSummaryExecutor().Client(this).Execute<QueryBillSummaryResponse, QueryBillSummaryResult, QueryBillSummaryRequest>(request);
        }
#else
        /// <summary>
        ///  查询账单资源汇总数据
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryBillSummaryResponse> QueryBillSummary(QueryBillSummaryRequest request) {
            return await new QueryBillSummaryExecutor().Client(this).Execute<QueryBillSummaryResponse, QueryBillSummaryResult, QueryBillSummaryRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询账单明细数据
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryBillDetailResponse QueryBillDetail(QueryBillDetailRequest request) {
            return  new QueryBillDetailExecutor().Client(this).Execute<QueryBillDetailResponse, QueryBillDetailResult, QueryBillDetailRequest>(request);
        }
#else
        /// <summary>
        ///  查询账单明细数据
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryBillDetailResponse> QueryBillDetail(QueryBillDetailRequest request) {
            return await new QueryBillDetailExecutor().Client(this).Execute<QueryBillDetailResponse, QueryBillDetailResult, QueryBillDetailRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认BillingClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>billingClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>billingClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>billingClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造BillingClient 对象
                ///</summary>
                BillingClient Build();
            }

            /// <summary>
            ///  默认BillingClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  BillingClient service client
                /// </summary>
                private  BillingClient billingClient;

                /// <summary>
                ///  默认BillingClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    billingClient = new BillingClient();
                }

                /// <summary>
                ///  构造BillingClient 对象
                ///</summary>
                public BillingClient Build()
                {
                    if (billingClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        billingClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (billingClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("BillingClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (billingClient.HttpRequestConfig == null)
                    {
                        billingClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (billingClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("BillingClient build error: http request config not set");
                        }
                    }
                    return billingClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>billingClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    billingClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>billingClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    billingClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>billingClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    billingClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
