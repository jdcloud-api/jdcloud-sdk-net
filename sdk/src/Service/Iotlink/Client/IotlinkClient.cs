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
 * 京东云iotlink接口
 * iotlink接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Iotlink.Apis;
using JDCloudSDK.Iotlink.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Iotlink.Client
{
    /// <summary>
    ///  京东云iotlink接口
    ///  iotlink接口
    ///  Iotlink Api 客户端
    ///</summary>
    public class IotlinkClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private IotlinkClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public IotlinkClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public IotlinkClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public IotlinkClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.8
        ///</summary>
        public const string ClientVersion = "1.2.8";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "iotlink.jdcloud-api.com";
        private const string serviceName = "iotlink";
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
        ///  根据物联网卡iccid查询该卡的开关机状态信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public OnOffStatusResponse OnOffStatus(OnOffStatusRequest request) {
            return  new OnOffStatusExecutor().Client(this).Execute<OnOffStatusResponse, OnOffStatusResult, OnOffStatusRequest>(request);
        }
#else
        /// <summary>
        ///  根据物联网卡iccid查询该卡的开关机状态信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<OnOffStatusResponse> OnOffStatus(OnOffStatusRequest request) {
            return await new OnOffStatusExecutor().Client(this).Execute<OnOffStatusResponse, OnOffStatusResult, OnOffStatusRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据物联网卡imsi查询该卡的生命周期信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public LifeStatusByIMSIResponse LifeStatusByIMSI(LifeStatusByIMSIRequest request) {
            return  new LifeStatusByIMSIExecutor().Client(this).Execute<LifeStatusByIMSIResponse, LifeStatusByIMSIResult, LifeStatusByIMSIRequest>(request);
        }
#else
        /// <summary>
        ///  根据物联网卡imsi查询该卡的生命周期信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<LifeStatusByIMSIResponse> LifeStatusByIMSI(LifeStatusByIMSIRequest request) {
            return await new LifeStatusByIMSIExecutor().Client(this).Execute<LifeStatusByIMSIResponse, LifeStatusByIMSIResult, LifeStatusByIMSIRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  物联网卡停机操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CloseIotCardResponse CloseIotCard(CloseIotCardRequest request) {
            return  new CloseIotCardExecutor().Client(this).Execute<CloseIotCardResponse, CloseIotCardResult, CloseIotCardRequest>(request);
        }
#else
        /// <summary>
        ///  物联网卡停机操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CloseIotCardResponse> CloseIotCard(CloseIotCardRequest request) {
            return await new CloseIotCardExecutor().Client(this).Execute<CloseIotCardResponse, CloseIotCardResult, CloseIotCardRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  物联网卡卡操作通用操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public OperateResponse Operate(OperateRequest request) {
            return  new OperateExecutor().Client(this).Execute<OperateResponse, OperateResult, OperateRequest>(request);
        }
#else
        /// <summary>
        ///  物联网卡卡操作通用操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<OperateResponse> Operate(OperateRequest request) {
            return await new OperateExecutor().Client(this).Execute<OperateResponse, OperateResult, OperateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据物联网卡iccid查询该卡的生命周期信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public LifeStatusResponse LifeStatus(LifeStatusRequest request) {
            return  new LifeStatusExecutor().Client(this).Execute<LifeStatusResponse, LifeStatusResult, LifeStatusRequest>(request);
        }
#else
        /// <summary>
        ///  根据物联网卡iccid查询该卡的生命周期信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<LifeStatusResponse> LifeStatus(LifeStatusRequest request) {
            return await new LifeStatusExecutor().Client(this).Execute<LifeStatusResponse, LifeStatusResult, LifeStatusRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  物联网卡停流量操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CloseIotFlowResponse CloseIotFlow(CloseIotFlowRequest request) {
            return  new CloseIotFlowExecutor().Client(this).Execute<CloseIotFlowResponse, CloseIotFlowResult, CloseIotFlowRequest>(request);
        }
#else
        /// <summary>
        ///  物联网卡停流量操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CloseIotFlowResponse> CloseIotFlow(CloseIotFlowRequest request) {
            return await new CloseIotFlowExecutor().Client(this).Execute<CloseIotFlowResponse, CloseIotFlowResult, CloseIotFlowRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据物联网卡iccid查询该卡的gprs状态信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GprsStatusResponse GprsStatus(GprsStatusRequest request) {
            return  new GprsStatusExecutor().Client(this).Execute<GprsStatusResponse, GprsStatusResult, GprsStatusRequest>(request);
        }
#else
        /// <summary>
        ///  根据物联网卡iccid查询该卡的gprs状态信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GprsStatusResponse> GprsStatus(GprsStatusRequest request) {
            return await new GprsStatusExecutor().Client(this).Execute<GprsStatusResponse, GprsStatusResult, GprsStatusRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据物联网卡IMSI查询该卡的GPRS状态信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GprsStatusByIMSIResponse GprsStatusByIMSI(GprsStatusByIMSIRequest request) {
            return  new GprsStatusByIMSIExecutor().Client(this).Execute<GprsStatusByIMSIResponse, GprsStatusByIMSIResult, GprsStatusByIMSIRequest>(request);
        }
