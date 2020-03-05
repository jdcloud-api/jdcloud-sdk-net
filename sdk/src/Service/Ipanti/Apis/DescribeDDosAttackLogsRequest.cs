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
 * Anti DDoS Pro Attack Log APIs
 * Anti DDoS Pro Attack Log APIs
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

namespace  JDCloudSDK.Ipanti.Apis
{

    /// <summary>
    ///  查询 DDoS 攻击日志
    /// </summary>
    public class DescribeDDoSAttackLogsRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码, 默认为1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小, 默认为10, 取值范围[10, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 开始时间, 只能查询最近 90 天以内的数据, UTC 时间, 格式: yyyy-MM-dd&#39;T&#39;HH:mm:ssZ
        ///Required:true
        ///</summary>
        [Required]
        public   string StartTime{ get; set; }
        ///<summary>
        /// 查询的结束时间, UTC 时间, 格式: yyyy-MM-dd&#39;T&#39;HH:mm:ssZ
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 高防实例 ID
        ///</summary>
        public List<string> InstanceId{ get; set; }

        ///<summary>
        /// 区域 ID, 高防不区分区域, 传 cn-north-1 即可
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}