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
 * 云硬盘API
 * 云硬盘API包含云硬盘相关接口和快照相关接口。可提供批量创建云硬盘，删除云硬盘，制作云硬盘快照等功能。
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Disk.Apis;
using JDCloudSDK.Disk.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Disk.Client
{
    /// <summary>
    ///  云硬盘API
    ///  云硬盘API包含云硬盘相关接口和快照相关接口。可提供批量创建云硬盘，删除云硬盘，制作云硬盘快照等功能。
    ///  Disk Api 客户端
    ///</summary>
    public class DiskClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private DiskClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public DiskClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public DiskClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public DiskClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.8
        ///</summary>
        public const string ClientVersion = "1.2.8";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "disk.jdcloud-api.com";
        private const string serviceName = "disk";
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
        ///  查询某一块云硬盘的信息详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeDiskResponse DescribeDisk(DescribeDiskRequest request) {
            return  new DescribeDiskExecutor().Client(this).Execute<DescribeDiskResponse, DescribeDiskResult, DescribeDiskRequest>(request);
        }
#else
        /// <summary>
        ///  查询某一块云硬盘的信息详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeDiskResponse> DescribeDisk(DescribeDiskRequest request) {
            return await new DescribeDiskExecutor().Client(this).Execute<DescribeDiskResponse, DescribeDiskResult, DescribeDiskRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   查询您已经创建的云硬盘。
        /// -   filters多个过滤条件之间是逻辑与(AND)，每个条件内部的多个取值是逻辑或(OR)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeVolumesIgnoreServiceCodeResponse DescribeVolumesIgnoreServiceCode(DescribeVolumesIgnoreServiceCodeRequest request) {
            return  new DescribeVolumesIgnoreServiceCodeExecutor().Client(this).Execute<DescribeVolumesIgnoreServiceCodeResponse, DescribeVolumesIgnoreServiceCodeResult, DescribeVolumesIgnoreServiceCodeRequest>(request);
        }
#else
        /// <summary>
        ///  -   查询您已经创建的云硬盘。
        /// -   filters多个过滤条件之间是逻辑与(AND)，每个条件内部的多个取值是逻辑或(OR)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeVolumesIgnoreServiceCodeResponse> DescribeVolumesIgnoreServiceCode(DescribeVolumesIgnoreServiceCodeRequest request) {
            return await new DescribeVolumesIgnoreServiceCodeExecutor().Client(this).Execute<DescribeVolumesIgnoreServiceCodeResponse, DescribeVolumesIgnoreServiceCodeResult, DescribeVolumesIgnoreServiceCodeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改云硬盘的名字或描述信息，名字或描述信息至少要指定一个。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyDiskAttributeResponse ModifyDiskAttribute(ModifyDiskAttributeRequest request) {
            return  new ModifyDiskAttributeExecutor().Client(this).Execute<ModifyDiskAttributeResponse, ModifyDiskAttributeResult, ModifyDiskAttributeRequest>(request);
        }
