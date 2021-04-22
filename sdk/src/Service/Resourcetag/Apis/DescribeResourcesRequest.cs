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
 * Resource-Tag-APIs
 * 资源标签接口
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

using JDCloudSDK.Resourcetag.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Resourcetag.Apis
{

    /// <summary>
    ///  获得资源与对应标签列表详情，不含资源名称和可用区。&lt;br/&gt;
        ///         /// 注意查询cdn的资源时url中regionId必须指定为cn-all。&lt;br/&gt;
        ///         /// 该接口目前不支持分页功能。
        ///         /// 
    /// </summary>
    public class DescribeResourcesRequest : JdcloudRequest
    {
        ///<summary>
        /// 资源标签参数对象
        ///Required:true
        ///</summary>
        [Required]
        public   ResourceReqVo ResourceVo{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}