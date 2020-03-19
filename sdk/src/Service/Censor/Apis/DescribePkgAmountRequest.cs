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
 * 订单类接口
 * 京东云内容安全-OpenAPI订单类接口
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

namespace  JDCloudSDK.Censor.Apis
{

    /// <summary>
    ///  运营后台获取流量包统计数目
    /// </summary>
    public class DescribePkgAmountRequest : JdcloudRequest
    {
        ///<summary>
        /// 起始时间,秒
        ///Required:true
        ///</summary>
        [Required]
        public   int Start{ get; set; }
        ///<summary>
        /// 结束时间,秒
        ///Required:true
        ///</summary>
        [Required]
        public   int End{ get; set; }
        ///<summary>
        /// 实例所属的地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}