#else
        /// <summary>
        ///  修改云硬盘的名字或描述信息，名字或描述信息至少要指定一个。
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyDiskAttributeResponse> ModifyDiskAttribute(ModifyDiskAttributeRequest request) {
            return await new ModifyDiskAttributeExecutor().Client(this).Execute<ModifyDiskAttributeResponse, ModifyDiskAttributeResult, ModifyDiskAttributeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  绑定/解绑快照策略与磁盘关系
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ApplySnapshotPoliciesResponse ApplySnapshotPolicies(ApplySnapshotPoliciesRequest request) {
            return  new ApplySnapshotPoliciesExecutor().Client(this).Execute<ApplySnapshotPoliciesResponse, ApplySnapshotPoliciesResult, ApplySnapshotPoliciesRequest>(request);
        }
#else
        /// <summary>
        ///  绑定/解绑快照策略与磁盘关系
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ApplySnapshotPoliciesResponse> ApplySnapshotPolicies(ApplySnapshotPoliciesRequest request) {
            return await new ApplySnapshotPoliciesExecutor().Client(this).Execute<ApplySnapshotPoliciesResponse, ApplySnapshotPoliciesResult, ApplySnapshotPoliciesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询快照容量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSnapshotsCapacityResponse DescribeSnapshotsCapacity(DescribeSnapshotsCapacityRequest request) {
            return  new DescribeSnapshotsCapacityExecutor().Client(this).Execute<DescribeSnapshotsCapacityResponse, DescribeSnapshotsCapacityResult, DescribeSnapshotsCapacityRequest>(request);
        }
#else
        /// <summary>
        ///  查询快照容量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSnapshotsCapacityResponse> DescribeSnapshotsCapacity(DescribeSnapshotsCapacityRequest request) {
            return await new DescribeSnapshotsCapacityExecutor().Client(this).Execute<DescribeSnapshotsCapacityResponse, DescribeSnapshotsCapacityResult, DescribeSnapshotsCapacityRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询云硬盘售罄情况列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSoldoutResponse DescribeSoldout(DescribeSoldoutRequest request) {
            return  new DescribeSoldoutExecutor().Client(this).Execute<DescribeSoldoutResponse, DescribeSoldoutResult, DescribeSoldoutRequest>(request);
        }
#else
        /// <summary>
        ///  查询云硬盘售罄情况列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSoldoutResponse> DescribeSoldout(DescribeSoldoutRequest request) {
            return await new DescribeSoldoutExecutor().Client(this).Execute<DescribeSoldoutResponse, DescribeSoldoutResult, DescribeSoldoutRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   创建一块或多块按配置或者按使用时长付费的云硬盘。
        /// -   云硬盘类型包括高效云盘(premium-hdd)、SSD云盘(ssd)、通用型SSD(ssd.gp1)、性能型SSD(ssd.io1)、容量型HDD(hdd.std1)。
        /// -   计费方式默认为按配置付费。
        /// -   创建完成后，云硬盘状态为 available。
        /// -   可选参数快照 ID用于从快照创建新盘。
        /// -   批量创建时，云硬盘的命名为 硬盘名称-数字，例如 myDisk-1，myDisk-2。
        /// -   maxCount为最大努力，不保证一定能达到maxCount。
        /// -   userTags 为创建云盘时打的标签
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateDisksResponse CreateDisks(CreateDisksRequest request) {
            return  new CreateDisksExecutor().Client(this).Execute<CreateDisksResponse, CreateDisksResult, CreateDisksRequest>(request);
        }
#else
        /// <summary>
        ///  -   创建一块或多块按配置或者按使用时长付费的云硬盘。
        /// -   云硬盘类型包括高效云盘(premium-hdd)、SSD云盘(ssd)、通用型SSD(ssd.gp1)、性能型SSD(ssd.io1)、容量型HDD(hdd.std1)。
        /// -   计费方式默认为按配置付费。
        /// -   创建完成后，云硬盘状态为 available。
        /// -   可选参数快照 ID用于从快照创建新盘。
        /// -   批量创建时，云硬盘的命名为 硬盘名称-数字，例如 myDisk-1，myDisk-2。
        /// -   maxCount为最大努力，不保证一定能达到maxCount。
        /// -   userTags 为创建云盘时打的标签
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateDisksResponse> CreateDisks(CreateDisksRequest request) {
            return await new CreateDisksExecutor().Client(this).Execute<CreateDisksResponse, CreateDisksResult, CreateDisksRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   仅可对制作快照的源硬盘进行数据恢复操作。
        /// -   仅源硬盘处于可用状态时才能使用快照进行数据恢复操作。
        /// -   云硬盘恢复后，当前数据将被清除，请您谨慎操作。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RestoreDiskResponse RestoreDisk(RestoreDiskRequest request) {
            return  new RestoreDiskExecutor().Client(this).Execute<RestoreDiskResponse, RestoreDiskResult, RestoreDiskRequest>(request);
        }
#else
        /// <summary>
        ///  -   仅可对制作快照的源硬盘进行数据恢复操作。
        /// -   仅源硬盘处于可用状态时才能使用快照进行数据恢复操作。
        /// -   云硬盘恢复后，当前数据将被清除，请您谨慎操作。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RestoreDiskResponse> RestoreDisk(RestoreDiskRequest request) {
            return await new RestoreDiskExecutor().Client(this).Execute<RestoreDiskResponse, RestoreDiskResult, RestoreDiskRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询快照策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSnapshotPoliciesResponse DescribeSnapshotPolicies(DescribeSnapshotPoliciesRequest request) {
            return  new DescribeSnapshotPoliciesExecutor().Client(this).Execute<DescribeSnapshotPoliciesResponse, DescribeSnapshotPoliciesResult, DescribeSnapshotPoliciesRequest>(request);
        }
#else
        /// <summary>
        ///  查询快照策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSnapshotPoliciesResponse> DescribeSnapshotPolicies(DescribeSnapshotPoliciesRequest request) {
            return await new DescribeSnapshotPoliciesExecutor().Client(this).Execute<DescribeSnapshotPoliciesResponse, DescribeSnapshotPoliciesResult, DescribeSnapshotPoliciesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   删除一块按配置计费的云硬盘，云盘类型包括高效云盘、SSD云盘、通用型SSD、性能型SSD和容量型HDD。
        /// -   删除云盘时，云盘的状态必须为 待挂载（Available）。
        /// -   云盘被删除后，云硬盘快照可以被保留。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteDiskResponse DeleteDisk(DeleteDiskRequest request) {
            return  new DeleteDiskExecutor().Client(this).Execute<DeleteDiskResponse, DeleteDiskResult, DeleteDiskRequest>(request);
        }
#else
        /// <summary>
        ///  -   删除一块按配置计费的云硬盘，云盘类型包括高效云盘、SSD云盘、通用型SSD、性能型SSD和容量型HDD。
        /// -   删除云盘时，云盘的状态必须为 待挂载（Available）。
        /// -   云盘被删除后，云硬盘快照可以被保留。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteDiskResponse> DeleteDisk(DeleteDiskRequest request) {
            return await new DeleteDiskExecutor().Client(this).Execute<DeleteDiskResponse, DeleteDiskResult, DeleteDiskRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   为指定云硬盘创建快照，新生成的快照的状态为creating。
        /// -   同一地域下单用户快照的配额为15块。
        /// -   为保证数据完整性，请您在创建快照之前，停止对云硬盘进行写入操作，以保证快照数据的完整性。
        /// -   在执行创建快照前，建议您对云硬盘进行卸载操作，创建快照后再重新挂载到云主机上。
        /// -   手动快照的生命周期独立于云硬盘，请您及时删除不需要的快照。
        /// -   创建快照所需时间取决于云硬盘容量的大小，云硬盘容量越大耗时越长。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request) {
            return  new CreateSnapshotExecutor().Client(this).Execute<CreateSnapshotResponse, CreateSnapshotResult, CreateSnapshotRequest>(request);
        }
