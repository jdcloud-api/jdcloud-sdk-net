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
 * Instance-Operation
 * 实例接入、取消接入、实例列表等接口
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

namespace  JDCloudSDK.Smartdba.Apis
{

    /// <summary>
    ///  获取已接入mysql实例列表
    /// </summary>
    public class DescribeClusterListRequest : JdcloudRequest
    {
        ///<summary>
        /// 显示数据的页码，默认为1，取值范围：[-1,∞)。pageIndex 为-1时，返回所有数据页码；
        ///</summary>
        public   int? PageIndex{ get; set; }
        ///<summary>
        /// 每页显示的数据条数，默认为10，取值范围：[1,100]，用于查询列表的接口
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 实例gid
        ///</summary>
        public   string Gid{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public   string InstanceName{ get; set; }
        ///<summary>
        /// 接入来源
        ///</summary>
        public   string DbSource{ get; set; }
        ///<summary>
        /// 实例状态
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// 实例类型，默认MySQL
        ///</summary>
        public   string DbType{ get; set; }
        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}