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
 * 京东云实人认证-OpenAPI接口
 * 京东云实人认证-OpenAPI接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Cloudauth.Apis;
using JDCloudSDK.Cloudauth.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Cloudauth.Client
{
    /// <summary>
    ///  京东云实人认证-OpenAPI接口
    ///  京东云实人认证-OpenAPI接口
    ///  Cloudauth Api 客户端
    ///</summary>
    public class CloudauthClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private CloudauthClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public CloudauthClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public CloudauthClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public CloudauthClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.3
        ///</summary>
        public const string ClientVersion = "1.2.3";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "cloudauth.jdcloud-api.com";
        private const string serviceName = "cloudauth";
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
        ///  查询城市下银行分行列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryBankBranchListResponse QueryBankBranchList(QueryBankBranchListRequest request) {
            return  new QueryBankBranchListExecutor().Client(this).Execute<QueryBankBranchListResponse, QueryBankBranchListResult, QueryBankBranchListRequest>(request);
        }
#else
        /// <summary>
        ///  查询城市下银行分行列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryBankBranchListResponse> QueryBankBranchList(QueryBankBranchListRequest request) {
            return await new QueryBankBranchListExecutor().Client(this).Execute<QueryBankBranchListResponse, QueryBankBranchListResult, QueryBankBranchListRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询服务开通状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeApplyStatusResponse DescribeApplyStatus(DescribeApplyStatusRequest request) {
            return  new DescribeApplyStatusExecutor().Client(this).Execute<DescribeApplyStatusResponse, DescribeApplyStatusResult, DescribeApplyStatusRequest>(request);
        }
#else
        /// <summary>
        ///  查询服务开通状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeApplyStatusResponse> DescribeApplyStatus(DescribeApplyStatusRequest request) {
            return await new DescribeApplyStatusExecutor().Client(this).Execute<DescribeApplyStatusResponse, DescribeApplyStatusResult, DescribeApplyStatusRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  法人信息校验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CheckLegalPersonResponse CheckLegalPerson(CheckLegalPersonRequest request) {
            return  new CheckLegalPersonExecutor().Client(this).Execute<CheckLegalPersonResponse, CheckLegalPersonResult, CheckLegalPersonRequest>(request);
        }
#else
        /// <summary>
        ///  法人信息校验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CheckLegalPersonResponse> CheckLegalPerson(CheckLegalPersonRequest request) {
            return await new CheckLegalPersonExecutor().Client(this).Execute<CheckLegalPersonResponse, CheckLegalPersonResult, CheckLegalPersonRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  个人实名认证
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public PersonalAuthResponse PersonalAuth(PersonalAuthRequest request) {
            return  new PersonalAuthExecutor().Client(this).Execute<PersonalAuthResponse, PersonalAuthResult, PersonalAuthRequest>(request);
        }
