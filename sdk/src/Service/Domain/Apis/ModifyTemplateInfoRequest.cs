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
 * Domain-Template
 * 域名模板相关接口
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

using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Domain.Apis
{

    /// <summary>
    ///  修改域名信息模板
    /// </summary>
    public class ModifyTemplateInfoRequest : JdcloudRequest
    {
        ///<summary>
        /// 国家及地区（中文）
        ///</summary>
        public   string NationCodeCh{ get; set; }
        ///<summary>
        /// 国家及地区（英文）中国：china
        ///</summary>
        public   string NationCodeEn{ get; set; }
        ///<summary>
        /// 省份（中文）
        ///</summary>
        public   string ProvinceCodeCh{ get; set; }
        ///<summary>
        /// 省份（英文）
        ///</summary>
        public   string ProvinceCodeEn{ get; set; }
        ///<summary>
        /// 城市（中文）
        ///</summary>
        public   string CityCodeCh{ get; set; }
        ///<summary>
        /// 城市（英文）
        ///</summary>
        public   string CityCodeEn{ get; set; }
        ///<summary>
        /// 通信地址（中文）
        ///</summary>
        public   string AddressCh{ get; set; }
        ///<summary>
        /// 通信地址（英文）
        ///</summary>
        public   string AddressEn{ get; set; }
        ///<summary>
        /// 邮编 6位数字
        ///</summary>
        public   string ZipCode{ get; set; }
        ///<summary>
        /// 联系电话，国家区号-地区区号(或手机号码前3位)-电话号码（或手机号码后8位) 例:86-138-12345678
        ///</summary>
        public   string Phone{ get; set; }
        ///<summary>
        /// 传真，国家区号-地区区号(或手机号码前3位)-电话号码（或手机号码后8位) 例:86-138-12345678
        ///</summary>
        public   string Fax{ get; set; }
        ///<summary>
        /// 邮件
        ///</summary>
        public   string Email{ get; set; }
        ///<summary>
        /// 所有者类型  1个人 2企业
        ///</summary>
        public   int? OwnerType{ get; set; }
        ///<summary>
        /// 实例所属的地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 模板ID
        ///Required:true
        ///</summary>
        [Required]
        public   long TemplateId{ get; set; }
    }
}