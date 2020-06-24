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
 * Anti DDos Pro Instance APIs
 * Anti DDos Pro Instance APIs
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

using JDCloudSDK.Ipanti.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Ipanti.Apis
{

    /// <summary>
    ///  新购或升级高防实例
    /// </summary>
    public class CreateInstanceRequest : JdcloudRequest
    {
        ///<summary>
        /// 新购或升级实例请求参数
        ///Required:true
        ///</summary>
        [Required]
        public   CreateInstanceSpec CreateInstanceSpec{ get; set; }
        ///<summary>
        /// 自动续费配置, 默认不开通, 仅新购实例时可设置
        ///</summary>
        public   AutoRenewalSpec AutoRenewalSpec{ get; set; }
        ///<summary>
        /// 区域 ID, 高防不区分区域, 传 cn-north-1 即可
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}