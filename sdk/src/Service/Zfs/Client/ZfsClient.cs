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
 * CFS的API
 * CFS(Cloud-File-Service)的API包含CFS相关接口。
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Zfs.Apis;
using JDCloudSDK.Zfs.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Zfs.Client
{
    /// <summary>
    ///  CFS的API
    ///  CFS(Cloud-File-Service)的API包含CFS相关接口。
    ///  Zfs Api 客户端
    ///</summary>
    public class ZfsClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private ZfsClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public ZfsClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public ZfsClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public ZfsClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.0
        ///</summary>
        public const string ClientVersion = "1.2.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "cfs.jdcloud-api.com";
        private const string serviceName = "zfs";
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
        ///  - 为一个文件系统创建一个挂载目标。通过这个挂载目标,你可以挂载将一个文件系统挂载到主机实例上。
        /// - 创建一个挂载目标，为这个挂载目标分配一个Id
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateMountTargetResponse CreateMountTarget(CreateMountTargetRequest request) {
            return  new CreateMountTargetExecutor().Client(this).Execute<CreateMountTargetResponse, CreateMountTargetResult, CreateMountTargetRequest>(request);
        }
#else
        /// <summary>
        ///  - 为一个文件系统创建一个挂载目标。通过这个挂载目标,你可以挂载将一个文件系统挂载到主机实例上。
        /// - 创建一个挂载目标，为这个挂载目标分配一个Id
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateMountTargetResponse> CreateMountTarget(CreateMountTargetRequest request) {
            return await new CreateMountTargetExecutor().Client(this).Execute<CreateMountTargetResponse, CreateMountTargetResult, CreateMountTargetRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  - 创建一个新的文件系统，为这个文件系统分配一个Id
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateFileSystemResponse CreateFileSystem(CreateFileSystemRequest request) {
            return  new CreateFileSystemExecutor().Client(this).Execute<CreateFileSystemResponse, CreateFileSystemResult, CreateFileSystemRequest>(request);
        }
#else
        /// <summary>
        ///  - 创建一个新的文件系统，为这个文件系统分配一个Id
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateFileSystemResponse> CreateFileSystem(CreateFileSystemRequest request) {
            return await new CreateFileSystemExecutor().Client(this).Execute<CreateFileSystemResponse, CreateFileSystemResult, CreateFileSystemRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询文件系统详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeFileSystemResponse DescribeFileSystem(DescribeFileSystemRequest request) {
            return  new DescribeFileSystemExecutor().Client(this).Execute<DescribeFileSystemResponse, DescribeFileSystemResult, DescribeFileSystemRequest>(request);
        }
#else
        /// <summary>
        ///  查询文件系统详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeFileSystemResponse> DescribeFileSystem(DescribeFileSystemRequest request) {
            return await new DescribeFileSystemExecutor().Client(this).Execute<DescribeFileSystemResponse, DescribeFileSystemResult, DescribeFileSystemRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   删除挂载目标的同时会删除相关的网络接口。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteMountTargetResponse DeleteMountTarget(DeleteMountTargetRequest request) {
            return  new DeleteMountTargetExecutor().Client(this).Execute<DeleteMountTargetResponse, DeleteMountTargetResult, DeleteMountTargetRequest>(request);
        }
#else
        /// <summary>
        ///  -   删除挂载目标的同时会删除相关的网络接口。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteMountTargetResponse> DeleteMountTarget(DeleteMountTargetRequest request) {
            return await new DeleteMountTargetExecutor().Client(this).Execute<DeleteMountTargetResponse, DeleteMountTargetResult, DeleteMountTargetRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   查询文件系统列表。
        /// -   filters多个过滤条件之间是逻辑与(AND)，每个条件内部的多个取值是逻辑或(OR)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeFileSystemsResponse DescribeFileSystems(DescribeFileSystemsRequest request) {
            return  new DescribeFileSystemsExecutor().Client(this).Execute<DescribeFileSystemsResponse, DescribeFileSystemsResult, DescribeFileSystemsRequest>(request);
        }
#else
        /// <summary>
        ///  -   查询文件系统列表。
        /// -   filters多个过滤条件之间是逻辑与(AND)，每个条件内部的多个取值是逻辑或(OR)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeFileSystemsResponse> DescribeFileSystems(DescribeFileSystemsRequest request) {
            return await new DescribeFileSystemsExecutor().Client(this).Execute<DescribeFileSystemsResponse, DescribeFileSystemsResult, DescribeFileSystemsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   删除一个文件系统，一旦删除，该文件系统将不存在，也无法访问已删除的文件系统里的任何内容。
        ///  [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteFileSystemResponse DeleteFileSystem(DeleteFileSystemRequest request) {
            return  new DeleteFileSystemExecutor().Client(this).Execute<DeleteFileSystemResponse, DeleteFileSystemResult, DeleteFileSystemRequest>(request);
        }
#else
        /// <summary>
        ///  -   删除一个文件系统，一旦删除，该文件系统将不存在，也无法访问已删除的文件系统里的任何内容。
        ///  [MFA enabled]
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteFileSystemResponse> DeleteFileSystem(DeleteFileSystemRequest request) {
            return await new DeleteFileSystemExecutor().Client(this).Execute<DeleteFileSystemResponse, DeleteFileSystemResult, DeleteFileSystemRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改文件系统属性(name 和 description 必须要指定一个)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyFileSystemAttributeResponse ModifyFileSystemAttribute(ModifyFileSystemAttributeRequest request) {
            return  new ModifyFileSystemAttributeExecutor().Client(this).Execute<ModifyFileSystemAttributeResponse, ModifyFileSystemAttributeResult, ModifyFileSystemAttributeRequest>(request);
        }
#else
        /// <summary>
        ///  修改文件系统属性(name 和 description 必须要指定一个)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyFileSystemAttributeResponse> ModifyFileSystemAttribute(ModifyFileSystemAttributeRequest request) {
            return await new ModifyFileSystemAttributeExecutor().Client(this).Execute<ModifyFileSystemAttributeResponse, ModifyFileSystemAttributeResult, ModifyFileSystemAttributeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   查询挂载目标列表。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeMountTargetsResponse DescribeMountTargets(DescribeMountTargetsRequest request) {
            return  new DescribeMountTargetsExecutor().Client(this).Execute<DescribeMountTargetsResponse, DescribeMountTargetsResult, DescribeMountTargetsRequest>(request);
        }
#else
        /// <summary>
        ///  -   查询挂载目标列表。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeMountTargetsResponse> DescribeMountTargets(DescribeMountTargetsRequest request) {
            return await new DescribeMountTargetsExecutor().Client(this).Execute<DescribeMountTargetsResponse, DescribeMountTargetsResult, DescribeMountTargetsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询挂载目标详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeMountTargetResponse DescribeMountTarget(DescribeMountTargetRequest request) {
            return  new DescribeMountTargetExecutor().Client(this).Execute<DescribeMountTargetResponse, DescribeMountTargetResult, DescribeMountTargetRequest>(request);
        }
#else
        /// <summary>
        ///  查询挂载目标详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeMountTargetResponse> DescribeMountTarget(DescribeMountTargetRequest request) {
            return await new DescribeMountTargetExecutor().Client(this).Execute<DescribeMountTargetResponse, DescribeMountTargetResult, DescribeMountTargetRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认ZfsClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>zfsClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>zfsClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>zfsClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造ZfsClient 对象
                ///</summary>
                ZfsClient Build();
            }

            /// <summary>
            ///  默认ZfsClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  ZfsClient service client
                /// </summary>
                private  ZfsClient zfsClient;

                /// <summary>
                ///  默认ZfsClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    zfsClient = new ZfsClient();
                }

                /// <summary>
                ///  构造ZfsClient 对象
                ///</summary>
                public ZfsClient Build()
                {
                    if (zfsClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        zfsClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (zfsClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("ZfsClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (zfsClient.HttpRequestConfig == null)
                    {
                        zfsClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (zfsClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("ZfsClient build error: http request config not set");
                        }
                    }
                    return zfsClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>zfsClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    zfsClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>zfsClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    zfsClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>zfsClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    zfsClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