#else
        /// <summary>
        ///  -   为指定云硬盘创建快照，新生成的快照的状态为creating。
        /// -   同一地域下单用户快照的配额为15块。
        /// -   为保证数据完整性，请您在创建快照之前，停止对云硬盘进行写入操作，以保证快照数据的完整性。
        /// -   在执行创建快照前，建议您对云硬盘进行卸载操作，创建快照后再重新挂载到云主机上。
        /// -   手动快照的生命周期独立于云硬盘，请您及时删除不需要的快照。
        /// -   创建快照所需时间取决于云硬盘容量的大小，云硬盘容量越大耗时越长。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateSnapshotResponse> CreateSnapshot(CreateSnapshotRequest request) {
            return await new CreateSnapshotExecutor().Client(this).Execute<CreateSnapshotResponse, CreateSnapshotResult, CreateSnapshotRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   查询您已经创建的快照策略。
        /// -   filters多个过滤条件之间是逻辑与(AND)，每个条件内部的多个取值是逻辑或(OR)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSnapPolicesResponse DescribeSnapPolices(DescribeSnapPolicesRequest request) {
            return  new DescribeSnapPolicesExecutor().Client(this).Execute<DescribeSnapPolicesResponse, DescribeSnapPolicesResult, DescribeSnapPolicesRequest>(request);
        }
