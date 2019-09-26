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
 * 云编译
 * 云编译相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Compile.Apis;
using JDCloudSDK.Compile.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Compile.Client
{
    /// <summary>
    ///  云编译
    ///  云编译相关接口
    ///  Compile Api 客户端
    ///</summary>
    public class CompileClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private CompileClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public CompileClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public CompileClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public CompileClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.1.0
        ///</summary>
        public const string ClientVersion = "1.1.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "compile.jdcloud-api.com";
        private const string serviceName = "compile";
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
        ///  根据id获取构建任务的配置信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetJobResponse GetJob(GetJobRequest request) {
            return  new GetJobExecutor().Client(this).Execute<GetJobResponse, GetJobResult, GetJobRequest>(request);
        }
#else
        /// <summary>
        ///  根据id获取构建任务的配置信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetJobResponse> GetJob(GetJobRequest request) {
            return await new GetJobExecutor().Client(this).Execute<GetJobResponse, GetJobResult, GetJobRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据id启动一个编译任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StartJobResponse StartJob(StartJobRequest request) {
            return  new StartJobExecutor().Client(this).Execute<StartJobResponse, StartJobResult, StartJobRequest>(request);
        }
#else
        /// <summary>
        ///  根据id启动一个编译任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StartJobResponse> StartJob(StartJobRequest request) {
            return await new StartJobExecutor().Client(this).Execute<StartJobResponse, StartJobResult, StartJobRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  生成带有效期的包地址
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetExternalLinkResponse GetExternalLink(GetExternalLinkRequest request) {
            return  new GetExternalLinkExecutor().Client(this).Execute<GetExternalLinkResponse, GetExternalLinkResult, GetExternalLinkRequest>(request);
        }
