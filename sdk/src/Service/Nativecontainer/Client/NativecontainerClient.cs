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
 * 原生容器
 * 原生容器相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Nativecontainer.Apis;
using JDCloudSDK.Nativecontainer.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Nativecontainer.Client
{
    /// <summary>
    ///  原生容器
    ///  原生容器相关接口
    ///  Nativecontainer Api 客户端
    ///</summary>
    public class NativecontainerClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private NativecontainerClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public NativecontainerClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public NativecontainerClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public NativecontainerClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.9
        ///</summary>
        public const string ClientVersion = "1.0.9";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "nativecontainer.jdcloud-api.com";
        private const string serviceName = "nativecontainer";
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
        ///  创建一个 secret，用于存放镜像仓库机密相关信息。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateSecretResponse CreateSecret(CreateSecretRequest request) {
            return  new CreateSecretExecutor().Client(this).Execute<CreateSecretResponse, CreateSecretResult, CreateSecretRequest>(request);
        }
#else
        /// <summary>
        ///  创建一个 secret，用于存放镜像仓库机密相关信息。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateSecretResponse> CreateSecret(CreateSecretRequest request) {
            return await new CreateSecretExecutor().Client(this).Execute<CreateSecretResponse, CreateSecretResult, CreateSecretRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除单个 secret
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteSecretResponse DeleteSecret(DeleteSecretRequest request) {
            return  new DeleteSecretExecutor().Client(this).Execute<DeleteSecretResponse, DeleteSecretResult, DeleteSecretRequest>(request);
        }
