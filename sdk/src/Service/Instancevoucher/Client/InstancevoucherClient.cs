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
 * 实例抵扣券服务
 * 实例抵扣券服务
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Instancevoucher.Apis;
using JDCloudSDK.Instancevoucher.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Instancevoucher.Client
{
    /// <summary>
    ///  实例抵扣券服务
    ///  实例抵扣券服务
    ///  Instancevoucher Api 客户端
    ///</summary>
    public class InstancevoucherClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private InstancevoucherClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public InstancevoucherClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public InstancevoucherClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public InstancevoucherClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.3
        ///</summary>
        public const string ClientVersion = "1.2.3";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "instancevoucher.jdcloud-api.com";
        private const string serviceName = "instancevoucher";
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
        ///  查询实例规格信息列表
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceVoucherTypesResponse DescribeInstanceVoucherTypes(DescribeInstanceVoucherTypesRequest request) {
            return  new DescribeInstanceVoucherTypesExecutor().Client(this).Execute<DescribeInstanceVoucherTypesResponse, DescribeInstanceVoucherTypesResult, DescribeInstanceVoucherTypesRequest>(request);
        }
#else
        /// <summary>
        ///  查询实例规格信息列表
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceVoucherTypesResponse> DescribeInstanceVoucherTypes(DescribeInstanceVoucherTypesRequest request) {
            return await new DescribeInstanceVoucherTypesExecutor().Client(this).Execute<DescribeInstanceVoucherTypesResponse, DescribeInstanceVoucherTypesResult, DescribeInstanceVoucherTypesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改实例抵扣券的 名称 和 描述。&lt;br&gt;
        /// name 和 description 必须要指定一个
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyInstanceVoucherAttributeResponse ModifyInstanceVoucherAttribute(ModifyInstanceVoucherAttributeRequest request) {
            return  new ModifyInstanceVoucherAttributeExecutor().Client(this).Execute<ModifyInstanceVoucherAttributeResponse, ModifyInstanceVoucherAttributeResult, ModifyInstanceVoucherAttributeRequest>(request);
        }
#else
        /// <summary>
        ///  修改实例抵扣券的 名称 和 描述。&lt;br&gt;
        /// name 和 description 必须要指定一个
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyInstanceVoucherAttributeResponse> ModifyInstanceVoucherAttribute(ModifyInstanceVoucherAttributeRequest request) {
            return await new ModifyInstanceVoucherAttributeExecutor().Client(this).Execute<ModifyInstanceVoucherAttributeResponse, ModifyInstanceVoucherAttributeResult, ModifyInstanceVoucherAttributeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询配额
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeQuotasResponse DescribeQuotas(DescribeQuotasRequest request) {
            return  new DescribeQuotasExecutor().Client(this).Execute<DescribeQuotasResponse, DescribeQuotasResult, DescribeQuotasRequest>(request);
        }
#else
        /// <summary>
        ///  查询配额
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeQuotasResponse> DescribeQuotas(DescribeQuotasRequest request) {
            return await new DescribeQuotasExecutor().Client(this).Execute<DescribeQuotasResponse, DescribeQuotasResult, DescribeQuotasRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询实例抵扣券的详细信息
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceVoucherResponse DescribeInstanceVoucher(DescribeInstanceVoucherRequest request) {
            return  new DescribeInstanceVoucherExecutor().Client(this).Execute<DescribeInstanceVoucherResponse, DescribeInstanceVoucherResult, DescribeInstanceVoucherRequest>(request);
        }
#else
        /// <summary>
        ///  查询实例抵扣券的详细信息
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceVoucherResponse> DescribeInstanceVoucher(DescribeInstanceVoucherRequest request) {
            return await new DescribeInstanceVoucherExecutor().Client(this).Execute<DescribeInstanceVoucherResponse, DescribeInstanceVoucherResult, DescribeInstanceVoucherRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建实例抵扣券
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateInstanceVoucherResponse CreateInstanceVoucher(CreateInstanceVoucherRequest request) {
            return  new CreateInstanceVoucherExecutor().Client(this).Execute<CreateInstanceVoucherResponse, CreateInstanceVoucherResult, CreateInstanceVoucherRequest>(request);
        }
#else
        /// <summary>
        ///  创建实例抵扣券
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateInstanceVoucherResponse> CreateInstanceVoucher(CreateInstanceVoucherRequest request) {
            return await new CreateInstanceVoucherExecutor().Client(this).Execute<CreateInstanceVoucherResponse, CreateInstanceVoucherResult, CreateInstanceVoucherRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除实例抵扣券
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteInstanceVoucherResponse DeleteInstanceVoucher(DeleteInstanceVoucherRequest request) {
            return  new DeleteInstanceVoucherExecutor().Client(this).Execute<DeleteInstanceVoucherResponse, DeleteInstanceVoucherResult, DeleteInstanceVoucherRequest>(request);
        }
#else
        /// <summary>
        ///  删除实例抵扣券
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteInstanceVoucherResponse> DeleteInstanceVoucher(DeleteInstanceVoucherRequest request) {
            return await new DeleteInstanceVoucherExecutor().Client(this).Execute<DeleteInstanceVoucherResponse, DeleteInstanceVoucherResult, DeleteInstanceVoucherRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  批量查询实例抵扣券的详细信息&lt;br&gt;
        /// 此接口支持分页查询，默认每页20条。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceVouchersResponse DescribeInstanceVouchers(DescribeInstanceVouchersRequest request) {
            return  new DescribeInstanceVouchersExecutor().Client(this).Execute<DescribeInstanceVouchersResponse, DescribeInstanceVouchersResult, DescribeInstanceVouchersRequest>(request);
        }
#else
        /// <summary>
        ///  批量查询实例抵扣券的详细信息&lt;br&gt;
        /// 此接口支持分页查询，默认每页20条。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceVouchersResponse> DescribeInstanceVouchers(DescribeInstanceVouchersRequest request) {
            return await new DescribeInstanceVouchersExecutor().Client(this).Execute<DescribeInstanceVouchersResponse, DescribeInstanceVouchersResult, DescribeInstanceVouchersRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认InstancevoucherClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>instancevoucherClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>instancevoucherClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>instancevoucherClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造InstancevoucherClient 对象
                ///</summary>
                InstancevoucherClient Build();
            }

            /// <summary>
            ///  默认InstancevoucherClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  InstancevoucherClient service client
                /// </summary>
                private  InstancevoucherClient instancevoucherClient;

                /// <summary>
                ///  默认InstancevoucherClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    instancevoucherClient = new InstancevoucherClient();
                }

                /// <summary>
                ///  构造InstancevoucherClient 对象
                ///</summary>
                public InstancevoucherClient Build()
                {
                    if (instancevoucherClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        instancevoucherClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (instancevoucherClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("InstancevoucherClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (instancevoucherClient.HttpRequestConfig == null)
                    {
                        instancevoucherClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (instancevoucherClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("InstancevoucherClient build error: http request config not set");
                        }
                    }
                    return instancevoucherClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>instancevoucherClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    instancevoucherClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>instancevoucherClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    instancevoucherClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>instancevoucherClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    instancevoucherClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
