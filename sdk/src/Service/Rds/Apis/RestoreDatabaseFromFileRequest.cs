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
 * 数据库管理
 * 数据库管理相关接口
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
    ///  从用户通过单库上云工具上传到云上的备份文件中恢复单个数据库&lt;br&gt;- 仅支持SQL Server
    /// </summary>
    public class RestoreDatabaseFromFileRequest : JdcloudRequest
    {
        ///<summary>
        /// 共享文件的全局ID，可从上传文件查询接口[describeImportFiles](../Cloud-on-Single-Database/describeImportFiles.md)获取；如果该文件不是共享文件，则不用输入该参数
        ///</summary>
        public   string SharedFileGid{ get; set; }
        ///<summary>
        /// 用户上传的备份文件名称（包括文件后缀名），例如mydb1.bak
        ///Required:true
        ///</summary>
        [Required]
        public   string FileName{ get; set; }
        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// RDS 实例ID，唯一标识一个RDS实例
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        /// 库名称
        ///Required:true
        ///</summary>
        [Required]
        public   string DbName{ get; set; }
    }
}