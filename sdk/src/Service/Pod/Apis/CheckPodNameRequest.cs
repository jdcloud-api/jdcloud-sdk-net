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
 * Pod
 * Pod 相关接口
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

namespace  JDCloudSDK.Pod.Apis
{

    /// <summary>
    ///  podName 是否符合命名规范，以及查询指定 podName 区域内是否已经存在。
        ///         /// 
    /// </summary>
    public class CheckPodNameRequest : JdcloudRequest
    {
        ///<summary>
        /// 用户定义的 pod 名称，符合 DNS-1123 subdomain 规范。
        ///Required:true
        ///</summary>
        [Required]
        public   string PodName{ get; set; }
        ///<summary>
        /// 需要创建的 pod 总数，默认创建一个，不同的总数会对校验结果产生影响。
        ///</summary>
        public   int? MaxCount{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}