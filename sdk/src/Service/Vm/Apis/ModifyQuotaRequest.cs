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
 * 配额
 * 与配额相关的接口
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

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  修改配额，此接口为内部接口，支持：云主机、镜像、密钥、模板
        ///         /// 
    /// </summary>
    public class ModifyQuotaRequest : JdcloudRequest
    {
        ///<summary>
        /// 资源类型[instance，keypair，image，instanceTemplate, imageShare]
        ///</summary>
        public   string ResourceType{ get; set; }
        ///<summary>
        /// 私有镜像Id，镜像共享(imageShare)配额时，此参数必传
        ///</summary>
        public   string ImageId{ get; set; }
        ///<summary>
        /// 配额上限
        ///</summary>
        public   int? Limit{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}