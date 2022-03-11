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
 * GeneralSql
 * 生成sql相关接口
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

using JDCloudSDK.Dms.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Dms.Apis
{

    /// <summary>
    ///  生成修改表结构语句sql
    /// </summary>
    public class GeneralAlterTableSqlRequest : JdcloudRequest
    {
        ///<summary>
        /// 数据源Id
        ///</summary>
        public   int? DataSourceId{ get; set; }
        ///<summary>
        /// 数据库名
        ///</summary>
        public   string DbName{ get; set; }
        ///<summary>
        /// 表名
        ///</summary>
        public   string TableName{ get; set; }
        ///<summary>
        /// 表元信息。
        ///</summary>
        public   MetaTableInfo MetaTableInfo{ get; set; }
        ///<summary>
        /// 列信息。
        ///</summary>
        public List<ColumnInfo> ColumnInfos{ get; set; }

        ///<summary>
        /// 索引信息。
        ///</summary>
        public List<IndexInfo> IndexInfos{ get; set; }

        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}