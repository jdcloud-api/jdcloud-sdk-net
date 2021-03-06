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
 * JDCLOUD IAS Services API
 * 京东云联合登陆Api
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Ias.Apis
{

    /// <summary>
    ///  更新应用（只传需要变更的参数，不传的参数不会更新）
    /// </summary>
    public class UpdateAppResult : JdcloudResult
    {
        ///<summary>
        /// 应用ID，由京东云分配的16位数字ID
        ///</summary>
        public   string ClientId{ get; set; }
        ///<summary>
        /// clientName参数值
        ///</summary>
        public   string ClientName{ get; set; }
        ///<summary>
        /// tokenEndpointAuthMethod参数值
        ///</summary>
        public   string TokenEndpointAuthMethod{ get; set; }
        ///<summary>
        /// grantTypes参数值
        ///</summary>
        public   string GrantTypes{ get; set; }
        ///<summary>
        /// 当grantTypes为authorization_code时，responseTypes为code；当grantTypes为implicit时，responseTypes为token
        ///</summary>
        public   string ResponseTypes{ get; set; }
        ///<summary>
        /// redirectUris参数值
        ///</summary>
        public   string RedirectUris{ get; set; }
        ///<summary>
        /// clientUri参数值
        ///</summary>
        public   string ClientUri{ get; set; }
        ///<summary>
        /// logoUri参数值
        ///</summary>
        public   string LogoUri{ get; set; }
        ///<summary>
        /// tosUri参数值
        ///</summary>
        public   string TosUri{ get; set; }
        ///<summary>
        /// policyUri参数值
        ///</summary>
        public   string PolicyUri{ get; set; }
        ///<summary>
        /// scope参数值
        ///</summary>
        public   string Scope{ get; set; }
        ///<summary>
        /// jwksUri参数值
        ///</summary>
        public   string JwksUri{ get; set; }
        ///<summary>
        /// jwks参数值
        ///</summary>
        public   string Jwks{ get; set; }
        ///<summary>
        /// contacts参数值
        ///</summary>
        public   string Contacts{ get; set; }
        ///<summary>
        /// extension参数值
        ///</summary>
        public   string Extension{ get; set; }
        ///<summary>
        /// accessTokenValiditySeconds参数值
        ///</summary>
        public   int? AccessTokenValiditySeconds{ get; set; }
        ///<summary>
        /// refreshTokenValiditySeconds参数值
        ///</summary>
        public   int? RefreshTokenValiditySeconds{ get; set; }
        ///<summary>
        /// multiTenant参数值
        ///</summary>
        public   bool MultiTenant{ get; set; }
        ///<summary>
        /// secretUpdateTime参数值
        ///</summary>
        public   long? SecretUpdateTime{ get; set; }
        ///<summary>
        /// updateTime参数值
        ///</summary>
        public   long? UpdateTime{ get; set; }
        ///<summary>
        /// createTime参数值
        ///</summary>
        public   long? CreateTime{ get; set; }
        ///<summary>
        /// 创建应用的账户用户名
        ///</summary>
        public   string Account{ get; set; }
        ///<summary>
        /// userType参数值
        ///</summary>
        public   string UserType{ get; set; }
    }
}