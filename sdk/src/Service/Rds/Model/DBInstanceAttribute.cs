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

using JDCloudSDK.Charge.Model;

namespace JDCloudSDK.Rds.Model
{

    /// <summary>
    ///  dBInstanceAttribute
    /// </summary>
    public class DBInstanceAttribute
    {

        ///<summary>
        /// 实例ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 实例名称，具体规则可参见帮助中心文档:[名称及密码限制](../../../documentation/Database-and-Cache-Service/RDS/Introduction/Restrictions/SQLServer-Restrictions.md)
        ///</summary>
        public string InstanceName{ get; set; }
        ///<summary>
        /// 实例类型，例如主实例，只读实例等，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// 实例引擎类型，如MySQL或SQL Server等，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///</summary>
        public string Engine{ get; set; }
        ///<summary>
        /// 实例引擎版本，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///</summary>
        public string EngineVersion{ get; set; }
        ///<summary>
        /// 实例规格代码
        ///</summary>
        public string InstanceClass{ get; set; }
        ///<summary>
        /// 存储类型，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///</summary>
        public string InstanceStorageType{ get; set; }
        ///<summary>
        /// 实例数据加密. false：不加密; true：加密
        ///</summary>
        public bool StorageEncrypted{ get; set; }
        ///<summary>
        /// 磁盘，单位GB
        ///</summary>
        public int? InstanceStorageGB{ get; set; }
        ///<summary>
        /// CPU核数
        ///</summary>
        public int? InstanceCPU{ get; set; }
        ///<summary>
        /// 内存大小，单位MB
        ///</summary>
        public int? InstanceMemoryMB{ get; set; }
        ///<summary>
        /// 地域ID，参见[地域及可用区对照表](../Enum-Definitions/Regions-AZ.md)
        ///</summary>
        public string RegionId{ get; set; }
        ///<summary>
        /// 可用区ID，第一个为主实例在的可用区，参见[地域及可用区对照表](../Enum-Definitions/Regions-AZ.md)
        ///</summary>
        public List<string> AzId{ get; set; }
        ///<summary>
        /// VPC的ID
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 子网的ID
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 参数组的ID&lt;br&gt;- 仅支持MySQL
        ///</summary>
        public string ParameterGroupId{ get; set; }
        ///<summary>
        /// 参数组的名称&lt;br&gt;- 仅支持MySQL
        ///</summary>
        public string ParameterGroupName{ get; set; }
        ///<summary>
        /// 参数的状态，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)&lt;br&gt;- 仅支持MySQL
        ///</summary>
        public string ParameterStatus{ get; set; }
        ///<summary>
        /// 实例内网域名
        ///</summary>
        public string InternalDomainName{ get; set; }
        ///<summary>
        /// 实例公网域名
        ///</summary>
        public string PublicDomainName{ get; set; }
        ///<summary>
        /// 应用访问端口
        ///</summary>
        public string InstancePort{ get; set; }
        ///<summary>
        /// 访问模式，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)&lt;br&gt;- 仅支持MySQL
        ///</summary>
        public string ConnectionMode{ get; set; }
        ///<summary>
        /// 审计状态，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)&lt;br&gt;- 仅支持MySQL
        ///</summary>
        public string AuditStatus{ get; set; }
        ///<summary>
        /// 实例状态，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///</summary>
        public string InstanceStatus{ get; set; }
        ///<summary>
        /// 实例创建时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 计费配置
        ///</summary>
        public JDCloudSDK.Charge.Model.Charge Charge{ get; set; }
        ///<summary>
        /// MySQL只读实例对应的主实例ID&lt;br&gt;- 仅支持MySQL
        ///</summary>
        public string SourceInstanceId{ get; set; }
        ///<summary>
        /// 只读实例ID列表&lt;br&gt;- 仅支持MySQL
        ///</summary>
        public List<string> RoInstanceIds{ get; set; }
        ///<summary>
        /// 高可用集群中主节点的信息&lt;br&gt;- 仅支持SQL Server
        ///</summary>
        public DBInstanceNode PrimaryNode{ get; set; }
        ///<summary>
        /// 高可用集群中从节点的信息&lt;br&gt;- 仅支持SQL Server
        ///</summary>
        public DBInstanceNode SecondaryNode{ get; set; }
        ///<summary>
        /// 标签信息
        ///</summary>
        public List<Tag> Tags{ get; set; }
    }
}
