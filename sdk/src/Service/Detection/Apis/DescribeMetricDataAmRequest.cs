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
    ///  查看可用性监控任务的监控数据
    /// </summary>
    public class DescribeMetricDataAmRequest : JdcloudRequest
    {
        ///<summary>
        /// 资源的uuid
        ///Required:true
        ///</summary>
        [Required]
        public   string ResourceId{ get; set; }
        ///<summary>
        /// 查询时间范围的开始时间， UTC时间，格式：2016-12-11T00:00:00+0800（早于30d时，将被重置为30d）（注意在url中+要转译为%2B故url中为2016-12-11T00:00:00%2B0800）
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// 查询时间范围的结束时间， UTC时间，格式：2016-12-11T00:00:00+0800（为空时，将由startTime与timeInterval计算得出）（注意在url中+要转译为%2B故url中为2016-12-11T00:00:00%2B0800）
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 时间间隔：1h，6h，12h，1d，3d，7d，14d，固定时间间隔，timeInterval 与 endTime 至少填一项
        ///</summary>
        public   string TimeInterval{ get; set; }
    }
}