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
 * 京东云富媒体短信OpenAPI接口
 * 京东云富媒体短信OpenAPI接口
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Rms.Apis;
using JDCloudSDK.Rms.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Rms.Client
{
    /// <summary>
    ///  京东云富媒体短信OpenAPI接口
    ///  京东云富媒体短信OpenAPI接口
    ///  Rms Api 客户端
    ///</summary>
    public class RmsClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private RmsClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public RmsClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public RmsClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public RmsClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.3
        ///</summary>
        public const string ClientVersion = "1.2.3";

        private const string apiVersion = "v2";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "rms.jdcloud-api.com";
        private const string serviceName = "rms";
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
        ///  查询富媒体短信资质列表接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryCreditListResponse QueryCreditList(QueryCreditListRequest request) {
            return  new QueryCreditListExecutor().Client(this).Execute<QueryCreditListResponse, QueryCreditListResult, QueryCreditListRequest>(request);
        }
#else
        /// <summary>
        ///  查询富媒体短信资质列表接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryCreditListResponse> QueryCreditList(QueryCreditListRequest request) {
            return await new QueryCreditListExecutor().Client(this).Execute<QueryCreditListResponse, QueryCreditListResult, QueryCreditListRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除富媒体短信内容接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request) {
            return  new DeleteTemplateExecutor().Client(this).Execute<DeleteTemplateResponse, DeleteTemplateResult, DeleteTemplateRequest>(request);
        }
#else
        /// <summary>
        ///  删除富媒体短信内容接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteTemplateResponse> DeleteTemplate(DeleteTemplateRequest request) {
            return await new DeleteTemplateExecutor().Client(this).Execute<DeleteTemplateResponse, DeleteTemplateResult, DeleteTemplateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询富媒体短信内容列表接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryTemplateListResponse QueryTemplateList(QueryTemplateListRequest request) {
            return  new QueryTemplateListExecutor().Client(this).Execute<QueryTemplateListResponse, QueryTemplateListResult, QueryTemplateListRequest>(request);
        }
#else
        /// <summary>
        ///  查询富媒体短信内容列表接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryTemplateListResponse> QueryTemplateList(QueryTemplateListRequest request) {
            return await new QueryTemplateListExecutor().Client(this).Execute<QueryTemplateListResponse, QueryTemplateListResult, QueryTemplateListRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  增加富媒体短信内容接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddTemplateNewResponse AddTemplateNew(AddTemplateNewRequest request) {
            return  new AddTemplateNewExecutor().Client(this).Execute<AddTemplateNewResponse, AddTemplateNewResult, AddTemplateNewRequest>(request);
        }
#else
        /// <summary>
        ///  增加富媒体短信内容接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddTemplateNewResponse> AddTemplateNew(AddTemplateNewRequest request) {
            return await new AddTemplateNewExecutor().Client(this).Execute<AddTemplateNewResponse, AddTemplateNewResult, AddTemplateNewRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  套餐包余量，仅预付费用户使用
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryPackageRemainderResponse QueryPackageRemainder(QueryPackageRemainderRequest request) {
            return  new QueryPackageRemainderExecutor().Client(this).Execute<QueryPackageRemainderResponse, QueryPackageRemainderResult, QueryPackageRemainderRequest>(request);
        }
