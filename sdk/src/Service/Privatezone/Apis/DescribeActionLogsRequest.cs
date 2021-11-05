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
 * 私有域名操作日志
 * 私有域名操作日志API
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

namespace  JDCloudSDK.Privatezone.Apis
{

    /// <summary>
    ///  查询操作日志
        ///         /// 
    /// </summary>
    public class DescribeActionLogsRequest : JdcloudRequest
    {
        ///<summary>
        /// 页容量，默认10，取值范围(1 - 100)
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 页序号，默认值1，不能小于1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 起始时间，格式：UTC时间例如2017-11-10T23:00:00Z
        ///Required:true
        ///</summary>
        [Required]
        public   string Start{ get; set; }
        ///<summary>
        /// 结束时间，格式：UTC时间例如2017-11-10T23:00:00Z
        ///Required:true
        ///</summary>
        [Required]
        public   string End{ get; set; }
        ///<summary>
        /// 日志模糊匹配的关键词
        ///</summary>
        public   string KeyWord{ get; set; }
        ///<summary>
        /// 操作结果 false-&gt;失败 true-&gt;成功
        ///</summary>
        public   bool Success{ get; set; }
        ///<summary>
        /// 日志类型，支持的类型有：CREATE_ZONE、DELETE_ZONE、LOCK_ZONE、CREATE_RR、MODIFY_RR、DELETE_RR、SET_RR_STATUS、RETRY_RECURSE_ZONE
        ///</summary>
        public   string ActionType{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}