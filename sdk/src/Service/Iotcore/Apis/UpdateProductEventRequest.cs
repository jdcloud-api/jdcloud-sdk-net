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
 * ProductEvent
 * 关于产品事件信息操作的相关接口
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

using JDCloudSDK.Iotcore.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Iotcore.Apis
{

    /// <summary>
    ///  修改产品事件
    /// </summary>
    public class UpdateProductEventRequest : JdcloudRequest
    {
        ///<summary>
        /// 描述描述, 0-50个字符
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 事件类型,warning:告警,fault:故障
        ///</summary>
        public   string EventType{ get; set; }
        ///<summary>
        /// 输出参数
        ///</summary>
        public List<ProductProperty> Output{ get; set; }

        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// IoT Engine实例ID信息
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        /// 产品Key
        ///Required:true
        ///</summary>
        [Required]
        public   string ProductKey{ get; set; }
        ///<summary>
        /// 产品事件唯一标识
        ///Required:true
        ///</summary>
        [Required]
        public   string EventId{ get; set; }
    }
}