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
 * Anti DDos Pro Web Rule Configuration APIs
 * Anti DDos Pro Web Rule Configuration APIs
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

namespace  JDCloudSDK.Ipanti.Apis
{

    /// <summary>
    ///  插入JS指纹到所有页面, 需要打开网站类规则的JS指纹开关
    /// </summary>
    public class ModifyWebRuleJsPageToAllRequest : JdcloudRequest
    {
        ///<summary>
        /// 区域 ID, 高防不区分区域, 传 cn-north-1 即可
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 高防实例 Id
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        /// 网站规则 Id
        ///Required:true
        ///</summary>
        [Required]
        public   string WebRuleId{ get; set; }
    }
}