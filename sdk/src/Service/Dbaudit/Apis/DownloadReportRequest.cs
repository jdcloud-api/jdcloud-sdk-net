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
 * Report Task Interface
 * Report Task Interface
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

namespace  JDCloudSDK.Dbaudit.Apis
{

    /// <summary>
    ///  下载此任务报表
    /// </summary>
    public class DownloadReportRequest : JdcloudRequest
    {
        ///<summary>
        /// 地域 Id
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 报表ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ReportId{ get; set; }
        ///<summary>
        /// 任务ID
        ///Required:true
        ///</summary>
        [Required]
        public   string TaskId{ get; set; }
    }
}