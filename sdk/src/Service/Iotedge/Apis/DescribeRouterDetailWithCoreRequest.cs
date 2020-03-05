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
 * EdgeRouteManager
 * iotcore-Edge消息路由管理
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

namespace  JDCloudSDK.Iotedge.Apis
{

    /// <summary>
    ///  消息路由详情查询
    /// </summary>
    public class DescribeRouterDetailWithCoreRequest : JdcloudRequest
    {
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// IoTCore实例编号
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        /// Edge名称
        ///Required:true
        ///</summary>
        [Required]
        public   string EdgeName{ get; set; }
        ///<summary>
        /// Edge产品Key
        ///Required:true
        ///</summary>
        [Required]
        public   string ProductKey{ get; set; }
        ///<summary>
        /// 消息路由编号
        ///Required:true
        ///</summary>
        [Required]
        public   string RouterId{ get; set; }
    }
}