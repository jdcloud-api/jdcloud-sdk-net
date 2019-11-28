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
 * Logset APIs
 * 日志服务日志集相关管理控制接口
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

namespace  JDCloudSDK.Logs.Apis
{

    /// <summary>
    ///  更新日志集。日志集名称不可更新。
    /// </summary>
    public class UpdateLogsetRequest : JdcloudRequest
    {
        ///<summary>
        /// 日志集描述
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 保存周期，只能是 7， 15， 30
        ///</summary>
        public   long? LifeCycle{ get; set; }
        ///<summary>
        /// 地域 Id
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 日志集 UID
        ///Required:true
        ///</summary>
        [Required]
        public   string LogsetUID{ get; set; }
    }
}