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
    ///  设备服务调用
    /// </summary>
    public class InvokeThingServiceRequest : JdcloudRequest
    {
        ///<summary>
        /// 服务名称
        ///Required:true
        ///</summary>
        [Required]
        public   string Name{ get; set; }
        ///<summary>
        /// 输入参数,object的key为参数名称，value为参数值
        ///</summary>
        public   object Input{ get; set; }
        ///<summary>
        /// 回调spring的bean的名称
        ///</summary>
        public   string CallbackBeanName{ get; set; }
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
        /// 设备唯一标识
        ///Required:true
        ///</summary>
        [Required]
        public   string Identifier{ get; set; }
        ///<summary>
        /// 产品Key
        ///Required:true
        ///</summary>
        [Required]
        public   string ProductKey{ get; set; }
    }
}