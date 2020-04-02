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
 * 京东云kafka接口
 * kafka相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Kafka.Apis;
using JDCloudSDK.Kafka.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Kafka.Client
{
    /// <summary>
    ///  京东云kafka接口
    ///  kafka相关接口
    ///  Kafka Api 客户端
    ///</summary>
    public class KafkaClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private KafkaClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public KafkaClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public KafkaClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public KafkaClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.0
        ///</summary>
        public const string ClientVersion = "1.2.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "kafka.jdcloud-api.com";
        private const string serviceName = "kafka";
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
        ///  获取kafka instance broker 列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeBrokersResponse DescribeBrokers(DescribeBrokersRequest request) {
            return  new DescribeBrokersExecutor().Client(this).Execute<DescribeBrokersResponse, DescribeBrokersResult, DescribeBrokersRequest>(request);
        }
#else
        /// <summary>
        ///  获取kafka instance broker 列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeBrokersResponse> DescribeBrokers(DescribeBrokersRequest request) {
            return await new DescribeBrokersExecutor().Client(this).Execute<DescribeBrokersResponse, DescribeBrokersResult, DescribeBrokersRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建一个指定配置的kafka实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request) {
            return  new CreateInstanceExecutor().Client(this).Execute<CreateInstanceResponse, CreateInstanceResult, CreateInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  创建一个指定配置的kafka实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest request) {
            return await new CreateInstanceExecutor().Client(this).Execute<CreateInstanceResponse, CreateInstanceResult, CreateInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询kafka实例的详细信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request) {
            return  new DescribeInstanceExecutor().Client(this).Execute<DescribeInstanceResponse, DescribeInstanceResult, DescribeInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  查询kafka实例的详细信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest request) {
            return await new DescribeInstanceExecutor().Client(this).Execute<DescribeInstanceResponse, DescribeInstanceResult, DescribeInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询kafka实例列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request) {
            return  new DescribeInstancesExecutor().Client(this).Execute<DescribeInstancesResponse, DescribeInstancesResult, DescribeInstancesRequest>(request);
        }
#else
        /// <summary>
        ///  查询kafka实例列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest request) {
            return await new DescribeInstancesExecutor().Client(this).Execute<DescribeInstancesResponse, DescribeInstancesResult, DescribeInstancesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询kafka实例名称
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SelectDetailListResponse SelectDetailList(SelectDetailListRequest request) {
            return  new SelectDetailListExecutor().Client(this).Execute<SelectDetailListResponse, SelectDetailListResult, SelectDetailListRequest>(request);
        }
#else
        /// <summary>
        ///  查询kafka实例名称
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SelectDetailListResponse> SelectDetailList(SelectDetailListRequest request) {
            return await new SelectDetailListExecutor().Client(this).Execute<SelectDetailListResponse, SelectDetailListResult, SelectDetailListRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除按配置计费或包年包月已到期的kafka实例，包年包月未到期不可删除。
        /// 状态为创建中和变配中的不可删除。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request) {
            return  new DeleteInstanceExecutor().Client(this).Execute<DeleteInstanceResponse, DeleteInstanceResult, DeleteInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  删除按配置计费或包年包月已到期的kafka实例，包年包月未到期不可删除。
        /// 状态为创建中和变配中的不可删除。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest request) {
            return await new DeleteInstanceExecutor().Client(this).Execute<DeleteInstanceResponse, DeleteInstanceResult, DeleteInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  变更kafka实例的配置，实例为running状态才可变更配置
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyInstanceSpecResponse ModifyInstanceSpec(ModifyInstanceSpecRequest request) {
            return  new ModifyInstanceSpecExecutor().Client(this).Execute<ModifyInstanceSpecResponse, ModifyInstanceSpecResult, ModifyInstanceSpecRequest>(request);
        }
#else
        /// <summary>
        ///  变更kafka实例的配置，实例为running状态才可变更配置
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpec(ModifyInstanceSpecRequest request) {
            return await new ModifyInstanceSpecExecutor().Client(this).Execute<ModifyInstanceSpecResponse, ModifyInstanceSpecResult, ModifyInstanceSpecRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取kafka instance topic 列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeTopicsResponse DescribeTopics(DescribeTopicsRequest request) {
            return  new DescribeTopicsExecutor().Client(this).Execute<DescribeTopicsResponse, DescribeTopicsResult, DescribeTopicsRequest>(request);
        }
#else
        /// <summary>
        ///  获取kafka instance topic 列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeTopicsResponse> DescribeTopics(DescribeTopicsRequest request) {
            return await new DescribeTopicsExecutor().Client(this).Execute<DescribeTopicsResponse, DescribeTopicsResult, DescribeTopicsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取kafka配置信息，包括版本、规格详情和AZ的配置
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceSpecConfResponse DescribeInstanceSpecConf(DescribeInstanceSpecConfRequest request) {
            return  new DescribeInstanceSpecConfExecutor().Client(this).Execute<DescribeInstanceSpecConfResponse, DescribeInstanceSpecConfResult, DescribeInstanceSpecConfRequest>(request);
        }
#else
        /// <summary>
        ///  获取kafka配置信息，包括版本、规格详情和AZ的配置
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceSpecConfResponse> DescribeInstanceSpecConf(DescribeInstanceSpecConfRequest request) {
            return await new DescribeInstanceSpecConfExecutor().Client(this).Execute<DescribeInstanceSpecConfResponse, DescribeInstanceSpecConfResult, DescribeInstanceSpecConfRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取kafka topic consumerGroup 列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeConsumerGroupsByTopicResponse DescribeConsumerGroupsByTopic(DescribeConsumerGroupsByTopicRequest request) {
            return  new DescribeConsumerGroupsByTopicExecutor().Client(this).Execute<DescribeConsumerGroupsByTopicResponse, DescribeConsumerGroupsByTopicResult, DescribeConsumerGroupsByTopicRequest>(request);
        }
#else
        /// <summary>
        ///  获取kafka topic consumerGroup 列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeConsumerGroupsByTopicResponse> DescribeConsumerGroupsByTopic(DescribeConsumerGroupsByTopicRequest request) {
            return await new DescribeConsumerGroupsByTopicExecutor().Client(this).Execute<DescribeConsumerGroupsByTopicResponse, DescribeConsumerGroupsByTopicResult, DescribeConsumerGroupsByTopicRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认KafkaClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>kafkaClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>kafkaClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>kafkaClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造KafkaClient 对象
                ///</summary>
                KafkaClient Build();
            }

            /// <summary>
            ///  默认KafkaClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  KafkaClient service client
                /// </summary>
                private  KafkaClient kafkaClient;

                /// <summary>
                ///  默认KafkaClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    kafkaClient = new KafkaClient();
                }

                /// <summary>
                ///  构造KafkaClient 对象
                ///</summary>
                public KafkaClient Build()
                {
                    if (kafkaClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        kafkaClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (kafkaClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("KafkaClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (kafkaClient.HttpRequestConfig == null)
                    {
                        kafkaClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (kafkaClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("KafkaClient build error: http request config not set");
                        }
                    }
                    return kafkaClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>kafkaClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    kafkaClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>kafkaClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    kafkaClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>kafkaClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    kafkaClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
