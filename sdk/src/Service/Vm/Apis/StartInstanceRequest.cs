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

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  启动单个云主机，只能启动&lt;b&gt;stopped&lt;/b&gt;状态的云主机，云主机没有正在进行中的任务才可启动。&lt;br&gt;
        ///         /// 只能启动正常计费状态的云主机，若已欠费停服或到期停服则不支持启动。
        ///         /// 
    /// </summary>
    public class StartInstanceRequest : JdcloudRequest
    {
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 云主机ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}