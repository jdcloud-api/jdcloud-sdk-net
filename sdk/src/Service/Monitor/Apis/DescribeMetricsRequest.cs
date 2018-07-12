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
 * 监控项相关接口
 * 监控项相关接口，提供可用监控项列表查询和监控数据查询等功能
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

namespace  JDCloudSDK.Monitor.Apis
{

    /// <summary>
    ///  根据产品线查询可用监控项列表
    /// </summary>
    public class DescribeMetricsRequest : JdcloudRequest
    {
        ///<summary>
        /// 资源的类型 ： 
        /// vm--&gt;云主机
        /// disk--&gt;云硬盘
        /// ip--&gt;公网ip
        /// balance--&gt;负载均衡
        /// database--&gt;云数据库mysql版本
        /// cdn--&gt;京东CDN
        /// redis--&gt;redis云缓存
        /// mongodb--&gt;mongoDB云缓存
        /// storage--&gt;云存储
        /// sqlserver--&gt;云数据库sqlserver版 
        /// nativecontainer--&gt;容器
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string ServiceCode{ get; set; }
    }
}