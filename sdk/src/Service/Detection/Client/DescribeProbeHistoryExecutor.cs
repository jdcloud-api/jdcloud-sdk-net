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
 * Availability-Monitoring-APIs
 * 可用性监控相关接口，提供创建、查询、修改、删除可用性监控任务等功能
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

namespace JDCloudSDK.Detection.Client
{

    /// <summary>
    ///  查询可用性监控任务的指定探测源的异常探测历史
    /// </summary>
    public class DescribeProbeHistoryExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  查询可用性监控任务的指定探测源的异常探测历史接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "GET";
            }
        }
        /// <summary>
        ///  查询可用性监控任务的指定探测源的异常探测历史接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/probeTask/{probeTaskID}/probe/{probeID}";
            }
        }
    }
}
