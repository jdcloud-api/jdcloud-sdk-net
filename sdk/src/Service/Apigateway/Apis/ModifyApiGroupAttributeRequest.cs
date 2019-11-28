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
 * API-Group
 * 提供API分组的创建、查询、删除、修改等功能。
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

namespace  JDCloudSDK.Apigateway.Apis
{

    /// <summary>
    ///  修改API分组信息
    /// </summary>
    public class ModifyApiGroupAttributeRequest : JdcloudRequest
    {
        ///<summary>
        /// 名称
        ///</summary>
        public   string GroupName{ get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 分组路径前缀
        ///</summary>
        public   string Prefix{ get; set; }
        ///<summary>
        /// 密钥验证方式：check_exist（密钥必须在访问授权中已配置）、no_check_exist（无需事先配置）
        ///</summary>
        public   string KeyCheck{ get; set; }
        ///<summary>
        /// 访问授权方式：None（免鉴权）、jd_cloud（开启访问授权，且必须使用京东云的AK、SK验签）、hufu（虎符用户）
        ///</summary>
        public   string AuthType{ get; set; }
        ///<summary>
        /// 是否转发分组路径到后端服务：0（不转发）、1（转发）默认为1
        ///</summary>
        public   int? PrefixStrip{ get; set; }
        ///<summary>
        /// 分组类型：api_group（api分组）、jdsf_group（微服务分组）默认为 api_group
        ///</summary>
        public   string GroupType{ get; set; }
        ///<summary>
        /// 微服务网关名称
        ///</summary>
        public   string JdsfName{ get; set; }
        ///<summary>
        /// 微服务注册中心ID
        ///</summary>
        public   string JdsfRegistryName{ get; set; }
        ///<summary>
        /// 微服务网关ID
        ///</summary>
        public   string JdsfId{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 分组ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ApiGroupId{ get; set; }
    }
}