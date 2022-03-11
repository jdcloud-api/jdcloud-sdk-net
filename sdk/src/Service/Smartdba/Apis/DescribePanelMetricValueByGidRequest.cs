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
 * Monitor-Market
 * 监控大盘相关接口
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
    ///  查询监控大盘监控值
    /// </summary>
    public class DescribePanelMetricValueByGidRequest : JdcloudRequest
    {
        ///<summary>
        /// 查询起始时间，格式为：2021-11-11T15:04:05Z
        ///Required:true
        ///</summary>
        [Required]
        public   string StartTime{ get; set; }
        ///<summary>
        /// 查询截止时间，格式为：2021-11-11T15:04:05Z
        ///Required:true
        ///</summary>
        [Required]
        public   string EndTime{ get; set; }
        ///<summary>
        /// 数据库类型,默认MySQL
        ///</summary>
        public   string DbType{ get; set; }
        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 监控大盘id
        ///Required:true
        ///</summary>
        [Required]
        public   string PanelGid{ get; set; }
        ///<summary>
        /// 监控指标，如： tps、qps 等，在supportMetrics接口有返回
        ///Required:true
        ///</summary>
        [Required]
        public   string Metric{ get; set; }
    }
}