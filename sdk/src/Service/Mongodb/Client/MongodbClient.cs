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
 * 京东云数据库MongoDB接口
 * 数据库MongoDB相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Mongodb.Apis;
using JDCloudSDK.Mongodb.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Mongodb.Client
{
    /// <summary>
    ///  京东云数据库MongoDB接口
    ///  数据库MongoDB相关接口
    ///  Mongodb Api 客户端
    ///</summary>
    public class MongodbClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private MongodbClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public MongodbClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public MongodbClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public MongodbClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.0
        ///</summary>
        public const string ClientVersion = "1.2.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "mongodb.jdcloud-api.com";
        private const string serviceName = "mongodb";
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
        ///  内部接口，删除未到期包年包月实例。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeletePrepaidInstanceResponse DeletePrepaidInstance(DeletePrepaidInstanceRequest request) {
            return  new DeletePrepaidInstanceExecutor().Client(this).Execute<DeletePrepaidInstanceResponse, DeletePrepaidInstanceResult, DeletePrepaidInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  内部接口，删除未到期包年包月实例。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeletePrepaidInstanceResponse> DeletePrepaidInstance(DeletePrepaidInstanceRequest request) {
            return await new DeletePrepaidInstanceExecutor().Client(this).Execute<DeletePrepaidInstanceResponse, DeletePrepaidInstanceResult, DeletePrepaidInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  变更实例规格
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyInstanceSpecResponse ModifyInstanceSpec(ModifyInstanceSpecRequest request) {
            return  new ModifyInstanceSpecExecutor().Client(this).Execute<ModifyInstanceSpecResponse, ModifyInstanceSpecResult, ModifyInstanceSpecRequest>(request);
        }
#else
        /// <summary>
        ///  变更实例规格
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpec(ModifyInstanceSpecRequest request) {
            return await new ModifyInstanceSpecExecutor().Client(this).Execute<ModifyInstanceSpecResponse, ModifyInstanceSpecResult, ModifyInstanceSpecRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询实例信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstancesInternalResponse DescribeInstancesInternal(DescribeInstancesInternalRequest request) {
            return  new DescribeInstancesInternalExecutor().Client(this).Execute<DescribeInstancesInternalResponse, DescribeInstancesInternalResult, DescribeInstancesInternalRequest>(request);
        }
#else
        /// <summary>
        ///  查询实例信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstancesInternalResponse> DescribeInstancesInternal(DescribeInstancesInternalRequest request) {
            return await new DescribeInstancesInternalExecutor().Client(this).Execute<DescribeInstancesInternalResponse, DescribeInstancesInternalResult, DescribeInstancesInternalRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询实例访问白名单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSecurityIpsResponse DescribeSecurityIps(DescribeSecurityIpsRequest request) {
            return  new DescribeSecurityIpsExecutor().Client(this).Execute<DescribeSecurityIpsResponse, DescribeSecurityIpsResult, DescribeSecurityIpsRequest>(request);
        }
#else
        /// <summary>
        ///  查询实例访问白名单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSecurityIpsResponse> DescribeSecurityIps(DescribeSecurityIpsRequest request) {
            return await new DescribeSecurityIpsExecutor().Client(this).Execute<DescribeSecurityIpsResponse, DescribeSecurityIpsResult, DescribeSecurityIpsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询实例信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request) {
            return  new DescribeInstancesExecutor().Client(this).Execute<DescribeInstancesResponse, DescribeInstancesResult, DescribeInstancesRequest>(request);
        }
#else
        /// <summary>
        ///  查询实例信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest request) {
            return await new DescribeInstancesExecutor().Client(this).Execute<DescribeInstancesResponse, DescribeInstancesResult, DescribeInstancesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建分片集群
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateShardingInstanceResponse CreateShardingInstance(CreateShardingInstanceRequest request) {
            return  new CreateShardingInstanceExecutor().Client(this).Execute<CreateShardingInstanceResponse, CreateShardingInstanceResult, CreateShardingInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  创建分片集群
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateShardingInstanceResponse> CreateShardingInstance(CreateShardingInstanceRequest request) {
            return await new CreateShardingInstanceExecutor().Client(this).Execute<CreateShardingInstanceResponse, CreateShardingInstanceResult, CreateShardingInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询跨区域备份同步服务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeBackupSynchronicitiesResponse DescribeBackupSynchronicities(DescribeBackupSynchronicitiesRequest request) {
            return  new DescribeBackupSynchronicitiesExecutor().Client(this).Execute<DescribeBackupSynchronicitiesResponse, DescribeBackupSynchronicitiesResult, DescribeBackupSynchronicitiesRequest>(request);
        }
#else
        /// <summary>
        ///  查询跨区域备份同步服务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeBackupSynchronicitiesResponse> DescribeBackupSynchronicities(DescribeBackupSynchronicitiesRequest request) {
            return await new DescribeBackupSynchronicitiesExecutor().Client(this).Execute<DescribeBackupSynchronicitiesResponse, DescribeBackupSynchronicitiesResult, DescribeBackupSynchronicitiesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  重启MongoDB分片集群节点，支持重启Mongos、Shard。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RestartNodeResponse RestartNode(RestartNodeRequest request) {
            return  new RestartNodeExecutor().Client(this).Execute<RestartNodeResponse, RestartNodeResult, RestartNodeRequest>(request);
        }
#else
        /// <summary>
        ///  重启MongoDB分片集群节点，支持重启Mongos、Shard。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RestartNodeResponse> RestartNode(RestartNodeRequest request) {
            return await new RestartNodeExecutor().Client(this).Execute<RestartNodeResponse, RestartNodeResult, RestartNodeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建跨区域备份同步服务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateBackupSynchronicityResponse CreateBackupSynchronicity(CreateBackupSynchronicityRequest request) {
            return  new CreateBackupSynchronicityExecutor().Client(this).Execute<CreateBackupSynchronicityResponse, CreateBackupSynchronicityResult, CreateBackupSynchronicityRequest>(request);
        }
#else
        /// <summary>
        ///  创建跨区域备份同步服务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateBackupSynchronicityResponse> CreateBackupSynchronicity(CreateBackupSynchronicityRequest request) {
            return await new CreateBackupSynchronicityExecutor().Client(this).Execute<CreateBackupSynchronicityResponse, CreateBackupSynchronicityResult, CreateBackupSynchronicityRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取topology结构
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeTopologyResponse DescribeTopology(DescribeTopologyRequest request) {
            return  new DescribeTopologyExecutor().Client(this).Execute<DescribeTopologyResponse, DescribeTopologyResult, DescribeTopologyRequest>(request);
        }
#else
        /// <summary>
        ///  获取topology结构
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeTopologyResponse> DescribeTopology(DescribeTopologyRequest request) {
            return await new DescribeTopologyExecutor().Client(this).Execute<DescribeTopologyResponse, DescribeTopologyResult, DescribeTopologyRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取规格
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeFlavorsResponse DescribeFlavors(DescribeFlavorsRequest request) {
            return  new DescribeFlavorsExecutor().Client(this).Execute<DescribeFlavorsResponse, DescribeFlavorsResult, DescribeFlavorsRequest>(request);
        }
#else
        /// <summary>
        ///  获取规格
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeFlavorsResponse> DescribeFlavors(DescribeFlavorsRequest request) {
            return await new DescribeFlavorsExecutor().Client(this).Execute<DescribeFlavorsResponse, DescribeFlavorsResult, DescribeFlavorsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改实例名称
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyInstanceNameResponse ModifyInstanceName(ModifyInstanceNameRequest request) {
            return  new ModifyInstanceNameExecutor().Client(this).Execute<ModifyInstanceNameResponse, ModifyInstanceNameResult, ModifyInstanceNameRequest>(request);
        }
#else
        /// <summary>
        ///  修改实例名称
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyInstanceNameResponse> ModifyInstanceName(ModifyInstanceNameRequest request) {
            return await new ModifyInstanceNameExecutor().Client(this).Execute<ModifyInstanceNameResponse, ModifyInstanceNameResult, ModifyInstanceNameRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取可用区
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeAvailableZonesResponse DescribeAvailableZones(DescribeAvailableZonesRequest request) {
            return  new DescribeAvailableZonesExecutor().Client(this).Execute<DescribeAvailableZonesResponse, DescribeAvailableZonesResult, DescribeAvailableZonesRequest>(request);
        }
#else
        /// <summary>
        ///  获取可用区
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeAvailableZonesResponse> DescribeAvailableZones(DescribeAvailableZonesRequest request) {
            return await new DescribeAvailableZonesExecutor().Client(this).Execute<DescribeAvailableZonesResponse, DescribeAvailableZonesResult, DescribeAvailableZonesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  资源权限校验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public VerifyInstanceValidationResponse VerifyInstanceValidation(VerifyInstanceValidationRequest request) {
            return  new VerifyInstanceValidationExecutor().Client(this).Execute<VerifyInstanceValidationResponse, VerifyInstanceValidationResult, VerifyInstanceValidationRequest>(request);
        }
#else
        /// <summary>
        ///  资源权限校验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<VerifyInstanceValidationResponse> VerifyInstanceValidation(VerifyInstanceValidationRequest request) {
            return await new VerifyInstanceValidationExecutor().Client(this).Execute<VerifyInstanceValidationResponse, VerifyInstanceValidationResult, VerifyInstanceValidationRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除备份
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteBackupResponse DeleteBackup(DeleteBackupRequest request) {
            return  new DeleteBackupExecutor().Client(this).Execute<DeleteBackupResponse, DeleteBackupResult, DeleteBackupRequest>(request);
        }
#else
        /// <summary>
        ///  删除备份
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteBackupResponse> DeleteBackup(DeleteBackupRequest request) {
            return await new DeleteBackupExecutor().Client(this).Execute<DeleteBackupResponse, DeleteBackupResult, DeleteBackupRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeUserQuotaResponse DescribeUserQuota(DescribeUserQuotaRequest request) {
            return  new DescribeUserQuotaExecutor().Client(this).Execute<DescribeUserQuotaResponse, DescribeUserQuotaResult, DescribeUserQuotaRequest>(request);
        }
#else
        /// <summary>
        ///  获取配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeUserQuotaResponse> DescribeUserQuota(DescribeUserQuotaRequest request) {
            return await new DescribeUserQuotaExecutor().Client(this).Execute<DescribeUserQuotaResponse, DescribeUserQuotaResult, DescribeUserQuotaRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除跨地域备份同步服务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteBackupSynchronicitiesResponse DeleteBackupSynchronicities(DeleteBackupSynchronicitiesRequest request) {
            return  new DeleteBackupSynchronicitiesExecutor().Client(this).Execute<DeleteBackupSynchronicitiesResponse, DeleteBackupSynchronicitiesResult, DeleteBackupSynchronicitiesRequest>(request);
        }
#else
        /// <summary>
        ///  删除跨地域备份同步服务
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteBackupSynchronicitiesResponse> DeleteBackupSynchronicities(DeleteBackupSynchronicitiesRequest request) {
            return await new DeleteBackupSynchronicitiesExecutor().Client(this).Execute<DeleteBackupSynchronicitiesResponse, DeleteBackupSynchronicitiesResult, DeleteBackupSynchronicitiesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  重启实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RestartInstanceResponse RestartInstance(RestartInstanceRequest request) {
            return  new RestartInstanceExecutor().Client(this).Execute<RestartInstanceResponse, RestartInstanceResult, RestartInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  重启实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RestartInstanceResponse> RestartInstance(RestartInstanceRequest request) {
            return await new RestartInstanceExecutor().Client(this).Execute<RestartInstanceResponse, RestartInstanceResult, RestartInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request) {
            return  new CreateInstanceExecutor().Client(this).Execute<CreateInstanceResponse, CreateInstanceResult, CreateInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  创建实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest request) {
            return await new CreateInstanceExecutor().Client(this).Execute<CreateInstanceResponse, CreateInstanceResult, CreateInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  变更分片集群的节点规格，支持Mognos、Shard节点。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyNodeSpecResponse ModifyNodeSpec(ModifyNodeSpecRequest request) {
            return  new ModifyNodeSpecExecutor().Client(this).Execute<ModifyNodeSpecResponse, ModifyNodeSpecResult, ModifyNodeSpecRequest>(request);
        }
#else
        /// <summary>
        ///  变更分片集群的节点规格，支持Mognos、Shard节点。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyNodeSpecResponse> ModifyNodeSpec(ModifyNodeSpecRequest request) {
            return await new ModifyNodeSpecExecutor().Client(this).Execute<ModifyNodeSpecResponse, ModifyNodeSpecResult, ModifyNodeSpecRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取备份策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeBackupPolicyResponse DescribeBackupPolicy(DescribeBackupPolicyRequest request) {
            return  new DescribeBackupPolicyExecutor().Client(this).Execute<DescribeBackupPolicyResponse, DescribeBackupPolicyResult, DescribeBackupPolicyRequest>(request);
        }
#else
        /// <summary>
        ///  获取备份策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeBackupPolicyResponse> DescribeBackupPolicy(DescribeBackupPolicyRequest request) {
            return await new DescribeBackupPolicyExecutor().Client(this).Execute<DescribeBackupPolicyResponse, DescribeBackupPolicyResult, DescribeBackupPolicyRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取备份下载链接
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public BackupDownloadURLResponse BackupDownloadURL(BackupDownloadURLRequest request) {
            return  new BackupDownloadURLExecutor().Client(this).Execute<BackupDownloadURLResponse, BackupDownloadURLResult, BackupDownloadURLRequest>(request);
        }
#else
        /// <summary>
        ///  获取备份下载链接
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<BackupDownloadURLResponse> BackupDownloadURL(BackupDownloadURLRequest request) {
            return await new BackupDownloadURLExecutor().Client(this).Execute<BackupDownloadURLResponse, BackupDownloadURLResult, BackupDownloadURLRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  内部接口，实例欠费或者到期后，关闭实例的网络访问功能。网络访问关闭后，用户无法通过域名连接实例。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DetachNetworkResponse DetachNetwork(DetachNetworkRequest request) {
            return  new DetachNetworkExecutor().Client(this).Execute<DetachNetworkResponse, DetachNetworkResult, DetachNetworkRequest>(request);
        }
#else
        /// <summary>
        ///  内部接口，实例欠费或者到期后，关闭实例的网络访问功能。网络访问关闭后，用户无法通过域名连接实例。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DetachNetworkResponse> DetachNetwork(DetachNetworkRequest request) {
            return await new DetachNetworkExecutor().Client(this).Execute<DetachNetworkResponse, DetachNetworkResult, DetachNetworkRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request) {
            return  new DeleteInstanceExecutor().Client(this).Execute<DeleteInstanceResponse, DeleteInstanceResult, DeleteInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  删除实例
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest request) {
            return await new DeleteInstanceExecutor().Client(this).Execute<DeleteInstanceResponse, DeleteInstanceResult, DeleteInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  数据恢复
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RestoreInstanceResponse RestoreInstance(RestoreInstanceRequest request) {
            return  new RestoreInstanceExecutor().Client(this).Execute<RestoreInstanceResponse, RestoreInstanceResult, RestoreInstanceRequest>(request);
        }
#else
        /// <summary>
        ///  数据恢复
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RestoreInstanceResponse> RestoreInstance(RestoreInstanceRequest request) {
            return await new RestoreInstanceExecutor().Client(this).Execute<RestoreInstanceResponse, RestoreInstanceResult, RestoreInstanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  重置密码
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ResetPasswordResponse ResetPassword(ResetPasswordRequest request) {
            return  new ResetPasswordExecutor().Client(this).Execute<ResetPasswordResponse, ResetPasswordResult, ResetPasswordRequest>(request);
        }
#else
        /// <summary>
        ///  重置密码
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest request) {
            return await new ResetPasswordExecutor().Client(this).Execute<ResetPasswordResponse, ResetPasswordResult, ResetPasswordRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  验证实例规格有效性
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StandardVerifyResponse StandardVerify(StandardVerifyRequest request) {
            return  new StandardVerifyExecutor().Client(this).Execute<StandardVerifyResponse, StandardVerifyResult, StandardVerifyRequest>(request);
        }
#else
        /// <summary>
        ///  验证实例规格有效性
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StandardVerifyResponse> StandardVerify(StandardVerifyRequest request) {
            return await new StandardVerifyExecutor().Client(this).Execute<StandardVerifyResponse, StandardVerifyResult, StandardVerifyRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建备份
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateBackupResponse CreateBackup(CreateBackupRequest request) {
            return  new CreateBackupExecutor().Client(this).Execute<CreateBackupResponse, CreateBackupResult, CreateBackupRequest>(request);
        }
#else
        /// <summary>
        ///  创建备份
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateBackupResponse> CreateBackup(CreateBackupRequest request) {
            return await new CreateBackupExecutor().Client(this).Execute<CreateBackupResponse, CreateBackupResult, CreateBackupRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改备份策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyBackupPolicyResponse ModifyBackupPolicy(ModifyBackupPolicyRequest request) {
            return  new ModifyBackupPolicyExecutor().Client(this).Execute<ModifyBackupPolicyResponse, ModifyBackupPolicyResult, ModifyBackupPolicyRequest>(request);
        }
#else
        /// <summary>
        ///  修改备份策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyBackupPolicyResponse> ModifyBackupPolicy(ModifyBackupPolicyRequest request) {
            return await new ModifyBackupPolicyExecutor().Client(this).Execute<ModifyBackupPolicyResponse, ModifyBackupPolicyResult, ModifyBackupPolicyRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改实例访问白名单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifySecurityIpsResponse ModifySecurityIps(ModifySecurityIpsRequest request) {
            return  new ModifySecurityIpsExecutor().Client(this).Execute<ModifySecurityIpsResponse, ModifySecurityIpsResult, ModifySecurityIpsRequest>(request);
        }
#else
        /// <summary>
        ///  修改实例访问白名单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifySecurityIpsResponse> ModifySecurityIps(ModifySecurityIpsRequest request) {
            return await new ModifySecurityIpsExecutor().Client(this).Execute<ModifySecurityIpsResponse, ModifySecurityIpsResult, ModifySecurityIpsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查看备份
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request) {
            return  new DescribeBackupsExecutor().Client(this).Execute<DescribeBackupsResponse, DescribeBackupsResult, DescribeBackupsRequest>(request);
        }
#else
        /// <summary>
        ///  查看备份
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeBackupsResponse> DescribeBackups(DescribeBackupsRequest request) {
            return await new DescribeBackupsExecutor().Client(this).Execute<DescribeBackupsResponse, DescribeBackupsResult, DescribeBackupsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  内部接口，实例欠费或者到期停服状态下，用户续费后，开启实例的网络访问功能。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AttachNetworkResponse AttachNetwork(AttachNetworkRequest request) {
            return  new AttachNetworkExecutor().Client(this).Execute<AttachNetworkResponse, AttachNetworkResult, AttachNetworkRequest>(request);
        }
#else
        /// <summary>
        ///  内部接口，实例欠费或者到期停服状态下，用户续费后，开启实例的网络访问功能。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AttachNetworkResponse> AttachNetwork(AttachNetworkRequest request) {
            return await new AttachNetworkExecutor().Client(this).Execute<AttachNetworkResponse, AttachNetworkResult, AttachNetworkRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认MongodbClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>mongodbClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>mongodbClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>mongodbClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造MongodbClient 对象
                ///</summary>
                MongodbClient Build();
            }

            /// <summary>
            ///  默认MongodbClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  MongodbClient service client
                /// </summary>
                private  MongodbClient mongodbClient;

                /// <summary>
                ///  默认MongodbClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    mongodbClient = new MongodbClient();
                }

                /// <summary>
                ///  构造MongodbClient 对象
                ///</summary>
                public MongodbClient Build()
                {
                    if (mongodbClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        mongodbClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (mongodbClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("MongodbClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (mongodbClient.HttpRequestConfig == null)
                    {
                        mongodbClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (mongodbClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("MongodbClient build error: http request config not set");
                        }
                    }
                    return mongodbClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>mongodbClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    mongodbClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>mongodbClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    mongodbClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>mongodbClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    mongodbClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
