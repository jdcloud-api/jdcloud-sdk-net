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
    ///  创建MySQL的只读实例&lt;br&gt; - 仅支持MySQL&lt;br&gt; - 创建的只读实例跟主实例在同一个VPC同一个子网中&lt;br&gt; * 只读实例只支持按配置计费
    /// </summary>
    public class CreateROInstanceRequest : JdcloudRequest
    {
        ///<summary>
        /// 实例名称，具体规则可参见帮助中心文档:[名称及密码限制](../../../documentation/Database-and-Cache-Service/RDS/Introduction/Restrictions/SQLServer-Restrictions.md)
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceName{ get; set; }
        ///<summary>
        /// 只读实例规格FlavorId
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceClass{ get; set; }
        ///<summary>
        /// 存储类型，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)，缺省值为：LOCAL_SSD
        ///</summary>
        public   string InstanceStorageType{ get; set; }
        ///<summary>
        /// 磁盘空间
        ///Required:true
        ///</summary>
        [Required]
        public   int InstanceStorageGB{ get; set; }
        ///<summary>
        /// 可用区ID
        ///Required:true
        ///</summary>
        [Required]
        public   string AzId{ get; set; }
        ///<summary>
        /// VPC的ID，如果没有填写就保持和常规实例一样的VPC
        ///</summary>
        public   string VpcId{ get; set; }
        ///<summary>
        /// 子网ID，如果没有填写就保持和常规实例一样的subnet
        ///</summary>
        public   string SubnetId{ get; set; }
        ///<summary>
        /// 参数组ID，缺省采用和常规实例一样的参数组
        ///</summary>
        public   string ParameterGroup{ get; set; }
        ///<summary>
        /// 实例数据加密(存储类型为云硬盘才支持数据加密)。false：不加密；true：加密。缺省为false。
        ///</summary>
        public   bool StorageEncrypted{ get; set; }
        ///<summary>
        /// 创建只读实例的数目,缺省为1
        ///</summary>
        public   int? Count{ get; set; }
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