#else
        /// <summary>
        ///  个人实名认证
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<PersonalAuthResponse> PersonalAuth(PersonalAuthRequest request) {
            return await new PersonalAuthExecutor().Client(this).Execute<PersonalAuthResponse, PersonalAuthResult, PersonalAuthRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询所有支持的银行
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryBankListResponse QueryBankList(QueryBankListRequest request) {
            return  new QueryBankListExecutor().Client(this).Execute<QueryBankListResponse, QueryBankListResult, QueryBankListRequest>(request);
        }
#else
        /// <summary>
        ///  查询所有支持的银行
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryBankListResponse> QueryBankList(QueryBankListRequest request) {
            return await new QueryBankListExecutor().Client(this).Execute<QueryBankListResponse, QueryBankListResult, QueryBankListRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  对公银行账户打款(随机小额)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CompanyTransferResponse CompanyTransfer(CompanyTransferRequest request) {
            return  new CompanyTransferExecutor().Client(this).Execute<CompanyTransferResponse, CompanyTransferResult, CompanyTransferRequest>(request);
        }
#else
        /// <summary>
        ///  对公银行账户打款(随机小额)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CompanyTransferResponse> CompanyTransfer(CompanyTransferRequest request) {
            return await new CompanyTransferExecutor().Client(this).Execute<CompanyTransferResponse, CompanyTransferResult, CompanyTransferRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  代理人信息核验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CheckAgentResponse CheckAgent(CheckAgentRequest request) {
            return  new CheckAgentExecutor().Client(this).Execute<CheckAgentResponse, CheckAgentResult, CheckAgentRequest>(request);
        }
#else
        /// <summary>
        ///  代理人信息核验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CheckAgentResponse> CheckAgent(CheckAgentRequest request) {
            return await new CheckAgentExecutor().Client(this).Execute<CheckAgentResponse, CheckAgentResult, CheckAgentRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询省份下城市编码
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryCityListResponse QueryCityList(QueryCityListRequest request) {
            return  new QueryCityListExecutor().Client(this).Execute<QueryCityListResponse, QueryCityListResult, QueryCityListRequest>(request);
        }
#else
        /// <summary>
        ///  查询省份下城市编码
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryCityListResponse> QueryCityList(QueryCityListRequest request) {
            return await new QueryCityListExecutor().Client(this).Execute<QueryCityListResponse, QueryCityListResult, QueryCityListRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  对公打款查询
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CheckCompanyTransferResponse CheckCompanyTransfer(CheckCompanyTransferRequest request) {
            return  new CheckCompanyTransferExecutor().Client(this).Execute<CheckCompanyTransferResponse, CheckCompanyTransferResult, CheckCompanyTransferRequest>(request);
        }
#else
        /// <summary>
        ///  对公打款查询
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CheckCompanyTransferResponse> CheckCompanyTransfer(CheckCompanyTransferRequest request) {
            return await new CheckCompanyTransferExecutor().Client(this).Execute<CheckCompanyTransferResponse, CheckCompanyTransferResult, CheckCompanyTransferRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  企业基础信息核验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CheckCompanyInfoResponse CheckCompanyInfo(CheckCompanyInfoRequest request) {
            return  new CheckCompanyInfoExecutor().Client(this).Execute<CheckCompanyInfoResponse, CheckCompanyInfoResult, CheckCompanyInfoRequest>(request);
        }
#else
        /// <summary>
        ///  企业基础信息核验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CheckCompanyInfoResponse> CheckCompanyInfo(CheckCompanyInfoRequest request) {
            return await new CheckCompanyInfoExecutor().Client(this).Execute<CheckCompanyInfoResponse, CheckCompanyInfoResult, CheckCompanyInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  企业所有信息核验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CheckLegalPersonAndAgentResponse CheckLegalPersonAndAgent(CheckLegalPersonAndAgentRequest request) {
            return  new CheckLegalPersonAndAgentExecutor().Client(this).Execute<CheckLegalPersonAndAgentResponse, CheckLegalPersonAndAgentResult, CheckLegalPersonAndAgentRequest>(request);
        }
#else
        /// <summary>
        ///  企业所有信息核验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CheckLegalPersonAndAgentResponse> CheckLegalPersonAndAgent(CheckLegalPersonAndAgentRequest request) {
            return await new CheckLegalPersonAndAgentExecutor().Client(this).Execute<CheckLegalPersonAndAgentResponse, CheckLegalPersonAndAgentResult, CheckLegalPersonAndAgentRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询所有省份列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public QueryProvinceListResponse QueryProvinceList(QueryProvinceListRequest request) {
            return  new QueryProvinceListExecutor().Client(this).Execute<QueryProvinceListResponse, QueryProvinceListResult, QueryProvinceListRequest>(request);
        }
#else
        /// <summary>
        ///  查询所有省份列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<QueryProvinceListResponse> QueryProvinceList(QueryProvinceListRequest request) {
            return await new QueryProvinceListExecutor().Client(this).Execute<QueryProvinceListResponse, QueryProvinceListResult, QueryProvinceListRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认CloudauthClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>cloudauthClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>cloudauthClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>cloudauthClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造CloudauthClient 对象
                ///</summary>
                CloudauthClient Build();
            }

            /// <summary>
            ///  默认CloudauthClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  CloudauthClient service client
                /// </summary>
                private  CloudauthClient cloudauthClient;

                /// <summary>
                ///  默认CloudauthClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    cloudauthClient = new CloudauthClient();
                }

                /// <summary>
                ///  构造CloudauthClient 对象
                ///</summary>
                public CloudauthClient Build()
                {
                    if (cloudauthClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        cloudauthClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (cloudauthClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("CloudauthClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (cloudauthClient.HttpRequestConfig == null)
                    {
                        cloudauthClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (cloudauthClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("CloudauthClient build error: http request config not set");
                        }
                    }
                    return cloudauthClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>cloudauthClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    cloudauthClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>cloudauthClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    cloudauthClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>cloudauthClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    cloudauthClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
