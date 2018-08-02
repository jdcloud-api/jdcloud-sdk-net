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

using JDCloudSDK.Rds.Model;

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  查询性能统计&lt;/br&gt;- SQL Server：支持&lt;/br&gt;- MySQL：暂不支持
    /// </summary>
    public class DescribeQueryPerformanceResult : JdcloudResult
    {
        ///<summary>
        /// QueryPerformanceResult
        ///</summary>
        public List<QueryPerformanceResult> QueryPerformanceResult{ get; set; }

        ///<summary>
        /// 总记录数
        ///</summary>
        public   int? TotalCount{ get; set; }
        ///<summary>
        /// 当前页码
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 每页显示的数据条数
        ///</summary>
        public   int? PageSize{ get; set; }
    }
}