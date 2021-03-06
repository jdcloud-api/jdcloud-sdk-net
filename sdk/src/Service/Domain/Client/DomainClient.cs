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
 * 域名
 * 域名系统相关的接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Domain.Apis;
using JDCloudSDK.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Domain.Client
{
    /// <summary>
    ///  域名
    ///  域名系统相关的接口
    ///  Domain Api 客户端
    ///</summary>
    public class DomainClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private DomainClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public DomainClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public DomainClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public DomainClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.3
        ///</summary>
        public const string ClientVersion = "1.2.3";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "domain.jdcloud-api.com";
        private const string serviceName = "domain";
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
        ///  检查域名是否可以注册
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CheckDomainResponse CheckDomain(CheckDomainRequest request) {
            return  new CheckDomainExecutor().Client(this).Execute<CheckDomainResponse, CheckDomainResult, CheckDomainRequest>(request);
        }
#else
        /// <summary>
        ///  检查域名是否可以注册
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CheckDomainResponse> CheckDomain(CheckDomainRequest request) {
            return await new CheckDomainExecutor().Client(this).Execute<CheckDomainResponse, CheckDomainResult, CheckDomainRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  通过已实名的信息模板，完成域名的快速过户
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DomainTemplateAssignedResponse DomainTemplateAssigned(DomainTemplateAssignedRequest request) {
            return  new DomainTemplateAssignedExecutor().Client(this).Execute<DomainTemplateAssignedResponse, DomainTemplateAssignedResult, DomainTemplateAssignedRequest>(request);
        }
#else
        /// <summary>
        ///  通过已实名的信息模板，完成域名的快速过户
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DomainTemplateAssignedResponse> DomainTemplateAssigned(DomainTemplateAssignedRequest request) {
            return await new DomainTemplateAssignedExecutor().Client(this).Execute<DomainTemplateAssignedResponse, DomainTemplateAssignedResult, DomainTemplateAssignedRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  针对用户的域名进行续费
        /// 域名续费前，请确保用户的京东云账户有足够的资金支付，Openapi接口回返回订单号，可以用此订单号向计费系统查阅详情
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RenewDomainResponse RenewDomain(RenewDomainRequest request) {
            return  new RenewDomainExecutor().Client(this).Execute<RenewDomainResponse, RenewDomainResult, RenewDomainRequest>(request);
        }
#else
        /// <summary>
        ///  针对用户的域名进行续费
        /// 域名续费前，请确保用户的京东云账户有足够的资金支付，Openapi接口回返回订单号，可以用此订单号向计费系统查阅详情
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RenewDomainResponse> RenewDomain(RenewDomainRequest request) {
            return await new RenewDomainExecutor().Client(this).Execute<RenewDomainResponse, RenewDomainResult, RenewDomainRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  域名锁定，设置域名状态为禁止转移
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DomainLockResponse DomainLock(DomainLockRequest request) {
            return  new DomainLockExecutor().Client(this).Execute<DomainLockResponse, DomainLockResult, DomainLockRequest>(request);
        }
#else
        /// <summary>
        ///  域名锁定，设置域名状态为禁止转移
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DomainLockResponse> DomainLock(DomainLockRequest request) {
            return await new DomainLockExecutor().Client(this).Execute<DomainLockResponse, DomainLockResult, DomainLockRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  域名注册
        /// 域名注册前，请确保用户的京东云账户有足够的资金支付，Openapi接口回返回订单号，可以用此订单号向计费系统查阅详情
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateDomainResponse CreateDomain(CreateDomainRequest request) {
            return  new CreateDomainExecutor().Client(this).Execute<CreateDomainResponse, CreateDomainResult, CreateDomainRequest>(request);
        }
#else
        /// <summary>
        ///  域名注册
        /// 域名注册前，请确保用户的京东云账户有足够的资金支付，Openapi接口回返回订单号，可以用此订单号向计费系统查阅详情
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateDomainResponse> CreateDomain(CreateDomainRequest request) {
            return await new CreateDomainExecutor().Client(this).Execute<CreateDomainResponse, CreateDomainResult, CreateDomainRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询用户的域名信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DomainInfoResponse DomainInfo(DomainInfoRequest request) {
            return  new DomainInfoExecutor().Client(this).Execute<DomainInfoResponse, DomainInfoResult, DomainInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询用户的域名信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DomainInfoResponse> DomainInfo(DomainInfoRequest request) {
            return await new DomainInfoExecutor().Client(this).Execute<DomainInfoResponse, DomainInfoResult, DomainInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除域名信息模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request) {
            return  new DeleteTemplateExecutor().Client(this).Execute<DeleteTemplateResponse, DeleteTemplateResult, DeleteTemplateRequest>(request);
        }
#else
        /// <summary>
        ///  删除域名信息模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteTemplateResponse> DeleteTemplate(DeleteTemplateRequest request) {
            return await new DeleteTemplateExecutor().Client(this).Execute<DeleteTemplateResponse, DeleteTemplateResult, DeleteTemplateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改域名信息模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyTemplateInfoResponse ModifyTemplateInfo(ModifyTemplateInfoRequest request) {
            return  new ModifyTemplateInfoExecutor().Client(this).Execute<ModifyTemplateInfoResponse, ModifyTemplateInfoResult, ModifyTemplateInfoRequest>(request);
        }
#else
        /// <summary>
        ///  修改域名信息模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyTemplateInfoResponse> ModifyTemplateInfo(ModifyTemplateInfoRequest request) {
            return await new ModifyTemplateInfoExecutor().Client(this).Execute<ModifyTemplateInfoResponse, ModifyTemplateInfoResult, ModifyTemplateInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取转移密码，用于域名转移注册商转出获取域名转移密码
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetDomainTransferOutPassWordResponse GetDomainTransferOutPassWord(GetDomainTransferOutPassWordRequest request) {
            return  new GetDomainTransferOutPassWordExecutor().Client(this).Execute<GetDomainTransferOutPassWordResponse, GetDomainTransferOutPassWordResult, GetDomainTransferOutPassWordRequest>(request);
        }
#else
        /// <summary>
        ///  获取转移密码，用于域名转移注册商转出获取域名转移密码
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetDomainTransferOutPassWordResponse> GetDomainTransferOutPassWord(GetDomainTransferOutPassWordRequest request) {
            return await new GetDomainTransferOutPassWordExecutor().Client(this).Execute<GetDomainTransferOutPassWordResponse, GetDomainTransferOutPassWordResult, GetDomainTransferOutPassWordRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  用于提交域名转入操作
        /// 要转入域名前，请确保用户的京东云账户有足够的资金支付，Openapi接口回返回订单号，可以用此订单号向计费系统查阅详情
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public TransferinDomainResponse TransferinDomain(TransferinDomainRequest request) {
            return  new TransferinDomainExecutor().Client(this).Execute<TransferinDomainResponse, TransferinDomainResult, TransferinDomainRequest>(request);
        }
#else
        /// <summary>
        ///  用于提交域名转入操作
        /// 要转入域名前，请确保用户的京东云账户有足够的资金支付，Openapi接口回返回订单号，可以用此订单号向计费系统查阅详情
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<TransferinDomainResponse> TransferinDomain(TransferinDomainRequest request) {
            return await new TransferinDomainExecutor().Client(this).Execute<TransferinDomainResponse, TransferinDomainResult, TransferinDomainRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  域名解锁，，取消域名禁止转移的状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DomainUnLockResponse DomainUnLock(DomainUnLockRequest request) {
            return  new DomainUnLockExecutor().Client(this).Execute<DomainUnLockResponse, DomainUnLockResult, DomainUnLockRequest>(request);
        }
#else
        /// <summary>
        ///  域名解锁，，取消域名禁止转移的状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DomainUnLockResponse> DomainUnLock(DomainUnLockRequest request) {
            return await new DomainUnLockExecutor().Client(this).Execute<DomainUnLockResponse, DomainUnLockResult, DomainUnLockRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询域名信息模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryTemplateInfoResponse QueryTemplateInfo(QueryTemplateInfoRequest request) {
            return  new QueryTemplateInfoExecutor().Client(this).Execute<QueryTemplateInfoResponse, QueryTemplateInfoResult, QueryTemplateInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询域名信息模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryTemplateInfoResponse> QueryTemplateInfo(QueryTemplateInfoRequest request) {
            return await new QueryTemplateInfoExecutor().Client(this).Execute<QueryTemplateInfoResponse, QueryTemplateInfoResult, QueryTemplateInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  域名信息模板实名认证
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CertificateTemplateResponse CertificateTemplate(CertificateTemplateRequest request) {
            return  new CertificateTemplateExecutor().Client(this).Execute<CertificateTemplateResponse, CertificateTemplateResult, CertificateTemplateRequest>(request);
        }
#else
        /// <summary>
        ///  域名信息模板实名认证
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CertificateTemplateResponse> CertificateTemplate(CertificateTemplateRequest request) {
            return await new CertificateTemplateExecutor().Client(this).Execute<CertificateTemplateResponse, CertificateTemplateResult, CertificateTemplateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据域名修改域名对应的 DNS 信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyDnsResponse ModifyDns(ModifyDnsRequest request) {
            return  new ModifyDnsExecutor().Client(this).Execute<ModifyDnsResponse, ModifyDnsResult, ModifyDnsRequest>(request);
        }
#else
        /// <summary>
        ///  根据域名修改域名对应的 DNS 信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyDnsResponse> ModifyDns(ModifyDnsRequest request) {
            return await new ModifyDnsExecutor().Client(this).Execute<ModifyDnsResponse, ModifyDnsResult, ModifyDnsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询域名信息模板实名认证状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CertificateTemplateStateResponse CertificateTemplateState(CertificateTemplateStateRequest request) {
            return  new CertificateTemplateStateExecutor().Client(this).Execute<CertificateTemplateStateResponse, CertificateTemplateStateResult, CertificateTemplateStateRequest>(request);
        }
#else
        /// <summary>
        ///  查询域名信息模板实名认证状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CertificateTemplateStateResponse> CertificateTemplateState(CertificateTemplateStateRequest request) {
            return await new CertificateTemplateStateExecutor().Client(this).Execute<CertificateTemplateStateResponse, CertificateTemplateStateResult, CertificateTemplateStateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  域名转入状态查询
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public TransferinDomainStateResponse TransferinDomainState(TransferinDomainStateRequest request) {
            return  new TransferinDomainStateExecutor().Client(this).Execute<TransferinDomainStateResponse, TransferinDomainStateResult, TransferinDomainStateRequest>(request);
        }
#else
        /// <summary>
        ///  域名转入状态查询
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<TransferinDomainStateResponse> TransferinDomainState(TransferinDomainStateRequest request) {
            return await new TransferinDomainStateExecutor().Client(this).Execute<TransferinDomainStateResponse, TransferinDomainStateResult, TransferinDomainStateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询域名的whois信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryWhoisInfoResponse QueryWhoisInfo(QueryWhoisInfoRequest request) {
            return  new QueryWhoisInfoExecutor().Client(this).Execute<QueryWhoisInfoResponse, QueryWhoisInfoResult, QueryWhoisInfoRequest>(request);
        }
#else
        /// <summary>
        ///  查询域名的whois信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryWhoisInfoResponse> QueryWhoisInfo(QueryWhoisInfoRequest request) {
            return await new QueryWhoisInfoExecutor().Client(this).Execute<QueryWhoisInfoResponse, QueryWhoisInfoResult, QueryWhoisInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建域名信息模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request) {
            return  new CreateTemplateExecutor().Client(this).Execute<CreateTemplateResponse, CreateTemplateResult, CreateTemplateRequest>(request);
        }
#else
        /// <summary>
        ///  创建域名信息模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateTemplateResponse> CreateTemplate(CreateTemplateRequest request) {
            return await new CreateTemplateExecutor().Client(this).Execute<CreateTemplateResponse, CreateTemplateResult, CreateTemplateRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认DomainClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>domainClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>domainClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>domainClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造DomainClient 对象
                ///</summary>
                DomainClient Build();
            }

            /// <summary>
            ///  默认DomainClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  DomainClient service client
                /// </summary>
                private  DomainClient domainClient;

                /// <summary>
                ///  默认DomainClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    domainClient = new DomainClient();
                }

                /// <summary>
                ///  构造DomainClient 对象
                ///</summary>
                public DomainClient Build()
                {
                    if (domainClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        domainClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (domainClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("DomainClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (domainClient.HttpRequestConfig == null)
                    {
                        domainClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (domainClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("DomainClient build error: http request config not set");
                        }
                    }
                    return domainClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>domainClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    domainClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>domainClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    domainClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>domainClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    domainClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