#else
        /// <summary>
        ///  -   查询您已经创建的快照策略。
        /// -   filters多个过滤条件之间是逻辑与(AND)，每个条件内部的多个取值是逻辑或(OR)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSnapPolicesResponse> DescribeSnapPolices(DescribeSnapPolicesRequest request) {
            return await new DescribeSnapPolicesExecutor().Client(this).Execute<DescribeSnapPolicesResponse, DescribeSnapPolicesResult, DescribeSnapPolicesRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改快照的名字或描述信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request) {
            return  new ModifySnapshotAttributeExecutor().Client(this).Execute<ModifySnapshotAttributeResponse, ModifySnapshotAttributeResult, ModifySnapshotAttributeRequest>(request);
        }
#else
        /// <summary>
        ///  修改快照的名字或描述信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifySnapshotAttributeResponse> ModifySnapshotAttribute(ModifySnapshotAttributeRequest request) {
            return await new ModifySnapshotAttributeExecutor().Client(this).Execute<ModifySnapshotAttributeResponse, ModifySnapshotAttributeResult, ModifySnapshotAttributeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   删除云硬盘快照:快照状态必须为 available 或 error 状态。
        /// -   快照独立于云硬盘生命周期，删除快照不会对创建快照的云硬盘有任何影响。
        /// -   快照删除后不可恢复，请谨慎操作。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteSnapshotsResponse DeleteSnapshots(DeleteSnapshotsRequest request) {
            return  new DeleteSnapshotsExecutor().Client(this).Execute<DeleteSnapshotsResponse, DeleteSnapshotsResult, DeleteSnapshotsRequest>(request);
        }
#else
        /// <summary>
        ///  -   删除云硬盘快照:快照状态必须为 available 或 error 状态。
        /// -   快照独立于云硬盘生命周期，删除快照不会对创建快照的云硬盘有任何影响。
        /// -   快照删除后不可恢复，请谨慎操作。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteSnapshotsResponse> DeleteSnapshots(DeleteSnapshotsRequest request) {
            return await new DeleteSnapshotsExecutor().Client(this).Execute<DeleteSnapshotsResponse, DeleteSnapshotsResult, DeleteSnapshotsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改快照策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UpdateSnapshotPolicyResponse UpdateSnapshotPolicy(UpdateSnapshotPolicyRequest request) {
            return  new UpdateSnapshotPolicyExecutor().Client(this).Execute<UpdateSnapshotPolicyResponse, UpdateSnapshotPolicyResult, UpdateSnapshotPolicyRequest>(request);
        }
#else
        /// <summary>
        ///  修改快照策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UpdateSnapshotPolicyResponse> UpdateSnapshotPolicy(UpdateSnapshotPolicyRequest request) {
            return await new UpdateSnapshotPolicyExecutor().Client(this).Execute<UpdateSnapshotPolicyResponse, UpdateSnapshotPolicyResult, UpdateSnapshotPolicyRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询快照链的快照个数和快照总容量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSnapshotChainResponse DescribeSnapshotChain(DescribeSnapshotChainRequest request) {
            return  new DescribeSnapshotChainExecutor().Client(this).Execute<DescribeSnapshotChainResponse, DescribeSnapshotChainResult, DescribeSnapshotChainRequest>(request);
        }
