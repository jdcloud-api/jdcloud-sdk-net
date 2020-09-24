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
 * 实例规格
 * 实例规格相关接口
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

using JDCloudSDK.Common.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Instancevoucher.Apis
{

    /// <summary>
    ///  查询实例规格信息列表
        ///         /// 
    /// </summary>
    public class DescribeInstanceVoucherTypesRequest : JdcloudRequest
    {
        ///<summary>
        /// 产品类型 支持[vm, nativecontainer, pod]，默认为vm
        ///</summary>
        public   string ResourceType{ get; set; }
        ///<summary>
        /// 资源分配方式，支持[nonReserved]
        ///</summary>
        public   string ReservedType{ get; set; }
        ///<summary>
        /// Filter names: (仅支持eq)
        /// instanceType - 实例规格，精确匹配，支持多个
        /// instanceTypeFamily - 实例规格族，精确匹配，支持多个
        /// az - 可用区，精确匹配，支持多个
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}