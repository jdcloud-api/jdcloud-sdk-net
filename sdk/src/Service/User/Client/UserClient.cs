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
 * User API
 * 用户相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.User.Apis;
using JDCloudSDK.User.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.User.Client
{
    /// <summary>
    ///  User API
    ///  用户相关接口
    ///  User Api 客户端
    ///</summary>
    public class UserClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private UserClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public UserClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public UserClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public UserClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.2.0
        ///</summary>
        public const string ClientVersion = "1.2.0";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "user.jdcloud-api.com";
        private const string serviceName = "user";
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
        ///  获取用户余额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeBalanceResponse DescribeBalance(DescribeBalanceRequest request) {
            return  new DescribeBalanceExecutor().Client(this).Execute<DescribeBalanceResponse, DescribeBalanceResult, DescribeBalanceRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户余额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeBalanceResponse> DescribeBalance(DescribeBalanceRequest request) {
            return await new DescribeBalanceExecutor().Client(this).Execute<DescribeBalanceResponse, DescribeBalanceResult, DescribeBalanceRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询账号概要信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeControlManagementSummaryResponse DescribeControlManagementSummary(DescribeControlManagementSummaryRequest request) {
            return  new DescribeControlManagementSummaryExecutor().Client(this).Execute<DescribeControlManagementSummaryResponse, DescribeControlManagementSummaryResult, DescribeControlManagementSummaryRequest>(request);
        }
#else
        /// <summary>
        ///  查询账号概要信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeControlManagementSummaryResponse> DescribeControlManagementSummary(DescribeControlManagementSummaryRequest request) {
            return await new DescribeControlManagementSummaryExecutor().Client(this).Execute<DescribeControlManagementSummaryResponse, DescribeControlManagementSummaryResult, DescribeControlManagementSummaryRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取特定地域下的可用区映射关系
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeRegionAzMappingResponse DescribeRegionAzMapping(DescribeRegionAzMappingRequest request) {
            return  new DescribeRegionAzMappingExecutor().Client(this).Execute<DescribeRegionAzMappingResponse, DescribeRegionAzMappingResult, DescribeRegionAzMappingRequest>(request);
        }
#else
        /// <summary>
        ///  获取特定地域下的可用区映射关系
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeRegionAzMappingResponse> DescribeRegionAzMapping(DescribeRegionAzMappingRequest request) {
            return await new DescribeRegionAzMappingExecutor().Client(this).Execute<DescribeRegionAzMappingResponse, DescribeRegionAzMappingResult, DescribeRegionAzMappingRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  根据父级组织机构获取子组织机构列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeChildOrganizationsResponse DescribeChildOrganizations(DescribeChildOrganizationsRequest request) {
            return  new DescribeChildOrganizationsExecutor().Client(this).Execute<DescribeChildOrganizationsResponse, DescribeChildOrganizationsResult, DescribeChildOrganizationsRequest>(request);
        }
#else
        /// <summary>
        ///  根据父级组织机构获取子组织机构列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeChildOrganizationsResponse> DescribeChildOrganizations(DescribeChildOrganizationsRequest request) {
            return await new DescribeChildOrganizationsExecutor().Client(this).Execute<DescribeChildOrganizationsResponse, DescribeChildOrganizationsResult, DescribeChildOrganizationsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户是否加入黑名单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeEnableStatusResponse DescribeEnableStatus(DescribeEnableStatusRequest request) {
            return  new DescribeEnableStatusExecutor().Client(this).Execute<DescribeEnableStatusResponse, DescribeEnableStatusResult, DescribeEnableStatusRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户是否加入黑名单
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeEnableStatusResponse> DescribeEnableStatus(DescribeEnableStatusRequest request) {
            return await new DescribeEnableStatusExecutor().Client(this).Execute<DescribeEnableStatusResponse, DescribeEnableStatusResult, DescribeEnableStatusRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询用户的资源池类型
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeUserResourceTypeResponse DescribeUserResourceType(DescribeUserResourceTypeRequest request) {
            return  new DescribeUserResourceTypeExecutor().Client(this).Execute<DescribeUserResourceTypeResponse, DescribeUserResourceTypeResult, DescribeUserResourceTypeRequest>(request);
        }
#else
        /// <summary>
        ///  查询用户的资源池类型
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeUserResourceTypeResponse> DescribeUserResourceType(DescribeUserResourceTypeRequest request) {
            return await new DescribeUserResourceTypeExecutor().Client(this).Execute<DescribeUserResourceTypeResponse, DescribeUserResourceTypeResult, DescribeUserResourceTypeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户昵称
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeNickNameResponse DescribeNickName(DescribeNickNameRequest request) {
            return  new DescribeNickNameExecutor().Client(this).Execute<DescribeNickNameResponse, DescribeNickNameResult, DescribeNickNameRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户昵称
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeNickNameResponse> DescribeNickName(DescribeNickNameRequest request) {
            return await new DescribeNickNameExecutor().Client(this).Execute<DescribeNickNameResponse, DescribeNickNameResult, DescribeNickNameRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  通过erp查询报备绑定的pin
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeBindPinsResponse DescribeBindPins(DescribeBindPinsRequest request) {
            return  new DescribeBindPinsExecutor().Client(this).Execute<DescribeBindPinsResponse, DescribeBindPinsResult, DescribeBindPinsRequest>(request);
        }
#else
        /// <summary>
        ///  通过erp查询报备绑定的pin
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeBindPinsResponse> DescribeBindPins(DescribeBindPinsRequest request) {
            return await new DescribeBindPinsExecutor().Client(this).Execute<DescribeBindPinsResponse, DescribeBindPinsResult, DescribeBindPinsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户实名认证状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribePrivilegeNewResponse DescribePrivilegeNew(DescribePrivilegeNewRequest request) {
            return  new DescribePrivilegeNewExecutor().Client(this).Execute<DescribePrivilegeNewResponse, DescribePrivilegeNewResult, DescribePrivilegeNewRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户实名认证状态
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribePrivilegeNewResponse> DescribePrivilegeNew(DescribePrivilegeNewRequest request) {
            return await new DescribePrivilegeNewExecutor().Client(this).Execute<DescribePrivilegeNewResponse, DescribePrivilegeNewResult, DescribePrivilegeNewRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  更新集团上云业务联系人erp
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyContactsResponse ModifyContacts(ModifyContactsRequest request) {
            return  new ModifyContactsExecutor().Client(this).Execute<ModifyContactsResponse, ModifyContactsResult, ModifyContactsRequest>(request);
        }
#else
        /// <summary>
        ///  更新集团上云业务联系人erp
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyContactsResponse> ModifyContacts(ModifyContactsRequest request) {
            return await new ModifyContactsExecutor().Client(this).Execute<ModifyContactsResponse, ModifyContactsResult, ModifyContactsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取联系人列表(不包含pin用户自身信息)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeContactPersonsResponse DescribeContactPersons(DescribeContactPersonsRequest request) {
            return  new DescribeContactPersonsExecutor().Client(this).Execute<DescribeContactPersonsResponse, DescribeContactPersonsResult, DescribeContactPersonsRequest>(request);
        }
#else
        /// <summary>
        ///  获取联系人列表(不包含pin用户自身信息)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeContactPersonsResponse> DescribeContactPersons(DescribeContactPersonsRequest request) {
            return await new DescribeContactPersonsExecutor().Client(this).Execute<DescribeContactPersonsResponse, DescribeContactPersonsResult, DescribeContactPersonsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取联系人组
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeContactGroupResponse DescribeContactGroup(DescribeContactGroupRequest request) {
            return  new DescribeContactGroupExecutor().Client(this).Execute<DescribeContactGroupResponse, DescribeContactGroupResult, DescribeContactGroupRequest>(request);
        }
#else
        /// <summary>
        ///  获取联系人组
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeContactGroupResponse> DescribeContactGroup(DescribeContactGroupRequest request) {
            return await new DescribeContactGroupExecutor().Client(this).Execute<DescribeContactGroupResponse, DescribeContactGroupResult, DescribeContactGroupRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  判断是否是真实用户
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public IsRealUserResponse IsRealUser(IsRealUserRequest request) {
            return  new IsRealUserExecutor().Client(this).Execute<IsRealUserResponse, IsRealUserResult, IsRealUserRequest>(request);
        }
#else
        /// <summary>
        ///  判断是否是真实用户
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<IsRealUserResponse> IsRealUser(IsRealUserRequest request) {
            return await new IsRealUserExecutor().Client(this).Execute<IsRealUserResponse, IsRealUserResult, IsRealUserRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询账号报备信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeUserReportResponse DescribeUserReport(DescribeUserReportRequest request) {
            return  new DescribeUserReportExecutor().Client(this).Execute<DescribeUserReportResponse, DescribeUserReportResult, DescribeUserReportRequest>(request);
        }
#else
        /// <summary>
        ///  查询账号报备信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeUserReportResponse> DescribeUserReport(DescribeUserReportRequest request) {
            return await new DescribeUserReportExecutor().Client(this).Execute<DescribeUserReportResponse, DescribeUserReportResult, DescribeUserReportRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  通过pin查询销售员信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeUserSellerResponse DescribeUserSeller(DescribeUserSellerRequest request) {
            return  new DescribeUserSellerExecutor().Client(this).Execute<DescribeUserSellerResponse, DescribeUserSellerResult, DescribeUserSellerRequest>(request);
        }
#else
        /// <summary>
        ///  通过pin查询销售员信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeUserSellerResponse> DescribeUserSeller(DescribeUserSellerRequest request) {
            return await new DescribeUserSellerExecutor().Client(this).Execute<DescribeUserSellerResponse, DescribeUserSellerResult, DescribeUserSellerRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  判断用户自己是否在白名单内
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public IsInWhiteListResponse IsInWhiteList(IsInWhiteListRequest request) {
            return  new IsInWhiteListExecutor().Client(this).Execute<IsInWhiteListResponse, IsInWhiteListResult, IsInWhiteListRequest>(request);
        }
#else
        /// <summary>
        ///  判断用户自己是否在白名单内
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<IsInWhiteListResponse> IsInWhiteList(IsInWhiteListRequest request) {
            return await new IsInWhiteListExecutor().Client(this).Execute<IsInWhiteListResponse, IsInWhiteListResult, IsInWhiteListRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询用户是否支持京东账号登录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSupportJdLoginResponse DescribeSupportJdLogin(DescribeSupportJdLoginRequest request) {
            return  new DescribeSupportJdLoginExecutor().Client(this).Execute<DescribeSupportJdLoginResponse, DescribeSupportJdLoginResult, DescribeSupportJdLoginRequest>(request);
        }
#else
        /// <summary>
        ///  查询用户是否支持京东账号登录
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSupportJdLoginResponse> DescribeSupportJdLogin(DescribeSupportJdLoginRequest request) {
            return await new DescribeSupportJdLoginExecutor().Client(this).Execute<DescribeSupportJdLoginResponse, DescribeSupportJdLoginResult, DescribeSupportJdLoginRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取az映射关系
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeMappedAzResponse DescribeMappedAz(DescribeMappedAzRequest request) {
            return  new DescribeMappedAzExecutor().Client(this).Execute<DescribeMappedAzResponse, DescribeMappedAzResult, DescribeMappedAzRequest>(request);
        }
#else
        /// <summary>
        ///  获取az映射关系
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeMappedAzResponse> DescribeMappedAz(DescribeMappedAzRequest request) {
            return await new DescribeMappedAzExecutor().Client(this).Execute<DescribeMappedAzResponse, DescribeMappedAzResult, DescribeMappedAzRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询用户账号类型
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeAccountTypeResponse DescribeAccountType(DescribeAccountTypeRequest request) {
            return  new DescribeAccountTypeExecutor().Client(this).Execute<DescribeAccountTypeResponse, DescribeAccountTypeResult, DescribeAccountTypeRequest>(request);
        }
#else
        /// <summary>
        ///  查询用户账号类型
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeAccountTypeResponse> DescribeAccountType(DescribeAccountTypeRequest request) {
            return await new DescribeAccountTypeExecutor().Client(this).Execute<DescribeAccountTypeResponse, DescribeAccountTypeResult, DescribeAccountTypeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取联系人(不包含pin用户自身信息)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeContactPersonResponse DescribeContactPerson(DescribeContactPersonRequest request) {
            return  new DescribeContactPersonExecutor().Client(this).Execute<DescribeContactPersonResponse, DescribeContactPersonResult, DescribeContactPersonRequest>(request);
        }
#else
        /// <summary>
        ///  获取联系人(不包含pin用户自身信息)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeContactPersonResponse> DescribeContactPerson(DescribeContactPersonRequest request) {
            return await new DescribeContactPersonExecutor().Client(this).Execute<DescribeContactPersonResponse, DescribeContactPersonResult, DescribeContactPersonRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取联系人列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeContactPersonsWithOwnerResponse DescribeContactPersonsWithOwner(DescribeContactPersonsWithOwnerRequest request) {
            return  new DescribeContactPersonsWithOwnerExecutor().Client(this).Execute<DescribeContactPersonsWithOwnerResponse, DescribeContactPersonsWithOwnerResult, DescribeContactPersonsWithOwnerRequest>(request);
        }
#else
        /// <summary>
        ///  获取联系人列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeContactPersonsWithOwnerResponse> DescribeContactPersonsWithOwner(DescribeContactPersonsWithOwnerRequest request) {
            return await new DescribeContactPersonsWithOwnerExecutor().Client(this).Execute<DescribeContactPersonsWithOwnerResponse, DescribeContactPersonsWithOwnerResult, DescribeContactPersonsWithOwnerRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeUsersResponse DescribeUsers(DescribeUsersRequest request) {
            return  new DescribeUsersExecutor().Client(this).Execute<DescribeUsersResponse, DescribeUsersResult, DescribeUsersRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest request) {
            return await new DescribeUsersExecutor().Client(this).Execute<DescribeUsersResponse, DescribeUsersResult, DescribeUsersRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户资源权限
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribePrivilegeResponse DescribePrivilege(DescribePrivilegeRequest request) {
            return  new DescribePrivilegeExecutor().Client(this).Execute<DescribePrivilegeResponse, DescribePrivilegeResult, DescribePrivilegeRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户资源权限
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribePrivilegeResponse> DescribePrivilege(DescribePrivilegeRequest request) {
            return await new DescribePrivilegeExecutor().Client(this).Execute<DescribePrivilegeResponse, DescribePrivilegeResult, DescribePrivilegeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  通过pin查询详细的分类
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeUserReportPropertyResponse DescribeUserReportProperty(DescribeUserReportPropertyRequest request) {
            return  new DescribeUserReportPropertyExecutor().Client(this).Execute<DescribeUserReportPropertyResponse, DescribeUserReportPropertyResult, DescribeUserReportPropertyRequest>(request);
        }
#else
        /// <summary>
        ///  通过pin查询详细的分类
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeUserReportPropertyResponse> DescribeUserReportProperty(DescribeUserReportPropertyRequest request) {
            return await new DescribeUserReportPropertyExecutor().Client(this).Execute<DescribeUserReportPropertyResponse, DescribeUserReportPropertyResult, DescribeUserReportPropertyRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  通过账号归属查询归属下的pin的list
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribePinsResponse DescribePins(DescribePinsRequest request) {
            return  new DescribePinsExecutor().Client(this).Execute<DescribePinsResponse, DescribePinsResult, DescribePinsRequest>(request);
        }
#else
        /// <summary>
        ///  通过账号归属查询归属下的pin的list
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribePinsResponse> DescribePins(DescribePinsRequest request) {
            return await new DescribePinsExecutor().Client(this).Execute<DescribePinsResponse, DescribePinsResult, DescribePinsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CheckCredentialResponse CheckCredential(CheckCredentialRequest request) {
            return  new CheckCredentialExecutor().Client(this).Execute<CheckCredentialResponse, CheckCredentialResult, CheckCredentialRequest>(request);
        }
#else
        /// <summary>
        ///  
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CheckCredentialResponse> CheckCredential(CheckCredentialRequest request) {
            return await new CheckCredentialExecutor().Client(this).Execute<CheckCredentialResponse, CheckCredentialResult, CheckCredentialRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建边缘可用区Mapping
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateEdgeZoneMappingResponse CreateEdgeZoneMapping(CreateEdgeZoneMappingRequest request) {
            return  new CreateEdgeZoneMappingExecutor().Client(this).Execute<CreateEdgeZoneMappingResponse, CreateEdgeZoneMappingResult, CreateEdgeZoneMappingRequest>(request);
        }
#else
        /// <summary>
        ///  创建边缘可用区Mapping
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateEdgeZoneMappingResponse> CreateEdgeZoneMapping(CreateEdgeZoneMappingRequest request) {
            return await new CreateEdgeZoneMappingExecutor().Client(this).Execute<CreateEdgeZoneMappingResponse, CreateEdgeZoneMappingResult, CreateEdgeZoneMappingRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取用户Az Mapping
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeAzMappingResponse DescribeAzMapping(DescribeAzMappingRequest request) {
            return  new DescribeAzMappingExecutor().Client(this).Execute<DescribeAzMappingResponse, DescribeAzMappingResult, DescribeAzMappingRequest>(request);
        }
#else
        /// <summary>
        ///  获取用户Az Mapping
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeAzMappingResponse> DescribeAzMapping(DescribeAzMappingRequest request) {
            return await new DescribeAzMappingExecutor().Client(this).Execute<DescribeAzMappingResponse, DescribeAzMappingResult, DescribeAzMappingRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  批量查询用户敏感信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public BatchQuerySensitiveInfoResponse BatchQuerySensitiveInfo(BatchQuerySensitiveInfoRequest request) {
            return  new BatchQuerySensitiveInfoExecutor().Client(this).Execute<BatchQuerySensitiveInfoResponse, BatchQuerySensitiveInfoResult, BatchQuerySensitiveInfoRequest>(request);
        }
#else
        /// <summary>
        ///  批量查询用户敏感信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<BatchQuerySensitiveInfoResponse> BatchQuerySensitiveInfo(BatchQuerySensitiveInfoRequest request) {
            return await new BatchQuerySensitiveInfoExecutor().Client(this).Execute<BatchQuerySensitiveInfoResponse, BatchQuerySensitiveInfoResult, BatchQuerySensitiveInfoRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取联系人组列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeContactGroupsResponse DescribeContactGroups(DescribeContactGroupsRequest request) {
            return  new DescribeContactGroupsExecutor().Client(this).Execute<DescribeContactGroupsResponse, DescribeContactGroupsResult, DescribeContactGroupsRequest>(request);
        }
#else
        /// <summary>
        ///  获取联系人组列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeContactGroupsResponse> DescribeContactGroups(DescribeContactGroupsRequest request) {
            return await new DescribeContactGroupsExecutor().Client(this).Execute<DescribeContactGroupsResponse, DescribeContactGroupsResult, DescribeContactGroupsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取联系人及组(不包含pin用户自身信息)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeContactGroupPersonsResponse DescribeContactGroupPersons(DescribeContactGroupPersonsRequest request) {
            return  new DescribeContactGroupPersonsExecutor().Client(this).Execute<DescribeContactGroupPersonsResponse, DescribeContactGroupPersonsResult, DescribeContactGroupPersonsRequest>(request);
        }
#else
        /// <summary>
        ///  获取联系人及组(不包含pin用户自身信息)
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeContactGroupPersonsResponse> DescribeContactGroupPersons(DescribeContactGroupPersonsRequest request) {
            return await new DescribeContactGroupPersonsExecutor().Client(this).Execute<DescribeContactGroupPersonsResponse, DescribeContactGroupPersonsResult, DescribeContactGroupPersonsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询用户信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeUserResponse DescribeUser(DescribeUserRequest request) {
            return  new DescribeUserExecutor().Client(this).Execute<DescribeUserResponse, DescribeUserResult, DescribeUserRequest>(request);
        }
#else
        /// <summary>
        ///  查询用户信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeUserResponse> DescribeUser(DescribeUserRequest request) {
            return await new DescribeUserExecutor().Client(this).Execute<DescribeUserResponse, DescribeUserResult, DescribeUserRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  灰度产品线校验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeGrayUserResponse DescribeGrayUser(DescribeGrayUserRequest request) {
            return  new DescribeGrayUserExecutor().Client(this).Execute<DescribeGrayUserResponse, DescribeGrayUserResult, DescribeGrayUserRequest>(request);
        }
#else
        /// <summary>
        ///  灰度产品线校验
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeGrayUserResponse> DescribeGrayUser(DescribeGrayUserRequest request) {
            return await new DescribeGrayUserExecutor().Client(this).Execute<DescribeGrayUserResponse, DescribeGrayUserResult, DescribeGrayUserRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认UserClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>userClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>userClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>userClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造UserClient 对象
                ///</summary>
                UserClient Build();
            }

            /// <summary>
            ///  默认UserClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  UserClient service client
                /// </summary>
                private  UserClient userClient;

                /// <summary>
                ///  默认UserClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    userClient = new UserClient();
                }

                /// <summary>
                ///  构造UserClient 对象
                ///</summary>
                public UserClient Build()
                {
                    if (userClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        userClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (userClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("UserClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (userClient.HttpRequestConfig == null)
                    {
                        userClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (userClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("UserClient build error: http request config not set");
                        }
                    }
                    return userClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>userClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    userClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>userClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    userClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>userClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    userClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
