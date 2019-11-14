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
 * 审计管理
 * 审计管理相关接口
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

using JDCloudSDK.Rds.Model;

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  仅支持查看MySQL实例的审计内容&lt;br&gt;- 仅支持 MySQL 5.6, MySQL 5.7, Percona, MariaDB
    /// </summary>
    public class DescribeAuditResultResult : JdcloudResult
    {
        ///<summary>
        /// AuditResult
        ///</summary>
        public List<AuditResult> AuditResult{ get; set; }

        ///<summary>
        /// TotalCount
        ///</summary>
        public   int? TotalCount{ get; set; }
    }
}