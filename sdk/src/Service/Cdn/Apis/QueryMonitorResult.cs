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
 * JCloud Openapi For CDN
 * Openapi For JCLOUD cdn
 *
 * OpenAPI spec version: v1
 * Contact: pid-cdn@jd.com
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  查询源站监控信息
    /// </summary>
    public class QueryMonitorResult : JdcloudResult
    {
        ///<summary>
        /// Domain
        ///</summary>
        public   string Domain{ get; set; }
        ///<summary>
        /// Cycle
        ///</summary>
        public   int? Cycle{ get; set; }
        ///<summary>
        /// MonitorPath
        ///</summary>
        public   string MonitorPath{ get; set; }
        ///<summary>
        /// 查询结果,类型为HashMap&lt;String, Object&gt;
        ///</summary>
        public   Dictionary<String,string> HttpRequestHeader{ get; set; }
    }
}