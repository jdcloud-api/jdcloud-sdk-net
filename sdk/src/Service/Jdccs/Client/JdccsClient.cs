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
 * Cloud Cabinet Service API
 * 提供云托管服务的相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Jdccs.Apis;
using JDCloudSDK.Jdccs.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Jdccs.Client
{
    /// <summary>
    ///  Cloud Cabinet Service API
    ///  提供云托管服务的相关接口
    ///  Jdccs Api 客户端
    ///</summary>
    public class JdccsClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private JdccsClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public JdccsClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public JdccsClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public JdccsClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.1.0
        ///</summary>
        public const string ClientVersion = "1.1.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "jdccs.jdcloud-api.com";
        private const string serviceName = "jdccs";
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
        ///  查看某资源单个监控项数据
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeMetricDataResponse DescribeMetricData(DescribeMetricDataRequest request) {
            return  new DescribeMetricDataExecutor().Client(this).Execute<DescribeMetricDataResponse, DescribeMetricDataResult, DescribeMetricDataRequest>(request);
        }
#else
        /// <summary>
        ///  查看某资源单个监控项数据
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeMetricDataResponse> DescribeMetricData(DescribeMetricDataRequest request) {
            return await new DescribeMetricDataExecutor().Client(this).Execute<DescribeMetricDataResponse, DescribeMetricDataResult, DescribeMetricDataRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查看某资源的最后一个监控数据点
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public LastDownsampleResponse LastDownsample(LastDownsampleRequest request) {
            return  new LastDownsampleExecutor().Client(this).Execute<LastDownsampleResponse, LastDownsampleResult, LastDownsampleRequest>(request);
        }
#else
        /// <summary>
        ///  查看某资源的最后一个监控数据点
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<LastDownsampleResponse> LastDownsample(LastDownsampleRequest request) {
            return await new LastDownsampleExecutor().Client(this).Execute<LastDownsampleResponse, LastDownsampleResult, LastDownsampleRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询IDC机房列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeIdcsResponse DescribeIdcs(DescribeIdcsRequest request) {
            return  new DescribeIdcsExecutor().Client(this).Execute<DescribeIdcsResponse, DescribeIdcsResult, DescribeIdcsRequest>(request);
        }
#else
        /// <summary>
        ///  查询IDC机房列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeIdcsResponse> DescribeIdcs(DescribeIdcsRequest request) {
            return await new DescribeIdcsExecutor().Client(this).Execute<DescribeIdcsResponse, DescribeIdcsResult, DescribeIdcsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询机柜列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeCabinetsResponse DescribeCabinets(DescribeCabinetsRequest request) {
            return  new DescribeCabinetsExecutor().Client(this).Execute<DescribeCabinetsResponse, DescribeCabinetsResult, DescribeCabinetsRequest>(request);
        }
#else
        /// <summary>
        ///  查询机柜列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeCabinetsResponse> DescribeCabinets(DescribeCabinetsRequest request) {
            return await new DescribeCabinetsExecutor().Client(this).Execute<DescribeCabinetsResponse, DescribeCabinetsResult, DescribeCabinetsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询可用监控项列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeMetricsResponse DescribeMetrics(DescribeMetricsRequest request) {
            return  new DescribeMetricsExecutor().Client(this).Execute<DescribeMetricsResponse, DescribeMetricsResult, DescribeMetricsRequest>(request);
        }
#else
        /// <summary>
        ///  查询可用监控项列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeMetricsResponse> DescribeMetrics(DescribeMetricsRequest request) {
            return await new DescribeMetricsExecutor().Client(this).Execute<DescribeMetricsResponse, DescribeMetricsResult, DescribeMetricsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询机房房间号列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeRoomsResponse DescribeRooms(DescribeRoomsRequest request) {
            return  new DescribeRoomsExecutor().Client(this).Execute<DescribeRoomsResponse, DescribeRoomsResult, DescribeRoomsRequest>(request);
        }
#else
        /// <summary>
        ///  查询机房房间号列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeRoomsResponse> DescribeRooms(DescribeRoomsRequest request) {
            return await new DescribeRoomsExecutor().Client(this).Execute<DescribeRoomsResponse, DescribeRoomsResult, DescribeRoomsRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认JdccsClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>jdccsClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>jdccsClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>jdccsClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造JdccsClient 对象
                ///</summary>
                JdccsClient Build();
            }

            /// <summary>
            ///  默认JdccsClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  JdccsClient service client
                /// </summary>
                private  JdccsClient jdccsClient;

                /// <summary>
                ///  默认JdccsClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    jdccsClient = new JdccsClient();
                }

                /// <summary>
                ///  构造JdccsClient 对象
                ///</summary>
                public JdccsClient Build()
                {
                    if (jdccsClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        jdccsClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (jdccsClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("JdccsClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (jdccsClient.HttpRequestConfig == null)
                    {
                        jdccsClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (jdccsClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("JdccsClient build error: http request config not set");
                        }
                    }
                    return jdccsClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>jdccsClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    jdccsClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>jdccsClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    jdccsClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>jdccsClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    jdccsClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}