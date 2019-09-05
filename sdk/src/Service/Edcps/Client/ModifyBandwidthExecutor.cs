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
 * 分布式云物理服务器
 * 分布式云物理服务器操作相关的接口
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

namespace JDCloudSDK.Edcps.Client
{

    /// <summary>
    ///  升级分布式云物理服务器外网带宽，只能操作running或者stopped状态的服务器&lt;br/&gt;
        /// - 不支持未启用外网的服务器升级带宽
        /// - 外网带宽不支持降级
        /// 
    /// </summary>
    public class ModifyBandwidthExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  升级分布式云物理服务器外网带宽，只能操作running或者stopped状态的服务器&lt;br/&gt;
        /// - 不支持未启用外网的服务器升级带宽
        /// - 外网带宽不支持降级
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "PUT";
            }
        }
        /// <summary>
        ///  升级分布式云物理服务器外网带宽，只能操作running或者stopped状态的服务器&lt;br/&gt;
        /// - 不支持未启用外网的服务器升级带宽
        /// - 外网带宽不支持降级
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/instances/{instanceId}:modifyBandwidth";
            }
        }
    }
}
