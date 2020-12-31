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

using JDCloudSDK.Common.Model;
using JDCloudSDK.Pod.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Pod.Apis
{

    /// <summary>
    ///  批量查询 pod 的详细信息&lt;br&gt;
        ///         /// 此接口支持分页查询，默认每页20条。
        ///         /// 
    /// </summary>
    public class DescribePodsRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码；默认为1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小；默认为20；取值范围[10, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// podId - pod ID，精确匹配，支持多个
        /// privateIpAddress - 主网卡IP地址，模糊匹配，支持单个
        /// az - 可用区，精确匹配，支持多个
        /// vpcId - 私有网络ID，精确匹配，支持多个
        /// phase - pod 状态，精确匹配，支持多个
        /// name - 实例名称，模糊匹配，支持单个
        /// subnetId - 镜像ID，精确匹配，支持多个
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

        ///<summary>
        /// Tag筛选条件
        ///</summary>
        public List<JDCloudSDK.Pod.Model.TagFilter> Tags{ get; set; }

        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}