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
 * EdgeManager
 * edge管理模块
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

namespace  JDCloudSDK.Iothub.Apis
{

    /// <summary>
    ///  添加边缘计算设备
    /// </summary>
    public class EdgeEnrollRequest : JdcloudRequest
    {
        ///<summary>
        /// 边缘计算设备显示名称
        ///Required:true
        ///</summary>
        [Required]
        public   string EdgeName{ get; set; }
        ///<summary>
        /// IoTHubInstance编号
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        /// 操作系统
        ///Required:true
        ///</summary>
        [Required]
        public   string Os{ get; set; }
        ///<summary>
        /// 硬件平台版本
        ///Required:true
        ///</summary>
        [Required]
        public   string Hardware{ get; set; }
        ///<summary>
        /// 边缘说明
        ///</summary>
        public   string EdgeDesc{ get; set; }
        ///<summary>
        /// 边缘计算节点编号
        ///Required:true
        ///</summary>
        [Required]
        public   string EdgeId{ get; set; }
    }
}