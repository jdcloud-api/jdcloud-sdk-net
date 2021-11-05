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
 * 云主机
 * 与主机操作相关的接口
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

using JDCloudSDK.Vm.Model;

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  
        ///         /// 查询一台或多台云主机实例的详细信息。
        ///         /// 
        ///         /// 详细操作说明请参考帮助文档：[查找实例](https://docs.jdcloud.com/cn/virtual-machines/search-instance)
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 使用 &#x60;filters&#x60; 过滤器进行条件筛选，每个 &#x60;filter&#x60; 之间的关系为逻辑与（AND）的关系。
        ///         /// - 如果使用子帐号查询，只会查询到该子帐号有权限的云主机实例。关于资源权限请参考 [IAM概述](https://docs.jdcloud.com/cn/iam/product-overview)。
        ///         /// - 单次查询最大可查询100条云主机实例数据。
        ///         /// - 尽量一次调用接口查询多条数据，不建议使用该批量查询接口一次查询一条数据，如果使用不当导致查询过于密集，可能导致网关触发限流。
        ///         /// - 由于该接口为 &#x60;GET&#x60; 方式请求，最终参数会转换为 &#x60;URL&#x60; 上的参数，但是 &#x60;HTTP&#x60; 协议下的 &#x60;GET&#x60; 请求参数长度是有大小限制的，使用者需要注意参数超长的问题。
        ///         /// 
    /// </summary>
    public class DescribeInstancesResult : JdcloudResult
    {
        ///<summary>
        /// 云主机实例列表。
        ///</summary>
        public List<Instance> Instances{ get; set; }

        ///<summary>
        /// 本次查询可匹配到的总记录数，使用者需要结合 &#x60;pageNumber&#x60; 和 &#x60;pageSize&#x60; 计算是否可以继续分页。
        ///</summary>
        public   double? TotalCount{ get; set; }
    }
}