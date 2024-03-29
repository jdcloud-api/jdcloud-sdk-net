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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Dbs.Model
{

    /// <summary>
    ///  initBackupPlan
    /// </summary>
    public class InitBackupPlan
    {

        ///<summary>
        /// 引擎类型 MySQL5  MySQL8  MariaDB  Percona
        ///Required:true
        ///</summary>
        [Required]
        public string SourceEngine{ get; set; }
        ///<summary>
        /// 备份方式，支持物理备份或逻辑备份
        ///Required:true
        ///</summary>
        [Required]
        public string BackupType{ get; set; }
        ///<summary>
        /// 是否开启日志备份；true：开启；false：关闭
        ///</summary>
        public bool EnableBackupLogs{ get; set; }
        ///<summary>
        /// 日志备份保存天数，支持7-3650 天，默认7天
        ///</summary>
        public int? LogBackupRetentionPeriod{ get; set; }
        ///<summary>
        /// 全量备份保存天数，支持7-3650 天，默认7天
        ///</summary>
        public int? FullBackupRetentionPeriod{ get; set; }
        ///<summary>
        /// 全量备份的备份周期
        ///Required:true
        ///</summary>
        [Required]
        public BackupSchedule FullBackupSchedule{ get; set; }
        ///<summary>
        /// 备份目标的详细信息
        ///Required:true
        ///</summary>
        [Required]
        public SourceEndpoint SourceEndpoint{ get; set; }
        ///<summary>
        /// 逻辑备份中要备份的对象的信息，物理备份无须该信息
        ///</summary>
        public BackupObjects BackupObjects{ get; set; }
        ///<summary>
        /// 是否开启日志备份；true：开启；false：关闭
        ///Required:true
        ///</summary>
        [Required]
        public bool CreateNewEndpoint{ get; set; }
    }
}
