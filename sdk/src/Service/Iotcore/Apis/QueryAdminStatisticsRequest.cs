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
 * LoongrayDeviceInfo
 * 朗讯device管理模块
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
using Newtonsoft.Json;

namespace  JDCloudSDK.Iotcore.Apis
{

    /// <summary>
    ///  设备基本数据统计，包括设备数，激活数，在线数
    /// </summary>
    public class QueryAdminStatisticsRequest : JdcloudRequest
    {
        ///<summary>
        /// 过滤条件，产品Key
        ///</summary>
        public   string ProductKey{ get; set; }
        ///<summary>
        /// 针对parentId下的子设备进行统计
        ///</summary>
        public   string ParentId{ get; set; }
        ///<summary>
        /// 采集器类型
        ///</summary>
        public   string DeviceCollectorType{ get; set; }
        ///<summary>
        /// 设备归属的实例ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        /// 设备归属的实例所在区域
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}