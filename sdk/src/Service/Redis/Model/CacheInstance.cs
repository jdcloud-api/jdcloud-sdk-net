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

namespace JDCloudSDK.Redis.Model
{

    /// <summary>
    ///  缓存Redis实例信息
    /// </summary>
    public class CacheInstance
    {

        ///<summary>
        /// 实例ID
        ///</summary>
        public string CacheInstanceId{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public string CacheInstanceName{ get; set; }
        ///<summary>
        /// 规格代码，2.8、4.0标准版是实例规格，4.0自定义分片集群版实例表示单分片规格
        ///</summary>
        public string CacheInstanceClass{ get; set; }
        ///<summary>
        /// 实例的总内存（MB），表示用户购买的可使用内存
        ///</summary>
        public int? CacheInstanceMemoryMB{ get; set; }
        ///<summary>
        /// 实例状态：creating表示创建中，running表示运行中，error表示错误，changing表示变更规格中，deleting表示删除中，configuring表示修改参数中，restoring表示备份恢复中
        ///</summary>
        public string CacheInstanceStatus{ get; set; }
        ///<summary>
        /// 实例描述
        ///</summary>
        public string CacheInstanceDescription{ get; set; }
        ///<summary>
        /// 创建时间（ISO 8601标准的UTC时间，格式为：YYYY-MM-DDTHH:mm:ssZ）
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// az信息
        ///</summary>
        public AzId AzId{ get; set; }
        ///<summary>
        /// 实例所属VPC ID
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 实例所属子网ID
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 实例的访问域名
        ///</summary>
        public string ConnectionDomain{ get; set; }
        ///<summary>
        /// 实例的访问端口
        ///</summary>
        public int? Port{ get; set; }
        ///<summary>
        /// 实例的计费信息
        ///</summary>
        public JDCloudSDK.Charge.Model.Charge Charge{ get; set; }
        ///<summary>
        /// 实例的详细版本号，形如x.x-x.x
        ///</summary>
        public string InstanceVersion{ get; set; }
        ///<summary>
        /// 连接实例时，是否需要密码认证，false表示无密码
        ///</summary>
        public bool Auth{ get; set; }
        ///<summary>
        /// 创建实例时选择的引擎版本：目前支持2.8和4.0
        ///</summary>
        public string RedisVersion{ get; set; }
        ///<summary>
        /// 实例类型：master-slave表示主从版，cluster表示集群版
        ///</summary>
        public string CacheInstanceType{ get; set; }
        ///<summary>
        /// 是否支持IPv6，0表示不支持（只能用IPv4），1表示支持
        ///</summary>
        public int? Ipv6On{ get; set; }
        ///<summary>
        /// 标签信息
        ///</summary>
        public List<Tag> Tags{ get; set; }
        ///<summary>
        /// 实例分片数，标准版固定为1，自定义分片集群版实例分片数由用户创建时选择，其他实例为固定分片数
        ///</summary>
        public int? ShardNumber{ get; set; }
        ///<summary>
        /// 单分片内存大小（MB）
        ///</summary>
        public int? MemoryMBPerShard{ get; set; }
        ///<summary>
        /// 扩展配置
        ///</summary>
        public RespExtension Extension{ get; set; }
    }
}
