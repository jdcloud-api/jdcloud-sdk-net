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
 * Sql
 * Sql操作
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

namespace  JDCloudSDK.Dms.Apis
{

    /// <summary>
    ///  获取数据导出Id
    /// </summary>
    public class GetExportDataIdRequest : JdcloudRequest
    {
        ///<summary>
        /// 数据源id
        ///</summary>
        public   int? DataSourceId{ get; set; }
        ///<summary>
        /// 导出数据的查询sql
        ///</summary>
        public   string Sql{ get; set; }
        ///<summary>
        /// 数据库名称
        ///</summary>
        public   string DbName{ get; set; }
        ///<summary>
        /// 导出数量
        ///</summary>
        public   int? Count{ get; set; }
        ///<summary>
        /// 是否跳过检测
        ///</summary>
        public   bool IgnoreCheck{ get; set; }
        ///<summary>
        /// 跳过行数检测原因
        ///</summary>
        public   string Reason{ get; set; }
        ///<summary>
        /// 导出文件字符编码
        ///</summary>
        public   string Charset{ get; set; }
        ///<summary>
        /// 导出方式，SYNC(&quot;SYNC&quot;, 0), ASYNC(&quot;ASYNC&quot;, 1)，当前只支持SYNC导出;
        ///</summary>
        public   string ExportTypeEnum{ get; set; }
        ///<summary>
        /// 导出文件格式，CSV(&quot;CSV&quot;, 0), SQL(&quot;SQL&quot;, 1);
        ///</summary>
        public   string ExportFileTypeEnum{ get; set; }
        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}