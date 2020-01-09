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
 * SQL 拦截
 * SQL 拦截相关接口
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

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  查看开启高安全模式后，当前实例的 SQL 拦截记录&lt;br&gt;- 仅支持MySQL
    /// </summary>
    public class DescribeInterceptResultRequest : JdcloudRequest
    {
        ///<summary>
        /// 显示数据的页码，默认为1，取值范围：[-1,∞)。pageNumber为-1时，返回所有数据页码；超过总页数时，显示最后一页;
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 每页显示的数据条数，默认为10，取值范围：[10,100]，且为10的整数倍
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// Instance ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}