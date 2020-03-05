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
 * es实例接口
 * es实例的创建、变配、删除、查询接口
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

namespace  JDCloudSDK.Es.Apis
{

    /// <summary>
    ///  查询es实例列表
    /// </summary>
    public class DescribeInstancesRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码，默认1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小，默认10
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 过滤条件：
        /// instanceId -实例Id，精确匹配，支持多个
        /// instanceVersion -实例版本，精确匹配，支持单个
        /// azId -azId，精确匹配，支持单个
        /// instanceName - 实例名称，模糊匹配，支持单个
        /// instanceStatus - 实例状态，精确匹配，支持多个(running：运行，error：错误，creating：创建中，changing：变配中，stop：已停止，processing：处理中)
        /// chargeMode - 计费类型，按配置postpaid_by_duration或者包年包月prepaid_by_duration
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

        ///<summary>
        /// 标签过滤条件
        ///</summary>
        public List<JDCloudSDK.Common.Model.TagFilter> TagFilters{ get; set; }

        ///<summary>
        /// regionId
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}