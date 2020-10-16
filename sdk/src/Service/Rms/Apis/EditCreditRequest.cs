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
 * Message-Credit-APIs
 * 富媒体资质创建、修改、删除、查询相关接口
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Rms.Apis
{

    /// <summary>
    ///  修改富媒体短信资质接口
    /// </summary>
    public class EditCreditRequest : JdcloudRequest
    {
        ///<summary>
        /// 资质ID
        ///Required:true
        ///</summary>
        [Required]
        public   string SignId{ get; set; }
        ///<summary>
        /// 应用ID
        ///Required:true
        ///</summary>
        [Required]
        public   string AppId{ get; set; }
        ///<summary>
        /// 资质名称
        ///Required:true
        ///</summary>
        [Required]
        public   string Name{ get; set; }
        ///<summary>
        /// 资质描述
        ///Required:true
        ///</summary>
        [Required]
        public   string Description{ get; set; }
        ///<summary>
        /// 营业执照图片,必须是jpg图片的base64编码，只支持jpg图片
        ///Required:true
        ///</summary>
        [Required]
        public   string BusinessLicense{ get; set; }
        ///<summary>
        /// 营业执照名称
        ///Required:true
        ///</summary>
        [Required]
        public   string BusinessLicenseName{ get; set; }
        ///<summary>
        /// 签名授权书图片,必须是jpg图片的base64编码，只支持jpg图片
        ///Required:true
        ///</summary>
        [Required]
        public   string SignedAuthorization{ get; set; }
        ///<summary>
        /// 签名授权书名称
        ///Required:true
        ///</summary>
        [Required]
        public   string SignedAuthorizationName{ get; set; }
        ///<summary>
        /// 信息安全保障责任书图片,必须是jpg图片的base64编码，只支持jpg图片
        ///Required:true
        ///</summary>
        [Required]
        public   string InformationSecurity{ get; set; }
        ///<summary>
        /// 信息安全保障责任书名称
        ///Required:true
        ///</summary>
        [Required]
        public   string InformationSecurityName{ get; set; }
        ///<summary>
        /// 会员证明图片,必须是jpg图片的base64编码，只支持jpg图片
        ///Required:true
        ///</summary>
        [Required]
        public   string MembershipCertificate{ get; set; }
        ///<summary>
        /// 会员证明名称
        ///Required:true
        ///</summary>
        [Required]
        public   string MembershipCertificateName{ get; set; }
        ///<summary>
        /// 其他证明图片,必须是jpg图片的base64编码，只支持jpg图片
        ///Required:true
        ///</summary>
        [Required]
        public   string OtherCertificate{ get; set; }
        ///<summary>
        /// 其他证明名称
        ///Required:true
        ///</summary>
        [Required]
        public   string OtherCertificateName{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}