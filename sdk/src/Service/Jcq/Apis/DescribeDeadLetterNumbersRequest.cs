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
 * DeadLetter
 * 死信队列相关接口
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

namespace  JDCloudSDK.Jcq.Apis
{

    /// <summary>
    ///  死信消息数(按照用户或者consumerGroupId)
    /// </summary>
    public class DescribeDeadLetterNumbersRequest : JdcloudRequest
    {
        ///<summary>
        /// consumerGroupId为空则显示该用户所有订阅关系里的死信数量
        ///</summary>
        public   string ConsumerGroupId{ get; set; }
        ///<summary>
        /// 页码
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小；默认为10；取值范围[10, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 所在区域的Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}