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
using Newtonsoft.Json;

namespace JDCloudSDK.Dbs.Model
{

    /// <summary>
    ///  backupFile
    /// </summary>
    public class BackupFile
    {

        ///<summary>
        /// PlanId
        ///Required:true
        ///</summary>
        [Required]
        public string PlanId{ get; set; }
        ///<summary>
        /// BackupType
        ///Required:true
        ///</summary>
        [Required]
        public string BackupType{ get; set; }
        ///<summary>
        /// DataSourceId
        ///Required:true
        ///</summary>
        [Required]
        public string DataSourceId{ get; set; }
        ///<summary>
        /// 0代表自动备份 1代表的是手动触发备份
        ///Required:true
        ///</summary>
        [Required]
        public int IsManual{ get; set; }
        ///<summary>
        /// Filename
        ///Required:true
        ///</summary>
        [Required]
        public string Filename{ get; set; }
        ///<summary>
        /// ExtInfo
        ///Required:true
        ///</summary>
        [Required]
        public string ExtInfo{ get; set; }
        ///<summary>
        /// Path
        ///Required:true
        ///</summary>
        [Required]
        public string Path{ get; set; }
        ///<summary>
        /// Size
        ///Required:true
        ///</summary>
        [Required]
        public long Size{ get; set; }
        ///<summary>
        /// SrcSize
        ///</summary>
        public long? SrcSize{ get; set; }
        ///<summary>
        /// StorageType
        ///Required:true
        ///</summary>
        [Required]
        public string StorageType{ get; set; }
        ///<summary>
        /// TaskId
        ///Required:true
        ///</summary>
        [Required]
        public string TaskId{ get; set; }
        ///<summary>
        /// BinlogStartTime
        ///</summary>
        public string BinlogStartTime{ get; set; }
        ///<summary>
        /// BinlogEndTime
        ///</summary>
        public string BinlogEndTime{ get; set; }
        ///<summary>
        /// BinlogStartPos
        ///</summary>
        public int? BinlogStartPos{ get; set; }
        ///<summary>
        /// BinlogEndPos
        ///</summary>
        public int? BinlogEndPos{ get; set; }
        ///<summary>
        /// VersionValue
        ///</summary>
        [JsonProperty("version")]
        public string VersionValue{ get; set; }
    }
}