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
 * DeviceInfo
 * device管理模块
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
    ///  修改设备详情
    /// </summary>
    public class UpdateDeviceRequest : JdcloudRequest
    {
        ///<summary>
        /// 设备型号
        ///</summary>
        public   string Model{ get; set; }
        ///<summary>
        /// 设备厂商
        ///</summary>
        public   string Manufacturer{ get; set; }
        ///<summary>
        /// 设备描述
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 设备状态
        ///</summary>
        public   int? Status{ get; set; }
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
        ///<summary>
        /// 设备Id
        ///Required:true
        ///</summary>
        [Required]
        public   string DeviceId{ get; set; }
    }
}