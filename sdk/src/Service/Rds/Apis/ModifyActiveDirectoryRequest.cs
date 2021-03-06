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

using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  修改SQL Server对接的Active Directory 服务。支持SQL Server 2012 及2012以上以上的版本。&lt;br&gt;注意：修改目录服务后，需重启SQL Server实例才能生效
    /// </summary>
    public class ModifyActiveDirectoryRequest : JdcloudRequest
    {
        ///<summary>
        /// 目录服务的资源ID&lt;br&gt;- 加入目录服务：要加入的目录服务的资源ID&lt;br&gt;- 修改目录服务：新目录服务的资源ID&lt;br&gt;- 移除目录服务：传入字符串“none”，不区分大小写
        ///Required:true
        ///</summary>
        [Required]
        public   string AdResourceId{ get; set; }
        ///<summary>
        /// 修改后，是否强制重启实例，使修改生效。&lt;br&gt; - true 修改后立即重启&lt;br&gt;- false：默认值，修改后不重启，需用户自行重启
        ///Required:true
        ///</summary>
        [Required]
        public   string ForceRestart{ get; set; }
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
    }
}