#else
        /// <summary>
        ///  查询快照链的快照个数和快照总容量
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSnapshotChainResponse> DescribeSnapshotChain(DescribeSnapshotChainRequest request) {
            return await new DescribeSnapshotChainExecutor().Client(this).Execute<DescribeSnapshotChainResponse, DescribeSnapshotChainResult, DescribeSnapshotChainRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询快照策略与磁盘绑定关系
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSnapshotPolicyDiskRelationsResponse DescribeSnapshotPolicyDiskRelations(DescribeSnapshotPolicyDiskRelationsRequest request) {
            return  new DescribeSnapshotPolicyDiskRelationsExecutor().Client(this).Execute<DescribeSnapshotPolicyDiskRelationsResponse, DescribeSnapshotPolicyDiskRelationsResult, DescribeSnapshotPolicyDiskRelationsRequest>(request);
        }
#else
        /// <summary>
        ///  查询快照策略与磁盘绑定关系
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSnapshotPolicyDiskRelationsResponse> DescribeSnapshotPolicyDiskRelations(DescribeSnapshotPolicyDiskRelationsRequest request) {
            return await new DescribeSnapshotPolicyDiskRelationsExecutor().Client(this).Execute<DescribeSnapshotPolicyDiskRelationsResponse, DescribeSnapshotPolicyDiskRelationsResult, DescribeSnapshotPolicyDiskRelationsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除快照策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteSnapshotPolicyResponse DeleteSnapshotPolicy(DeleteSnapshotPolicyRequest request) {
            return  new DeleteSnapshotPolicyExecutor().Client(this).Execute<DeleteSnapshotPolicyResponse, DeleteSnapshotPolicyResult, DeleteSnapshotPolicyRequest>(request);
        }
#else
        /// <summary>
        ///  删除快照策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteSnapshotPolicyResponse> DeleteSnapshotPolicy(DeleteSnapshotPolicyRequest request) {
            return await new DeleteSnapshotPolicyExecutor().Client(this).Execute<DeleteSnapshotPolicyResponse, DeleteSnapshotPolicyResult, DeleteSnapshotPolicyRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   扩容云硬盘到指定大小，云硬盘状态必须为 available。
        /// -   当云硬盘正在创建快照时，不允许扩容。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ExtendDiskResponse ExtendDisk(ExtendDiskRequest request) {
            return  new ExtendDiskExecutor().Client(this).Execute<ExtendDiskResponse, ExtendDiskResult, ExtendDiskRequest>(request);
        }
#else
        /// <summary>
        ///  -   扩容云硬盘到指定大小，云硬盘状态必须为 available。
        /// -   当云硬盘正在创建快照时，不允许扩容。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ExtendDiskResponse> ExtendDisk(ExtendDiskRequest request) {
            return await new ExtendDiskExecutor().Client(this).Execute<ExtendDiskResponse, ExtendDiskResult, ExtendDiskRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   删除单个云硬盘快照:快照状态必须为 available 或 error 状态。
        /// -   快照独立于云硬盘生命周期，删除快照不会对创建快照的云硬盘有任何影响。
        /// -   快照删除后不可恢复，请谨慎操作。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request) {
            return  new DeleteSnapshotExecutor().Client(this).Execute<DeleteSnapshotResponse, DeleteSnapshotResult, DeleteSnapshotRequest>(request);
        }
#else
        /// <summary>
        ///  -   删除单个云硬盘快照:快照状态必须为 available 或 error 状态。
        /// -   快照独立于云硬盘生命周期，删除快照不会对创建快照的云硬盘有任何影响。
        /// -   快照删除后不可恢复，请谨慎操作。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteSnapshotResponse> DeleteSnapshot(DeleteSnapshotRequest request) {
            return await new DeleteSnapshotExecutor().Client(this).Execute<DeleteSnapshotResponse, DeleteSnapshotResult, DeleteSnapshotRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询云硬盘快照列表，filters多个过滤条件之间是逻辑与(AND)，每个条件内部的多个取值是逻辑或(OR)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request) {
            return  new DescribeSnapshotsExecutor().Client(this).Execute<DescribeSnapshotsResponse, DescribeSnapshotsResult, DescribeSnapshotsRequest>(request);
        }
