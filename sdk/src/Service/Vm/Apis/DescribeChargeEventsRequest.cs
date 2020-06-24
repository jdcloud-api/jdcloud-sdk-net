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
 * 云主机
 * 与主机操作相关的接口
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
    ///  查询开关及事件的时间，提供给计费侧用于精确计费 &lt;br&gt;
        ///         /// 不指定 startTime 将实例创建成功的时间作为开始时间，不指定 endTime 则将当前时间作为结束时间
        ///         /// 
    /// </summary>
    public class DescribeChargeEventsRequest : JdcloudRequest
    {
        ///<summary>
        /// 事件的起始时间，格式 2020-03-19 00:24:02
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// 事件的结束时间，格式 2020-03-19 00:24:02
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 云主机ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}