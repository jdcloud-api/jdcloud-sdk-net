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
 * 集群管理
 * JMR集群管理相关接口
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

namespace  JDCloudSDK.Jmr.Apis
{

    /// <summary>
    ///  查询用户集群的列表
        ///         /// 
    /// </summary>
    public class DescribeClustersRequest : JdcloudRequest
    {
        ///<summary>
        /// 地域
        ///</summary>
        public   string DataCenter{ get; set; }
        ///<summary>
        /// 集群状态，CREATING，RUNNING，RELEASED，FAILED等
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// 集群名称
        ///</summary>
        public   string ClusterName{ get; set; }
        ///<summary>
        /// 排序，比如 id desc
        ///</summary>
        public   string OrderBy{ get; set; }
        ///<summary>
        /// 页数，默认为1
        ///</summary>
        public   int? PageNum{ get; set; }
        ///<summary>
        /// 每页数目，默认为10
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}