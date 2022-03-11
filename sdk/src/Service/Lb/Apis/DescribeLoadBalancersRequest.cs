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
 * LoadBalancer
 * 负载均衡器相关接口
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
using JDCloudSDK.Lb.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Lb.Apis
{

    /// <summary>
    ///  查询负载均衡列表详情
    /// </summary>
    public class DescribeLoadBalancersRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码, 默认为1, 取值范围：[1,∞), 页码超过总页数时, 显示最后一页
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小，默认为20，取值范围：[10,100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// loadBalancerType - 负载均衡类型，取值为：alb、nlb、dnlb，默认alb，支持单个
        /// loadBalancerIds - 负载均衡ID列表，支持多个
        /// loadBalancerNames - 负载均衡名称列表，支持多个
        /// vpcId - 负载均衡所在Vpc的Id，支持单个
        /// azType - 负载均衡所在可用区类型，取值包括：all(全部可用区)、standard(标准可用区)、edge(边缘可用区)。默认standard ，支持单个
        /// azs - 边缘可用区，支持多个
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

        ///<summary>
        /// Tag筛选条件
        ///</summary>
        public List<JDCloudSDK.Lb.Model.TagFilter> Tags{ get; set; }

        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}