#else
        /// <summary>
        ///  删除单个 secret
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteSecretResponse> DeleteSecret(DeleteSecretRequest request) {
            return await new DeleteSecretExecutor().Client(this).Execute<DeleteSecretResponse, DeleteSecretResult, DeleteSecretRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询一台原生容器的详细信息
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeContainerResponse DescribeContainer(DescribeContainerRequest request) {
            return  new DescribeContainerExecutor().Client(this).Execute<DescribeContainerResponse, DescribeContainerResult, DescribeContainerRequest>(request);
        }
#else
        /// <summary>
        ///  查询一台原生容器的详细信息
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeContainerResponse> DescribeContainer(DescribeContainerRequest request) {
            return await new DescribeContainerExecutor().Client(this).Execute<DescribeContainerResponse, DescribeContainerResult, DescribeContainerRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  容器状态必须为 stopped、running 或 error状态。 &lt;br&gt;
        /// 按量付费的实例，如不主动删除将一直运行，不再使用的实例，可通过本接口主动停用。&lt;br&gt;
        /// 只能支持主动删除按量计费类型的实例。包年包月过期的容器也可以删除，其它的情况还请发工单系统。计费状态异常的容器无法删除。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteContainerResponse DeleteContainer(DeleteContainerRequest request) {
            return  new DeleteContainerExecutor().Client(this).Execute<DeleteContainerResponse, DeleteContainerResult, DeleteContainerRequest>(request);
        }
#else
        /// <summary>
        ///  容器状态必须为 stopped、running 或 error状态。 &lt;br&gt;
        /// 按量付费的实例，如不主动删除将一直运行，不再使用的实例，可通过本接口主动停用。&lt;br&gt;
        /// 只能支持主动删除按量计费类型的实例。包年包月过期的容器也可以删除，其它的情况还请发工单系统。计费状态异常的容器无法删除。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteContainerResponse> DeleteContainer(DeleteContainerRequest request) {
            return await new DeleteContainerExecutor().Client(this).Execute<DeleteContainerResponse, DeleteContainerResult, DeleteContainerRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询资源的配额，支持：原生容器 pod 和 secret.
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeQuotaResponse DescribeQuota(DescribeQuotaRequest request) {
            return  new DescribeQuotaExecutor().Client(this).Execute<DescribeQuotaResponse, DescribeQuotaResult, DescribeQuotaRequest>(request);
        }
#else
        /// <summary>
        ///  查询资源的配额，支持：原生容器 pod 和 secret.
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeQuotaResponse> DescribeQuota(DescribeQuotaRequest request) {
            return await new DescribeQuotaExecutor().Client(this).Execute<DescribeQuotaResponse, DescribeQuotaResult, DescribeQuotaRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询单个 secret 详情
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSecretResponse DescribeSecret(DescribeSecretRequest request) {
            return  new DescribeSecretExecutor().Client(this).Execute<DescribeSecretResponse, DescribeSecretResult, DescribeSecretRequest>(request);
        }
#else
        /// <summary>
        ///  查询单个 secret 详情
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSecretResponse> DescribeSecret(DescribeSecretRequest request) {
            return await new DescribeSecretExecutor().Client(this).Execute<DescribeSecretResponse, DescribeSecretResult, DescribeSecretRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  停止处于运行状态的单个实例，处于任务执行中的容器无法启动。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StopContainerResponse StopContainer(StopContainerRequest request) {
            return  new StopContainerExecutor().Client(this).Execute<StopContainerResponse, StopContainerResult, StopContainerRequest>(request);
        }
#else
        /// <summary>
        ///  停止处于运行状态的单个实例，处于任务执行中的容器无法启动。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StopContainerResponse> StopContainer(StopContainerRequest request) {
            return await new StopContainerExecutor().Client(this).Execute<StopContainerResponse, StopContainerResult, StopContainerRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  容器解绑公网 IP，解绑的是主网卡、主内网 IP 对应的弹性 IP.
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request) {
            return  new DisassociateElasticIpExecutor().Client(this).Execute<DisassociateElasticIpResponse, DisassociateElasticIpResult, DisassociateElasticIpRequest>(request);
        }
#else
        /// <summary>
        ///  容器解绑公网 IP，解绑的是主网卡、主内网 IP 对应的弹性 IP.
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DisassociateElasticIpResponse> DisassociateElasticIp(DisassociateElasticIpRequest request) {
            return await new DisassociateElasticIpExecutor().Client(this).Execute<DisassociateElasticIpResponse, DisassociateElasticIpResult, DisassociateElasticIpRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询单个容器日志
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetLogsResponse GetLogs(GetLogsRequest request) {
            return  new GetLogsExecutor().Client(this).Execute<GetLogsResponse, GetLogsResult, GetLogsRequest>(request);
        }
#else
        /// <summary>
        ///  查询单个容器日志
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetLogsResponse> GetLogs(GetLogsRequest request) {
            return await new GetLogsExecutor().Client(this).Execute<GetLogsResponse, GetLogsResult, GetLogsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  重置原生容器，对已有原生容器使用新的镜像重置。
        /// 原容器 id 不变，不涉及计费变动，暂不支持修改实例类型，不会改变原生容器所在的物理节点，也不支持修改已经使用的系统盘和数据盘以及网络相关参数。
        /// - 镜像
        ///     - 容器的镜像通过镜像名称来确定
        ///     - nginx:tag 或 mysql/mysql-server:tag 这样命名的镜像表示 docker hub 官方镜像
        ///     - container-registry/image:tag 这样命名的镜像表示私有仓储的镜像
        ///     - 私有仓储必须兼容 docker registry 认证机制，并通过 secret 来保存机密信息
        /// - 其他
        ///     - rebuild 之前容器必须处于关闭状态
        ///     - rebuild 完成后，容器仍为关闭状态
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RebuildContainerResponse RebuildContainer(RebuildContainerRequest request) {
            return  new RebuildContainerExecutor().Client(this).Execute<RebuildContainerResponse, RebuildContainerResult, RebuildContainerRequest>(request);
        }
#else
        /// <summary>
        ///  重置原生容器，对已有原生容器使用新的镜像重置。
        /// 原容器 id 不变，不涉及计费变动，暂不支持修改实例类型，不会改变原生容器所在的物理节点，也不支持修改已经使用的系统盘和数据盘以及网络相关参数。
        /// - 镜像
        ///     - 容器的镜像通过镜像名称来确定
        ///     - nginx:tag 或 mysql/mysql-server:tag 这样命名的镜像表示 docker hub 官方镜像
        ///     - container-registry/image:tag 这样命名的镜像表示私有仓储的镜像
        ///     - 私有仓储必须兼容 docker registry 认证机制，并通过 secret 来保存机密信息
        /// - 其他
        ///     - rebuild 之前容器必须处于关闭状态
        ///     - rebuild 完成后，容器仍为关闭状态
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RebuildContainerResponse> RebuildContainer(RebuildContainerRequest request) {
            return await new RebuildContainerExecutor().Client(this).Execute<RebuildContainerResponse, RebuildContainerResult, RebuildContainerRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  容器绑定弹性公网 IP，绑定的是主网卡、主内网IP对应的弹性IP. &lt;br&gt;
        /// 一台云主机只能绑定一个弹性公网 IP(主网卡)，若主网卡已存在弹性公网IP，会返回错误。&lt;br&gt;
        /// 如果是黑名单中的用户，会返回错误。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request) {
            return  new AssociateElasticIpExecutor().Client(this).Execute<AssociateElasticIpResponse, AssociateElasticIpResult, AssociateElasticIpRequest>(request);
        }
#else
        /// <summary>
        ///  容器绑定弹性公网 IP，绑定的是主网卡、主内网IP对应的弹性IP. &lt;br&gt;
        /// 一台云主机只能绑定一个弹性公网 IP(主网卡)，若主网卡已存在弹性公网IP，会返回错误。&lt;br&gt;
        /// 如果是黑名单中的用户，会返回错误。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AssociateElasticIpResponse> AssociateElasticIp(AssociateElasticIpRequest request) {
            return await new AssociateElasticIpExecutor().Client(this).Execute<AssociateElasticIpResponse, AssociateElasticIpResult, AssociateElasticIpRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建一台或多台指定配置容器。
        /// - 创建容器需要通过实名认证
        /// - 镜像
        ///     - 容器的镜像通过镜像名称来确定
        ///     - nginx:tag 或 mysql/mysql-server:tag 这样命名的镜像表示 docker hub 官方镜像
        ///     - container-registry/image:tag 这样命名的镜像表示私有仓储的镜像
        ///     - 私有仓储必须兼容 docker registry 认证机制，并通过 secret 来保存机密信息
        /// - hostname 规范
        ///     - 支持两种方式：以标签方式书写或以完整主机名方式书写
        ///     - 标签规范
        ///         - 0-9，a-z(不分大小写)和 -（减号），其他的都是无效的字符串
        ///         - 不能以减号开始，也不能以减号结尾
        ///         - 最小1个字符，最大63个字符
        ///     - 完整的主机名由一系列标签与点连接组成
        ///         - 标签与标签之间使用“.”(点)进行连接
        ///         - 不能以“.”(点)开始，也不能以“.”(点)结尾
        ///         - 整个主机名（包括标签以及分隔点“.”）最多有63个ASCII字符
        /// - 网络配置
        ///     - 指定主网卡配置信息
        ///         - 必须指定一个子网
        ///         - 一台云主机创建时必须指定一个安全组，至多指定 5 个安全组
        ///         - 可以指定 elasticIp 规格来约束创建的弹性 IP，带宽取值范围 [1-200]Mbps，步进 1Mbps
        ///         - 可以指定网卡的主 IP(primaryIpAddress)，该 IP 需要在子网 IP 范围内且未被占用，指定子网 IP 时 maxCount 只能为1
        ///         - 安全组 securityGroup 需与子网 Subnet 在同一个私有网络 VPC 内
        ///         - 主网卡 deviceIndex 设置为 1
        /// - 存储
        ///     - volume 分为 root volume 和 data volume，root volume 的挂载目录是 /，data volume 的挂载目录可以随意指定
        ///     - volume 的底层存储介质当前只支持 cloud 类别，也就是云硬盘
        ///     - 系统盘
        ///         - 云硬盘类型可以选择 ssd、premium-hdd
        ///         - 磁盘大小
        ///             - ssd：范围 [10, 100]GB，步长为 10G
        ///             - premium-hdd：范围 [20, 1000]GB，步长为 10G
        ///         - 自动删除
        ///             - 云盘默认跟随容器实例自动删除，如果是包年包月的数据盘或共享型数据盘，此参数不生效
        ///         - 可以选择已存在的云硬盘
        ///     - 数据盘
        ///         - 云硬盘类型可以选择 ssd、premium-hdd
        ///         - 磁盘大小
        ///             - ssd：范围[20,1000]GB，步长为10G
        ///             - premium-hdd：范围[20,3000]GB，步长为10G
        ///         - 自动删除
        ///             - 默认自动删除
        ///         - 可以选择已存在的云硬盘
        ///         - 单个容器最多可以挂载 7 个 data volume
        /// - 计费
        ///   - 弹性IP的计费模式，如果选择按用量类型可以单独设置，其它计费模式都以主机为准
        ///   - 云硬盘的计费模式以主机为准
        /// - 容器日志
        ///     - 默认在本地分配10MB的存储空间，自动 rotate
        /// - 其他
        ///     - 创建完成后，容器状态为running
        ///     - maxCount 为最大努力，不保证一定能达到 maxCount
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateContainersResponse CreateContainers(CreateContainersRequest request) {
            return  new CreateContainersExecutor().Client(this).Execute<CreateContainersResponse, CreateContainersResult, CreateContainersRequest>(request);
        }
#else
        /// <summary>
        ///  创建一台或多台指定配置容器。
        /// - 创建容器需要通过实名认证
        /// - 镜像
        ///     - 容器的镜像通过镜像名称来确定
        ///     - nginx:tag 或 mysql/mysql-server:tag 这样命名的镜像表示 docker hub 官方镜像
        ///     - container-registry/image:tag 这样命名的镜像表示私有仓储的镜像
        ///     - 私有仓储必须兼容 docker registry 认证机制，并通过 secret 来保存机密信息
        /// - hostname 规范
        ///     - 支持两种方式：以标签方式书写或以完整主机名方式书写
        ///     - 标签规范
        ///         - 0-9，a-z(不分大小写)和 -（减号），其他的都是无效的字符串
        ///         - 不能以减号开始，也不能以减号结尾
        ///         - 最小1个字符，最大63个字符
        ///     - 完整的主机名由一系列标签与点连接组成
        ///         - 标签与标签之间使用“.”(点)进行连接
        ///         - 不能以“.”(点)开始，也不能以“.”(点)结尾
        ///         - 整个主机名（包括标签以及分隔点“.”）最多有63个ASCII字符
        /// - 网络配置
        ///     - 指定主网卡配置信息
        ///         - 必须指定一个子网
        ///         - 一台云主机创建时必须指定一个安全组，至多指定 5 个安全组
        ///         - 可以指定 elasticIp 规格来约束创建的弹性 IP，带宽取值范围 [1-200]Mbps，步进 1Mbps
        ///         - 可以指定网卡的主 IP(primaryIpAddress)，该 IP 需要在子网 IP 范围内且未被占用，指定子网 IP 时 maxCount 只能为1
        ///         - 安全组 securityGroup 需与子网 Subnet 在同一个私有网络 VPC 内
        ///         - 主网卡 deviceIndex 设置为 1
        /// - 存储
        ///     - volume 分为 root volume 和 data volume，root volume 的挂载目录是 /，data volume 的挂载目录可以随意指定
        ///     - volume 的底层存储介质当前只支持 cloud 类别，也就是云硬盘
        ///     - 系统盘
        ///         - 云硬盘类型可以选择 ssd、premium-hdd
        ///         - 磁盘大小
        ///             - ssd：范围 [10, 100]GB，步长为 10G
        ///             - premium-hdd：范围 [20, 1000]GB，步长为 10G
        ///         - 自动删除
        ///             - 云盘默认跟随容器实例自动删除，如果是包年包月的数据盘或共享型数据盘，此参数不生效
        ///         - 可以选择已存在的云硬盘
        ///     - 数据盘
        ///         - 云硬盘类型可以选择 ssd、premium-hdd
        ///         - 磁盘大小
        ///             - ssd：范围[20,1000]GB，步长为10G
        ///             - premium-hdd：范围[20,3000]GB，步长为10G
        ///         - 自动删除
        ///             - 默认自动删除
        ///         - 可以选择已存在的云硬盘
        ///         - 单个容器最多可以挂载 7 个 data volume
        /// - 计费
        ///   - 弹性IP的计费模式，如果选择按用量类型可以单独设置，其它计费模式都以主机为准
        ///   - 云硬盘的计费模式以主机为准
        /// - 容器日志
        ///     - 默认在本地分配10MB的存储空间，自动 rotate
        /// - 其他
        ///     - 创建完成后，容器状态为running
        ///     - maxCount 为最大努力，不保证一定能达到 maxCount
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateContainersResponse> CreateContainers(CreateContainersRequest request) {
            return await new CreateContainersExecutor().Client(this).Execute<CreateContainersResponse, CreateContainersResult, CreateContainersRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  启动处于关闭状态的单个容器，处在任务执行中的容器无法启动。&lt;br&gt;
        /// 容器实例或其绑定的云盘已欠费时，容器将无法正常启动。&lt;br&gt;
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StartContainerResponse StartContainer(StartContainerRequest request) {
            return  new StartContainerExecutor().Client(this).Execute<StartContainerResponse, StartContainerResult, StartContainerRequest>(request);
        }
#else
        /// <summary>
        ///  启动处于关闭状态的单个容器，处在任务执行中的容器无法启动。&lt;br&gt;
        /// 容器实例或其绑定的云盘已欠费时，容器将无法正常启动。&lt;br&gt;
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StartContainerResponse> StartContainer(StartContainerRequest request) {
            return await new StartContainerExecutor().Client(this).Execute<StartContainerResponse, StartContainerResult, StartContainerRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询 secret 列表。&lt;br&gt; 
        /// 此接口支持分页查询，默认每页20条。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSecretsResponse DescribeSecrets(DescribeSecretsRequest request) {
            return  new DescribeSecretsExecutor().Client(this).Execute<DescribeSecretsResponse, DescribeSecretsResult, DescribeSecretsRequest>(request);
        }
#else
        /// <summary>
        ///  查询 secret 列表。&lt;br&gt; 
        /// 此接口支持分页查询，默认每页20条。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSecretsResponse> DescribeSecrets(DescribeSecretsRequest request) {
            return await new DescribeSecretsExecutor().Client(this).Execute<DescribeSecretsResponse, DescribeSecretsResult, DescribeSecretsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改容器的 名称 和 描述。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyContainerAttributeResponse ModifyContainerAttribute(ModifyContainerAttributeRequest request) {
            return  new ModifyContainerAttributeExecutor().Client(this).Execute<ModifyContainerAttributeResponse, ModifyContainerAttributeResult, ModifyContainerAttributeRequest>(request);
        }
#else
        /// <summary>
        ///  修改容器的 名称 和 描述。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyContainerAttributeResponse> ModifyContainerAttribute(ModifyContainerAttributeRequest request) {
            return await new ModifyContainerAttributeExecutor().Client(this).Execute<ModifyContainerAttributeResponse, ModifyContainerAttributeResult, ModifyContainerAttributeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  批量查询原生容器的详细信息&lt;br&gt;
        /// 此接口支持分页查询，默认每页20条。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeContainersResponse DescribeContainers(DescribeContainersRequest request) {
            return  new DescribeContainersExecutor().Client(this).Execute<DescribeContainersResponse, DescribeContainersResult, DescribeContainersRequest>(request);
        }
#else
        /// <summary>
        ///  批量查询原生容器的详细信息&lt;br&gt;
        /// 此接口支持分页查询，默认每页20条。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeContainersResponse> DescribeContainers(DescribeContainersRequest request) {
            return await new DescribeContainersExecutor().Client(this).Execute<DescribeContainersResponse, DescribeContainersResult, DescribeContainersRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认NativecontainerClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>nativecontainerClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>nativecontainerClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>nativecontainerClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造NativecontainerClient 对象
                ///</summary>
                NativecontainerClient Build();
            }

            /// <summary>
            ///  默认NativecontainerClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  NativecontainerClient service client
                /// </summary>
                private  NativecontainerClient nativecontainerClient;

                /// <summary>
                ///  默认NativecontainerClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    nativecontainerClient = new NativecontainerClient();
                }

                /// <summary>
                ///  构造NativecontainerClient 对象
                ///</summary>
                public NativecontainerClient Build()
                {
                    if (nativecontainerClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        nativecontainerClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (nativecontainerClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("NativecontainerClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (nativecontainerClient.HttpRequestConfig == null)
                    {
                        nativecontainerClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (nativecontainerClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("NativecontainerClient build error: http request config not set");
                        }
                    }
                    return nativecontainerClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>nativecontainerClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    nativecontainerClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>nativecontainerClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    nativecontainerClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>nativecontainerClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    nativecontainerClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
