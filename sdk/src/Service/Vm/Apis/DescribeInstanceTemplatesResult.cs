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
 * Instance-Template
 * 与实例模板相关的接口
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
        ///         /// 查询实例模板列表。
        ///         /// 
        ///         /// 详细操作说明请参考帮助文档：[实例模板](https://docs.jdcloud.com/cn/virtual-machines/instance-template-overview)
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 使用 &#x60;filters&#x60; 过滤器进行条件筛选，每个 &#x60;filter&#x60; 之间的关系为逻辑与（AND）的关系。
        ///         /// - 单次查询最大可查询100条实例模板数据。
        ///         /// 
    /// </summary>
    public class DescribeInstanceTemplatesResult : JdcloudResult
    {
        ///<summary>
        /// 实例模板列表。
        ///</summary>
        public List<InstanceTemplate> InstanceTemplates{ get; set; }

        ///<summary>
        /// 本次查询可匹配到的总记录数，使用者需要结合 &#x60;pageNumber&#x60; 和 &#x60;pageSize&#x60; 计算是否可以继续分页。
        ///</summary>
        public   double? TotalCount{ get; set; }
    }
}