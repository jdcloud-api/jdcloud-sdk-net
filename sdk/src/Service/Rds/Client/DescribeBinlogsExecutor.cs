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
 * binlog日志
 * binlog日志相关接口
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
    ///  获取MySQL实例中binlog的详细信息&lt;br&gt;- 仅支持 MySQL, Percona, MariaDB
    /// </summary>
    public class DescribeBinlogsExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  获取MySQL实例中binlog的详细信息&lt;br&gt;- 仅支持 MySQL, Percona, MariaDB接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "GET";
            }
        }
        /// <summary>
        ///  获取MySQL实例中binlog的详细信息&lt;br&gt;- 仅支持 MySQL, Percona, MariaDB接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/instances/{instanceId}/binlogs";
            }
        }
    }
}
