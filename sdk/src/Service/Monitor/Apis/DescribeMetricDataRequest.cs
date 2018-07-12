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
 * 监控项相关接口
 * 监控项相关接口，提供可用监控项列表查询和监控数据查询等功能
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
using JDCloudSDK.Monitor.Model;

namespace  JDCloudSDK.Monitor.Apis
{

    /// <summary>
    ///  查看某资源的监控数据
    /// </summary>
    public class DescribeMetricDataRequest : JdcloudRequest
    {
        ///<summary>
        /// 资源的类型，取值vm, lb, ip, database 等
        ///Required:true
        ///</summary>
        [Required]
        public   string ServiceCode{ get; set; }
        ///<summary>
        /// 资源的uuid
        ///Required:true
        ///</summary>
        [Required]
        public   string ResourceId{ get; set; }
        ///<summary>
        /// 查询时间范围的开始时间， UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ssZ（默认为当前时间，早于30d时，将被重置为30d）
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// 查询时间范围的结束时间， UTC时间，格式：2016-12- yyyy-MM-dd&#39;T&#39;HH:mm:ssZ（为空时，将由startTime与timeInterval计算得出）
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 时间间隔：1h，6h，12h，1d，3d，7d，14d，固定时间间隔，timeInterval 与 endTime 至少填一项
        ///</summary>
        public   string TimeInterval{ get; set; }
        ///<summary>
        /// 自定义标签
        ///</summary>
        public List<Tags> Tags{ get; set; }

        ///<summary>
        /// 地域 Id
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 监控项英文标识(id)
        ///Required:true
        ///</summary>
        [Required]
        public   string Metric{ get; set; }
    }
}