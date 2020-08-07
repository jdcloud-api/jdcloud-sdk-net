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


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  查看RDS实例备份策略。根据数据库类型的不同，支持的备份策略也略有差异，具体请看返回参数中的详细说明
    /// </summary>
    public class DescribeBackupPolicyResult : JdcloudResult
    {
        ///<summary>
        /// 自动备份开始时间窗口，范围00:00-23:59，时间范围差不得小于30分钟。&lt;br&gt;例如：00:00-01:00，表示0点到1点开始进行数据库自动备份，备份完成时间则跟实例大小有关，不一定在这个时间范围中
        ///</summary>
        public   string StartWindow{ get; set; }
        ///<summary>
        /// 自动备份保留周期，单位天,缺省为7天，范围7-730
        ///</summary>
        public   int? RetentionPeriod{ get; set; }
        ///<summary>
        /// binlog本地保留周期，单位天，范围1-7，默认为1
        ///</summary>
        public   int? BinlogRetentionPeriod{ get; set; }
        ///<summary>
        /// binlog本地占用空间上限，单位%，范围1-50，默认为10
        ///</summary>
        public   int? BinlogUsageLimit{ get; set; }
        ///<summary>
        /// 自动备份循环模式&lt;br&gt;1:表示每天都是全量备份&lt;br&gt;2:表示自动备份按照全量、增量、增量这样的方式进行，例如第1天是全量备份，第2、3天是增量备份；第4天又是全量备份，以此类推.&lt;br&gt; - 仅支持 SQL Server
        ///</summary>
        public   int? CycleMode{ get; set; }
        ///<summary>
        /// 是否备份binlog&lt;br&gt;true:表示备份&lt;br&gt;false:表示不备份&lt;br&gt; - **仅支持 MySQL，Percona，MariaDB
        ///</summary>
        public   string BackupBinlog{ get; set; }
    }
}