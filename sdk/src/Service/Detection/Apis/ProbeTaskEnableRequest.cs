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
 * Availability-Monitoring-APIs
 * 可用性监控相关接口，提供创建、查询、修改、删除可用性监控任务等功能
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

namespace  JDCloudSDK.Detection.Apis
{

    /// <summary>
    ///  启用、禁用可用性监控任务
    /// </summary>
    public class ProbeTaskEnableRequest : JdcloudRequest
    {
        ///<summary>
        /// 默认：禁用； true：启用，false：禁用
        ///</summary>
        public   bool Enabled{ get; set; }
        ///<summary>
        /// 要启用或禁用的探测任务的task_id列表，列表长度[1，100)
        ///Required:true
        ///</summary>
        [Required]
        public List<string> TaskId{ get; set; }

    }
}