#else
        /// <summary>
        ///  查询云硬盘快照列表，filters多个过滤条件之间是逻辑与(AND)，每个条件内部的多个取值是逻辑或(OR)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSnapshotsResponse> DescribeSnapshots(DescribeSnapshotsRequest request) {
            return await new DescribeSnapshotsExecutor().Client(this).Execute<DescribeSnapshotsResponse, DescribeSnapshotsResult, DescribeSnapshotsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建快照策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateSnapshotPolicyResponse CreateSnapshotPolicy(CreateSnapshotPolicyRequest request) {
            return  new CreateSnapshotPolicyExecutor().Client(this).Execute<CreateSnapshotPolicyResponse, CreateSnapshotPolicyResult, CreateSnapshotPolicyRequest>(request);
        }
#else
        /// <summary>
        ///  创建快照策略
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateSnapshotPolicyResponse> CreateSnapshotPolicy(CreateSnapshotPolicyRequest request) {
            return await new CreateSnapshotPolicyExecutor().Client(this).Execute<CreateSnapshotPolicyResponse, CreateSnapshotPolicyResult, CreateSnapshotPolicyRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  -   查询您已经创建的云硬盘。
        /// -   filters多个过滤条件之间是逻辑与(AND)，每个条件内部的多个取值是逻辑或(OR)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeDisksResponse DescribeDisks(DescribeDisksRequest request) {
            return  new DescribeDisksExecutor().Client(this).Execute<DescribeDisksResponse, DescribeDisksResult, DescribeDisksRequest>(request);
        }
#else
        /// <summary>
        ///  -   查询您已经创建的云硬盘。
        /// -   filters多个过滤条件之间是逻辑与(AND)，每个条件内部的多个取值是逻辑或(OR)
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeDisksResponse> DescribeDisks(DescribeDisksRequest request) {
            return await new DescribeDisksExecutor().Client(this).Execute<DescribeDisksResponse, DescribeDisksResult, DescribeDisksRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询云硬盘快照信息详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSnapshotResponse DescribeSnapshot(DescribeSnapshotRequest request) {
            return  new DescribeSnapshotExecutor().Client(this).Execute<DescribeSnapshotResponse, DescribeSnapshotResult, DescribeSnapshotRequest>(request);
        }
#else
        /// <summary>
        ///  查询云硬盘快照信息详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSnapshotResponse> DescribeSnapshot(DescribeSnapshotRequest request) {
            return await new DescribeSnapshotExecutor().Client(this).Execute<DescribeSnapshotResponse, DescribeSnapshotResult, DescribeSnapshotRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询云硬盘和快照资源的配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeQuotaResponse DescribeQuota(DescribeQuotaRequest request) {
            return  new DescribeQuotaExecutor().Client(this).Execute<DescribeQuotaResponse, DescribeQuotaResult, DescribeQuotaRequest>(request);
        }
#else
        /// <summary>
        ///  查询云硬盘和快照资源的配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeQuotaResponse> DescribeQuota(DescribeQuotaRequest request) {
            return await new DescribeQuotaExecutor().Client(this).Execute<DescribeQuotaResponse, DescribeQuotaResult, DescribeQuotaRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认DiskClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>diskClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>diskClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>diskClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造DiskClient 对象
                ///</summary>
                DiskClient Build();
            }

            /// <summary>
            ///  默认DiskClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  DiskClient service client
                /// </summary>
                private  DiskClient diskClient;

                /// <summary>
                ///  默认DiskClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    diskClient = new DiskClient();
                }

                /// <summary>
                ///  构造DiskClient 对象
                ///</summary>
                public DiskClient Build()
                {
                    if (diskClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        diskClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (diskClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("DiskClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (diskClient.HttpRequestConfig == null)
                    {
                        diskClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (diskClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("DiskClient build error: http request config not set");
                        }
                    }
                    return diskClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>diskClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    diskClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>diskClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    diskClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>diskClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    diskClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
