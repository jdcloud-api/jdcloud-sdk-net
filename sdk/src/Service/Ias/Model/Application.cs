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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Ias.Model
{

    /// <summary>
    ///  application
    /// </summary>
    public class Application
    {

        ///<summary>
        /// 应用名
        ///</summary>
        public string ClientName{ get; set; }
        ///<summary>
        /// tokenEndpointAuthMethod
        ///</summary>
        public string TokenEndpointAuthMethod{ get; set; }
        ///<summary>
        /// grantTypes
        ///</summary>
        public string GrantTypes{ get; set; }
        ///<summary>
        /// redirectUris
        ///</summary>
        public string RedirectUris{ get; set; }
        ///<summary>
        /// clientUri
        ///</summary>
        public string ClientUri{ get; set; }
        ///<summary>
        /// logoUri
        ///</summary>
        public string LogoUri{ get; set; }
        ///<summary>
        /// tosUri
        ///</summary>
        public string TosUri{ get; set; }
        ///<summary>
        /// policyUri
        ///</summary>
        public string PolicyUri{ get; set; }
        ///<summary>
        /// scope
        ///</summary>
        public string Scope{ get; set; }
        ///<summary>
        /// jwksUri
        ///</summary>
        public string JwksUri{ get; set; }
        ///<summary>
        /// jwks
        ///</summary>
        public string Jwks{ get; set; }
        ///<summary>
        /// contacts
        ///</summary>
        public string Contacts{ get; set; }
        ///<summary>
        /// extension
        ///</summary>
        public string Extension{ get; set; }
        ///<summary>
        /// accessTokenValiditySeconds
        ///</summary>
        public int? AccessTokenValiditySeconds{ get; set; }
        ///<summary>
        /// refreshTokenValiditySeconds
        ///</summary>
        public int? RefreshTokenValiditySeconds{ get; set; }
        ///<summary>
        /// multiTenant
        ///</summary>
        public bool MultiTenant{ get; set; }
        ///<summary>
        /// secret
        ///</summary>
        public string Secret{ get; set; }
        ///<summary>
        /// userType
        ///</summary>
        public string UserType{ get; set; }
    }
}