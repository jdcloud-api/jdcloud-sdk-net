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
 * Rule Interface
 * Rule Interface
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

using JDCloudSDK.Dbaudit.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Dbaudit.Apis
{

    /// <summary>
    ///  新增规则
    /// </summary>
    public class AddRuleRequest : JdcloudRequest
    {
        ///<summary>
        /// 数据库ID
        ///</summary>
        public   string DbId{ get; set; }
        ///<summary>
        /// 规则详情
        ///Required:true
        ///</summary>
        [Required]
        public   Rule Rule{ get; set; }
        ///<summary>
        /// 地域 Id
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 审计实例ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InsId{ get; set; }
        ///<summary>
        /// 规则组ID
        ///Required:true
        ///</summary>
        [Required]
        public   string RuleGroupId{ get; set; }
    }
}