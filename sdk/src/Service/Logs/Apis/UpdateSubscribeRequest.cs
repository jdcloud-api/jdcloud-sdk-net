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
 * Subscribe APIs
 * 日志服务日志消费相关的管理控制接口
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
    ///  更新日志消费
    /// </summary>
    public class UpdateSubscribeRequest : JdcloudRequest
    {
        ///<summary>
        /// 日志订阅状态，0表示未创建，1表示刚创建，2表示开启，3表示关闭
        ///</summary>
        public   long? Status{ get; set; }
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
        ///<summary>
        /// 日志主题 UID
        ///Required:true
        ///</summary>
        [Required]
        public   string LogtopicUID{ get; set; }
    }
}