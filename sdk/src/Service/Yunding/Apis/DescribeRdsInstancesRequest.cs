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
 * yunding-rds
 * 云鼎-云数据库管理相关接口
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

using JDCloudSDK.Common.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Yunding.Apis
{

    /// <summary>
    ///  批量查询云数据库实例列表信息&lt;br&gt;此接口支持分页查询，默认每页20条。
    /// </summary>
    public class DescribeRdsInstancesRequest : JdcloudRequest
    {
        ///<summary>
        /// 显示数据的页码，默认为1，取值范围：[-1,∞)。pageNumber为-1时，返回所有数据页码；超过总页数时，显示最后一页;
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 每页显示的数据条数，默认为100，取值范围：[10,100]，用于查询列表的接口
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 过滤参数，多个过滤参数之间的关系为“与”(and)
        /// 支持以下属性的过滤：
        /// instanceId, 支持operator选项：eq
        /// instanceName, 支持operator选项：eq
        /// engine, 支持operator选项：eq
        /// engineVersion, 支持operator选项：eq
        /// instanceStatus, 支持operator选项：eq
        /// chargeMode, 支持operator选项：eq
        /// vpcId, 支持operator选项：eq
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

        ///<summary>
        /// 资源类型，MySQL：1，SqlServer：2
        ///</summary>
        public   int? Type{ get; set; }
        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}