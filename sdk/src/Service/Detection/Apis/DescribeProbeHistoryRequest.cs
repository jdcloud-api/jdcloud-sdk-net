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
 * Availability-Monitoring-APIs
 * 可用性监控相关接口，提供创建、查询、修改、删除可用性监控任务等功能
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Detection.Apis
{

    /// <summary>
    ///  查询可用性监控任务的指定探测源的异常探测历史
    /// </summary>
    public class DescribeProbeHistoryRequest : JdcloudRequest
    {
        ///<summary>
        /// 查询时间范围的开始时间， UTC时间，格式：2016-12-11T00:00:00+0800（默认为当前时间往前三天，早于3d时，将被重置为3d）（注意在url中+要转译为%2B故url中为2016-12-11T00:00:00%2B0800）
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// 查询时间范围的结束时间， UTC时间，格式：2016-12-11T00:00:00+0800（为空时，默认为当前时间）（注意在url中+要转译为%2B故url中为2016-12-11T00:00:00%2B0800）
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 可用性监控task_id, id长度(0,50]
        ///Required:true
        ///</summary>
        [Required]
        public   string ProbeTaskID{ get; set; }
        ///<summary>
        /// 探测源id，  id长度（0,50]
        ///Required:true
        ///</summary>
        [Required]
        public   string ProbeID{ get; set; }
    }
}