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

namespace  JDCloudSDK.Monitor.Apis
{

    /// <summary>
    ///  根据产品线查询可用监控项列表,metric介绍：&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/monitoring/metrics&quot;&gt;Metrics&lt;/a&gt;
    /// </summary>
    public class DescribeMetricsRequest : JdcloudRequest
    {
        ///<summary>
        /// 资源的类型，取值vm, lb, ip, database 等。&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/monitoring/api/describeservices?content&#x3D;API&amp;SOP&#x3D;JDCloud&quot;&gt;describeServices&lt;/a&gt;：查询己接入云监控的产品线列表
        ///Required:true
        ///</summary>
        [Required]
        public   string ServiceCode{ get; set; }
        ///<summary>
        /// Dimension
        ///</summary>
        public   string Dimension{ get; set; }
        ///<summary>
        /// metric的类型，取值0(控制台展示)、1(内部使用，控制台不展示)、2(所有).默认取0
        ///</summary>
        public   long? Type{ get; set; }
    }
}