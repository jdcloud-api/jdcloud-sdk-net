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
 * Message-Content-APIs
 * 富媒体模板内容创建、查询相关接口
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

namespace  JDCloudSDK.Rms.Apis
{

    /// <summary>
    ///  查询富媒体短信内容列表接口
    /// </summary>
    public class QueryTemplateListRequest : JdcloudRequest
    {
        ///<summary>
        /// 应用ID
        ///Required:true
        ///</summary>
        [Required]
        public   string AppId{ get; set; }
        ///<summary>
        /// 查询标题关键词
        ///</summary>
        public   string Title{ get; set; }
        ///<summary>
        /// 第几页
        ///Required:true
        ///</summary>
        [Required]
        public   int PageNum{ get; set; }
        ///<summary>
        /// 每页多少条记录
        ///Required:true
        ///</summary>
        [Required]
        public   int PageLimit{ get; set; }
        ///<summary>
        /// 审核状态：0: 审核中 1: 通过 2: 未通过 4:待提交
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// 开始时间,格式YYYY-MM-DD
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// 结束时间,格式YYYY-MM-DD
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}