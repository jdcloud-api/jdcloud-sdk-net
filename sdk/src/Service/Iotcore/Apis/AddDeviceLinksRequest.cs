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
    ///  建立设备间的父子关系
    /// </summary>
    public class AddDeviceLinksRequest : JdcloudRequest
    {
        ///<summary>
        /// 父级设备Id，只允许网关设备作为父级设备
        ///Required:true
        ///</summary>
        [Required]
        public   string ParentId{ get; set; }
        ///<summary>
        /// 将此产品下所有设备都设置为parentId的子设备，只允许普通设备类型的productKey
        ///</summary>
        public   string ProductKey{ get; set; }
        ///<summary>
        /// 子设备Id集合，children和productKey二者至少填一个，二者都填写则同时生效，只允许普通设备类型的deviceId
        ///</summary>
        public List<string> Children{ get; set; }

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