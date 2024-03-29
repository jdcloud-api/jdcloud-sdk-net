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
 * 私有域名解析记录
 * 私有域名解析记录API
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Privatezone.Client
{

    /// <summary>
    ///  设置解析记录状态，STOP操作会将停止该记录的解析，直到再次START。批量设置时多个resourceRecordId用&quot;,&quot;分隔。批量设置时每次最多不超过100个记录
        /// 
    /// </summary>
    public class SetResourceRecordsStatusExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  设置解析记录状态，STOP操作会将停止该记录的解析，直到再次START。批量设置时多个resourceRecordId用&quot;,&quot;分隔。批量设置时每次最多不超过100个记录
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "PUT";
            }
        }
        /// <summary>
        ///  设置解析记录状态，STOP操作会将停止该记录的解析，直到再次START。批量设置时多个resourceRecordId用&quot;,&quot;分隔。批量设置时每次最多不超过100个记录
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/zone/{zoneId}/resourceRecords/{resourceRecordId}/status";
            }
        }
    }
}