#else
        /// <summary>
        ///  根据物联网卡IMSI查询该卡的GPRS状态信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GprsStatusByIMSIResponse> GprsStatusByIMSI(GprsStatusByIMSIRequest request) {
            return await new GprsStatusByIMSIExecutor().Client(this).Execute<GprsStatusByIMSIResponse, GprsStatusByIMSIResult, GprsStatusByIMSIRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  物联网卡开启流量操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public OpenIotFlowResponse OpenIotFlow(OpenIotFlowRequest request) {
            return  new OpenIotFlowExecutor().Client(this).Execute<OpenIotFlowResponse, OpenIotFlowResult, OpenIotFlowRequest>(request);
        }
#else
        /// <summary>
        ///  物联网卡开启流量操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<OpenIotFlowResponse> OpenIotFlow(OpenIotFlowRequest request) {
            return await new OpenIotFlowExecutor().Client(this).Execute<OpenIotFlowResponse, OpenIotFlowResult, OpenIotFlowRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据物联网卡imsi查询该卡的开关机状态信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public OnOffStatusByIMSIResponse OnOffStatusByIMSI(OnOffStatusByIMSIRequest request) {
            return  new OnOffStatusByIMSIExecutor().Client(this).Execute<OnOffStatusByIMSIResponse, OnOffStatusByIMSIResult, OnOffStatusByIMSIRequest>(request);
        }
#else
        /// <summary>
        ///  根据物联网卡imsi查询该卡的开关机状态信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<OnOffStatusByIMSIResponse> OnOffStatusByIMSI(OnOffStatusByIMSIRequest request) {
            return await new OnOffStatusByIMSIExecutor().Client(this).Execute<OnOffStatusByIMSIResponse, OnOffStatusByIMSIResult, OnOffStatusByIMSIRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据物联网卡iccid查询该卡的当月套餐内的GPRS实时使用量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GprsRealtimeInfoResponse GprsRealtimeInfo(GprsRealtimeInfoRequest request) {
            return  new GprsRealtimeInfoExecutor().Client(this).Execute<GprsRealtimeInfoResponse, GprsRealtimeInfoResult, GprsRealtimeInfoRequest>(request);
        }
#else
        /// <summary>
        ///  根据物联网卡iccid查询该卡的当月套餐内的GPRS实时使用量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GprsRealtimeInfoResponse> GprsRealtimeInfo(GprsRealtimeInfoRequest request) {
            return await new GprsRealtimeInfoExecutor().Client(this).Execute<GprsRealtimeInfoResponse, GprsRealtimeInfoResult, GprsRealtimeInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  物联网卡开机操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public OpenIotCardResponse OpenIotCard(OpenIotCardRequest request) {
            return  new OpenIotCardExecutor().Client(this).Execute<OpenIotCardResponse, OpenIotCardResult, OpenIotCardRequest>(request);
        }
#else
        /// <summary>
        ///  物联网卡开机操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<OpenIotCardResponse> OpenIotCard(OpenIotCardRequest request) {
            return await new OpenIotCardExecutor().Client(this).Execute<OpenIotCardResponse, OpenIotCardResult, OpenIotCardRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  物联网卡查询通用操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SearchResponse Search(SearchRequest request) {
            return  new SearchExecutor().Client(this).Execute<SearchResponse, SearchResult, SearchRequest>(request);
        }
#else
        /// <summary>
        ///  物联网卡查询通用操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SearchResponse> Search(SearchRequest request) {
            return await new SearchExecutor().Client(this).Execute<SearchResponse, SearchResult, SearchRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据物联网卡imsi查询该卡的当月套餐内的GPRS实时使用量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GprsRealtimeInfoByIMSIResponse GprsRealtimeInfoByIMSI(GprsRealtimeInfoByIMSIRequest request) {
            return  new GprsRealtimeInfoByIMSIExecutor().Client(this).Execute<GprsRealtimeInfoByIMSIResponse, GprsRealtimeInfoByIMSIResult, GprsRealtimeInfoByIMSIRequest>(request);
        }
#else
        /// <summary>
        ///  根据物联网卡imsi查询该卡的当月套餐内的GPRS实时使用量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GprsRealtimeInfoByIMSIResponse> GprsRealtimeInfoByIMSI(GprsRealtimeInfoByIMSIRequest request) {
            return await new GprsRealtimeInfoByIMSIExecutor().Client(this).Execute<GprsRealtimeInfoByIMSIResponse, GprsRealtimeInfoByIMSIResult, GprsRealtimeInfoByIMSIRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认IotlinkClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>iotlinkClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>iotlinkClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>iotlinkClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造IotlinkClient 对象
                ///</summary>
                IotlinkClient Build();
            }

            /// <summary>
            ///  默认IotlinkClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  IotlinkClient service client
                /// </summary>
                private  IotlinkClient iotlinkClient;

                /// <summary>
                ///  默认IotlinkClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    iotlinkClient = new IotlinkClient();
                }

                /// <summary>
                ///  构造IotlinkClient 对象
                ///</summary>
                public IotlinkClient Build()
                {
                    if (iotlinkClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        iotlinkClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (iotlinkClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("IotlinkClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (iotlinkClient.HttpRequestConfig == null)
                    {
                        iotlinkClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (iotlinkClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("IotlinkClient build error: http request config not set");
                        }
                    }
                    return iotlinkClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>iotlinkClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    iotlinkClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>iotlinkClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    iotlinkClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>iotlinkClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    iotlinkClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
