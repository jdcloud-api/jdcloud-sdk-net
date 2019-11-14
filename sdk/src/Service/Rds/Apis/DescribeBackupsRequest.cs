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
 * 备份管理
 * 备份管理相关接口
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

using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  查看该RDS实例下所有备份的详细信息，返回的备份列表按照备份开始时间（backupStartTime）降序排列。
    /// </summary>
    public class DescribeBackupsRequest : JdcloudRequest
    {
        ///<summary>
        /// RDS实例ID，唯一标识一个实例
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        /// 查询备份类型，0为手动备份，1为自动备份，不传表示全部. &lt;br&gt;**- 测试参数，仅支持SQL Server，后续可能被其他参数取代**
        ///</summary>
        public   int? Auto{ get; set; }
        ///<summary>
        /// 返回backupType等于指定值的备份列表。full为全量备份，diff为增量备份&lt;br&gt;**- 测试参数，仅支持SQL Server，后续可能被其他参数取代**
        ///</summary>
        public   string BackupTypeFilter{ get; set; }
        ///<summary>
        /// 返回dbName等于指定值的备份列表，不传或为空返回全部&lt;br&gt;**- 测试参数，仅支持SQL Server，后续可能被其他参数取代**
        ///</summary>
        public   string DbNameFilter{ get; set; }
        ///<summary>
        /// 返回备份开始时间大于该时间的备份列表&lt;br&gt;**- 测试参数，仅支持SQL Server，后续可能被其他参数取代**
        ///</summary>
        public   string BackupTimeRangeStartFilter{ get; set; }
        ///<summary>
        /// 返回备份开始时间小于等于该时间的备份列表&lt;br&gt;**- 测试参数，仅支持SQL Server，后续可能被其他参数取代**
        ///</summary>
        public   string BackupTimeRangeEndFilter{ get; set; }
        ///<summary>
        /// 显示数据的页码，默认为1，取值范围：[-1,∞)。pageNumber为-1时，返回所有数据页码；超过总页数时，显示最后一页。
        ///Required:true
        ///</summary>
        [Required]
        public   int PageNumber{ get; set; }
        ///<summary>
        /// 每页显示的数据条数，默认为10，取值范围：10、20、30、50、100
        ///Required:true
        ///</summary>
        [Required]
        public   int PageSize{ get; set; }
        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}