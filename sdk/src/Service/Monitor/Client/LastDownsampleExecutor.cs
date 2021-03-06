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


using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Monitor.Client
{

    /// <summary>
    ///  根据不同的聚合方式将metric的数据聚合为一个点。downAggrType：last(最后一个点)、max(最大值)、min(最小值)、avg(平均值)。该接口返回值为上报metric的原始值，没有做单位转换。metric介绍：&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/monitoring/metrics&quot;&gt;Metrics&lt;/a&gt;
    /// </summary>
    public class LastDownsampleExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  根据不同的聚合方式将metric的数据聚合为一个点。downAggrType：last(最后一个点)、max(最大值)、min(最小值)、avg(平均值)。该接口返回值为上报metric的原始值，没有做单位转换。metric介绍：&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/monitoring/metrics&quot;&gt;Metrics&lt;/a&gt;接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "GET";
            }
        }
        /// <summary>
        ///  根据不同的聚合方式将metric的数据聚合为一个点。downAggrType：last(最后一个点)、max(最大值)、min(最小值)、avg(平均值)。该接口返回值为上报metric的原始值，没有做单位转换。metric介绍：&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/monitoring/metrics&quot;&gt;Metrics&lt;/a&gt;接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/metrics/{metric}/lastDownsample";
            }
        }
    }
}