#else
        /// <summary>
        ///  套餐包余量，仅预付费用户使用
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryPackageRemainderResponse> QueryPackageRemainder(QueryPackageRemainderRequest request) {
            return await new QueryPackageRemainderExecutor().Client(this).Execute<QueryPackageRemainderResponse, QueryPackageRemainderResult, QueryPackageRemainderRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改富媒体短信资质接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public EditCreditResponse EditCredit(EditCreditRequest request) {
            return  new EditCreditExecutor().Client(this).Execute<EditCreditResponse, EditCreditResult, EditCreditRequest>(request);
        }
#else
        /// <summary>
        ///  修改富媒体短信资质接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<EditCreditResponse> EditCredit(EditCreditRequest request) {
            return await new EditCreditExecutor().Client(this).Execute<EditCreditResponse, EditCreditResult, EditCreditRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除富媒体短信资质接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteCreditResponse DeleteCredit(DeleteCreditRequest request) {
            return  new DeleteCreditExecutor().Client(this).Execute<DeleteCreditResponse, DeleteCreditResult, DeleteCreditRequest>(request);
        }
#else
        /// <summary>
        ///  删除富媒体短信资质接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteCreditResponse> DeleteCredit(DeleteCreditRequest request) {
            return await new DeleteCreditExecutor().Client(this).Execute<DeleteCreditResponse, DeleteCreditResult, DeleteCreditRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  指定短信Id群发短信
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public SendBatchMsgResponse SendBatchMsg(SendBatchMsgRequest request) {
            return  new SendBatchMsgExecutor().Client(this).Execute<SendBatchMsgResponse, SendBatchMsgResult, SendBatchMsgRequest>(request);
        }
#else
        /// <summary>
        ///  指定短信Id群发短信
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<SendBatchMsgResponse> SendBatchMsg(SendBatchMsgRequest request) {
            return await new SendBatchMsgExecutor().Client(this).Execute<SendBatchMsgResponse, SendBatchMsgResult, SendBatchMsgRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改富媒体短信内容接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public EditTemplateResponse EditTemplate(EditTemplateRequest request) {
            return  new EditTemplateExecutor().Client(this).Execute<EditTemplateResponse, EditTemplateResult, EditTemplateRequest>(request);
        }
#else
        /// <summary>
        ///  修改富媒体短信内容接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<EditTemplateResponse> EditTemplate(EditTemplateRequest request) {
            return await new EditTemplateExecutor().Client(this).Execute<EditTemplateResponse, EditTemplateResult, EditTemplateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询一个富媒体短信内容接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryTemplateByIdResponse QueryTemplateById(QueryTemplateByIdRequest request) {
            return  new QueryTemplateByIdExecutor().Client(this).Execute<QueryTemplateByIdResponse, QueryTemplateByIdResult, QueryTemplateByIdRequest>(request);
        }
#else
        /// <summary>
        ///  查询一个富媒体短信内容接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryTemplateByIdResponse> QueryTemplateById(QueryTemplateByIdRequest request) {
            return await new QueryTemplateByIdExecutor().Client(this).Execute<QueryTemplateByIdResponse, QueryTemplateByIdResult, QueryTemplateByIdRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  增加富媒体短信资质接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AddCreditResponse AddCredit(AddCreditRequest request) {
            return  new AddCreditExecutor().Client(this).Execute<AddCreditResponse, AddCreditResult, AddCreditRequest>(request);
        }
#else
        /// <summary>
        ///  增加富媒体短信资质接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AddCreditResponse> AddCredit(AddCreditRequest request) {
            return await new AddCreditExecutor().Client(this).Execute<AddCreditResponse, AddCreditResult, AddCreditRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取发送状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QuerySendStatusResponse QuerySendStatus(QuerySendStatusRequest request) {
            return  new QuerySendStatusExecutor().Client(this).Execute<QuerySendStatusResponse, QuerySendStatusResult, QuerySendStatusRequest>(request);
        }
#else
        /// <summary>
        ///  获取发送状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QuerySendStatusResponse> QuerySendStatus(QuerySendStatusRequest request) {
            return await new QuerySendStatusExecutor().Client(this).Execute<QuerySendStatusResponse, QuerySendStatusResult, QuerySendStatusRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认RmsClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>rmsClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>rmsClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>rmsClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造RmsClient 对象
                ///</summary>
                RmsClient Build();
            }

            /// <summary>
            ///  默认RmsClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  RmsClient service client
                /// </summary>
                private  RmsClient rmsClient;

                /// <summary>
                ///  默认RmsClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    rmsClient = new RmsClient();
                }

                /// <summary>
                ///  构造RmsClient 对象
                ///</summary>
                public RmsClient Build()
                {
                    if (rmsClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        rmsClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (rmsClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("RmsClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (rmsClient.HttpRequestConfig == null)
                    {
                        rmsClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (rmsClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("RmsClient build error: http request config not set");
                        }
                    }
                    return rmsClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>rmsClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    rmsClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>rmsClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    rmsClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>rmsClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    rmsClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
