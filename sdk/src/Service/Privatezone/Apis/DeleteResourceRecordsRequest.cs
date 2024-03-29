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
 * 私有域名解析记录
 * 私有域名解析记录API
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

namespace  JDCloudSDK.Privatezone.Apis
{

    /// <summary>
    ///  删除解析记录。批量删除时多个resourceRecordId用&quot;,&quot;分隔。批量删除每次最多不超过100个记录
        ///         /// 
    /// </summary>
    public class DeleteResourceRecordsRequest : JdcloudRequest
    {
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// zone id
        ///Required:true
        ///</summary>
        [Required]
        public   string ZoneId{ get; set; }
        ///<summary>
        /// 解析记录ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ResourceRecordId{ get; set; }
    }
}