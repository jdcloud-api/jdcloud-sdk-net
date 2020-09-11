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
    ///  获取任务列表
        ///         /// 一次性任务报表时间范围[0-30天]
        ///         /// 
    /// </summary>
    public class DescribeTaskListRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码；默认为1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小；默认为10；取值范围[10, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 地域 Id
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}