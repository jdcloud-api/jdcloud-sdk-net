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
 * CoreSystem
 * coreSystem管理
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
    ///  保存发布状态
    /// </summary>
    public class CompletedRequest : JdcloudRequest
    {
        ///<summary>
        /// 系统版本
        ///Required:true
        ///</summary>
        [Required]
        public   string SysVersion{ get; set; }
        ///<summary>
        /// oss关键字段
        ///Required:true
        ///</summary>
        [Required]
        public   string BucketName{ get; set; }
        ///<summary>
        /// oss关键字段
        ///Required:true
        ///</summary>
        [Required]
        public   string ComposeFileAddr{ get; set; }
        ///<summary>
        /// oss关键字段
        ///Required:true
        ///</summary>
        [Required]
        public   string AgentFileAddr{ get; set; }
        ///<summary>
        /// 发布状态0-发布成功，1-发布失败，99-未发布
        ///Required:true
        ///</summary>
        [Required]
        public   int Status{ get; set; }
        ///<summary>
        /// 设备归属的实例所在区域
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 发布返回的UUID
        ///Required:true
        ///</summary>
        [Required]
        public   string CoreSystemId{ get; set; }
    }
}