#else
        /// <summary>
        ///  生成带有效期的包地址
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetExternalLinkResponse> GetExternalLink(GetExternalLinkRequest request) {
            return await new GetExternalLinkExecutor().Client(this).Execute<GetExternalLinkResponse, GetExternalLinkResult, GetExternalLinkRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  停止构建任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StopBuildResponse StopBuild(StopBuildRequest request) {
            return  new StopBuildExecutor().Client(this).Execute<StopBuildResponse, StopBuildResult, StopBuildRequest>(request);
        }
#else
        /// <summary>
        ///  停止构建任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StopBuildResponse> StopBuild(StopBuildRequest request) {
            return await new StopBuildExecutor().Client(this).Execute<StopBuildResponse, StopBuildResult, StopBuildRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建Demo
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateDemoResponse CreateDemo(CreateDemoRequest request) {
            return  new CreateDemoExecutor().Client(this).Execute<CreateDemoResponse, CreateDemoResult, CreateDemoRequest>(request);
        }
#else
        /// <summary>
        ///  创建Demo
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateDemoResponse> CreateDemo(CreateDemoRequest request) {
            return await new CreateDemoExecutor().Client(this).Execute<CreateDemoResponse, CreateDemoResult, CreateDemoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询获取编译任务列表，并显示最后一次编译的一些信息
        /// /v2/regions/cn-south-1/jobs/?sorts.1.name&#x3D;status&amp;sorts.1.direction&#x3D;asc&amp;pageNumber&#x3D;1&amp;pageSize&#x3D;10&amp;filters.1.name&#x3D;name&amp;filters.1.values.1&#x3D;我的job
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetJobsResponse GetJobs(GetJobsRequest request) {
            return  new GetJobsExecutor().Client(this).Execute<GetJobsResponse, GetJobsResult, GetJobsRequest>(request);
        }
#else
        /// <summary>
        ///  查询获取编译任务列表，并显示最后一次编译的一些信息
        /// /v2/regions/cn-south-1/jobs/?sorts.1.name&#x3D;status&amp;sorts.1.direction&#x3D;asc&amp;pageNumber&#x3D;1&amp;pageSize&#x3D;10&amp;filters.1.name&#x3D;name&amp;filters.1.values.1&#x3D;我的job
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetJobsResponse> GetJobs(GetJobsRequest request) {
            return await new GetJobsExecutor().Client(this).Execute<GetJobsResponse, GetJobsResult, GetJobsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除一个编译任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteJobResponse DeleteJob(DeleteJobRequest request) {
            return  new DeleteJobExecutor().Client(this).Execute<DeleteJobResponse, DeleteJobResult, DeleteJobRequest>(request);
        }
#else
        /// <summary>
        ///  删除一个编译任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteJobResponse> DeleteJob(DeleteJobRequest request) {
            return await new DeleteJobExecutor().Client(this).Execute<DeleteJobResponse, DeleteJobResult, DeleteJobRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  更新编译任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UpdateJobResponse UpdateJob(UpdateJobRequest request) {
            return  new UpdateJobExecutor().Client(this).Execute<UpdateJobResponse, UpdateJobResult, UpdateJobRequest>(request);
        }
#else
        /// <summary>
        ///  更新编译任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UpdateJobResponse> UpdateJob(UpdateJobRequest request) {
            return await new UpdateJobExecutor().Client(this).Execute<UpdateJobResponse, UpdateJobResult, UpdateJobRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询构建任务执行日志
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetBuildLogResponse GetBuildLog(GetBuildLogRequest request) {
            return  new GetBuildLogExecutor().Client(this).Execute<GetBuildLogResponse, GetBuildLogResult, GetBuildLogRequest>(request);
        }
#else
        /// <summary>
        ///  查询构建任务执行日志
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetBuildLogResponse> GetBuildLog(GetBuildLogRequest request) {
            return await new GetBuildLogExecutor().Client(this).Execute<GetBuildLogResponse, GetBuildLogResult, GetBuildLogRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  新建构建任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateJobResponse CreateJob(CreateJobRequest request) {
            return  new CreateJobExecutor().Client(this).Execute<CreateJobResponse, CreateJobResult, CreateJobRequest>(request);
        }
#else
        /// <summary>
        ///  新建构建任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateJobResponse> CreateJob(CreateJobRequest request) {
            return await new CreateJobExecutor().Client(this).Execute<CreateJobResponse, CreateJobResult, CreateJobRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  批量删除编译任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteJobsResponse DeleteJobs(DeleteJobsRequest request) {
            return  new DeleteJobsExecutor().Client(this).Execute<DeleteJobsResponse, DeleteJobsResult, DeleteJobsRequest>(request);
        }
#else
        /// <summary>
        ///  批量删除编译任务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteJobsResponse> DeleteJobs(DeleteJobsRequest request) {
            return await new DeleteJobsExecutor().Client(this).Execute<DeleteJobsResponse, DeleteJobsResult, DeleteJobsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询构建任务执行的状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetBuildStatusResponse GetBuildStatus(GetBuildStatusRequest request) {
            return  new GetBuildStatusExecutor().Client(this).Execute<GetBuildStatusResponse, GetBuildStatusResult, GetBuildStatusRequest>(request);
        }
#else
        /// <summary>
        ///  查询构建任务执行的状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetBuildStatusResponse> GetBuildStatus(GetBuildStatusRequest request) {
            return await new GetBuildStatusExecutor().Client(this).Execute<GetBuildStatusResponse, GetBuildStatusResult, GetBuildStatusRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认CompileClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>compileClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>compileClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>compileClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造CompileClient 对象
                ///</summary>
                CompileClient Build();
            }

            /// <summary>
            ///  默认CompileClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  CompileClient service client
                /// </summary>
                private  CompileClient compileClient;

                /// <summary>
                ///  默认CompileClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    compileClient = new CompileClient();
                }

                /// <summary>
                ///  构造CompileClient 对象
                ///</summary>
                public CompileClient Build()
                {
                    if (compileClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        compileClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (compileClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("CompileClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (compileClient.HttpRequestConfig == null)
                    {
                        compileClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (compileClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("CompileClient build error: http request config not set");
                        }
                    }
                    return compileClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>compileClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    compileClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>compileClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    compileClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>compileClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    compileClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}