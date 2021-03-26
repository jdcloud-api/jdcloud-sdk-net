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
 * Instance
 * 敏感数据保护-实例相关接口
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

using JDCloudSDK.Common.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Dcap.Apis
{

    /// <summary>
    ///  获取实例列表
    /// </summary>
    public class DescribeInstanceListRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码；默认为1
        ///Required:true
        ///</summary>
        [Required]
        public   int PageNumber{ get; set; }
        ///<summary>
        /// 分页大小；默认为10；取值范围[10, 100]
        ///Required:true
        ///</summary>
        [Required]
        public   int PageSize{ get; set; }
        ///<summary>
        /// &quot;instanceId: 实例ID，字符串数组，精确匹配&quot;
        /// &quot;instanceName: 实例名称，字符串，模糊匹配&quot;
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}