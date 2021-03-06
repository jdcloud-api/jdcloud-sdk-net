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
 * 实例管理
 * 实例管理相关接口
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

namespace JDCloudSDK.Rds.Client
{

    /// <summary>
    ///  当实例开启增强备份模式后，查询实例备份的空间使用情况&lt;br&gt;- 仅支持SQL Server
    /// </summary>
    public class DescribeBackupSpaceExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  当实例开启增强备份模式后，查询实例备份的空间使用情况&lt;br&gt;- 仅支持SQL Server接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "GET";
            }
        }
        /// <summary>
        ///  当实例开启增强备份模式后，查询实例备份的空间使用情况&lt;br&gt;- 仅支持SQL Server接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/instances/{instanceId}:describeBackupSpace";
            }
        }
    }
}
