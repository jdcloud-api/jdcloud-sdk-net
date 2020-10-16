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
 * 集群管理
 * JMR集群管理相关接口
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

using JDCloudSDK.Jmr.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Jmr.Apis
{

    /// <summary>
    ///  扩容集群
    /// </summary>
    public class ClusterExpansionRequest : JdcloudRequest
    {
        ///<summary>
        /// 描述集群配置
        ///Required:true
        ///</summary>
        [Required]
        public   ClusterExpansion ClusterExpansion{ get; set; }
        ///<summary>
        /// 用于保证请求的幂等性。由客户端生成，长度不能超过64个字符。
        /// 
        ///</summary>
        public   string ClientToken{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}