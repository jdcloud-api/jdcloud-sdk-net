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
 * 性能统计
 * 性能统计相关接口
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

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  根据用户定义的查询条件，获取SQL执行的性能统计信息，例如慢SQL等。用户可以根据这些信息查找与SQL执行相关的性能瓶颈，并进行优化。&lt;br&gt;- 仅支持SQL Server
    /// </summary>
    public class DescribeQueryPerformanceRequest : JdcloudRequest
    {
        ///<summary>
        /// 查询类型，不同的查询类型按照相应的字段从高到低返回结果。&lt;br&gt;支持如下类型：&lt;br&gt;ExecutionCount：执行次数&lt;br&gt;LastRows：上次返回行数&lt;br&gt;ElapsedTime：平均执行时间&lt;br&gt;CPUTime：平均CPU时间&lt;br&gt;LogicalReads：平均逻辑读&lt;br&gt;LogicalWrites：平均逻辑写&lt;br&gt;PhysicalReads：平均物理读&lt;br&gt;
        ///Required:true
        ///</summary>
        [Required]
        public   string QueryType{ get; set; }
        ///<summary>
        /// 只返回查询条件大于等于threshold的记录，默认为0
        ///</summary>
        public   int? Threshold{ get; set; }
        ///<summary>
        /// 显示数据的页码，默认为1，取值范围：[-1,1000]。pageNumber为-1时，返回所有数据页码；超过总页数时，显示最后一页。
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 每页显示的数据条数，默认为50，取值范围：[1,100]，只能为10的倍数，用于查询列表的接口
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// RDS 实例ID，唯一标识一个RDS实例
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}