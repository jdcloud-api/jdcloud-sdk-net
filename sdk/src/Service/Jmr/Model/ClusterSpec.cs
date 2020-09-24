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

namespace JDCloudSDK.Jmr.Model
{

    /// <summary>
    ///  clusterSpec
    /// </summary>
    public class ClusterSpec
    {

        ///<summary>
        /// 集群名称(不能少于6字符不能超过20字符，除下划线外不能包含特殊符号)
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 集群root用户密码(须包含大小写字母、数字及特殊字符其中三类，且不能少于8字符不能超过30字符)
        ///Required:true
        ///</summary>
        [Required]
        public string Password{ get; set; }
        ///<summary>
        /// 集群版本，默认版本为JMR2.0.0
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("version")]
        public string VersionValue{ get; set; }
        ///<summary>
        /// 集群计费类型，支持按配置和包年包月计费
        ///Required:true
        ///</summary>
        [Required]
        public string PayType{ get; set; }
        ///<summary>
        /// 主节点数量
        ///Required:true
        ///</summary>
        [Required]
        public int MasterNodeCount{ get; set; }
        ///<summary>
        /// Master节点CPU
        ///</summary>
        public int? MasterCore{ get; set; }
        ///<summary>
        /// Master节点内存(推荐至少8G内存，否则服务可能会部署失败)
        ///</summary>
        public int? MasterMemory{ get; set; }
        ///<summary>
        /// Master系统硬盘类型：ssd.gp1,ssd.io1和hdd.std1
        ///Required:true
        ///</summary>
        [Required]
        public string MasterSystemDiskType{ get; set; }
        ///<summary>
        /// Master系统硬盘大小，单位GB
        ///Required:true
        ///</summary>
        [Required]
        public int MasterSystemDiskVolume{ get; set; }
        ///<summary>
        /// Master系统硬盘iops，只有在硬盘类型是ssd.gp1,ssd.io1时，才需要有iops，200起步，步长为10
        ///Required:true
        ///</summary>
        [Required]
        public int MasterSystemDiskIops{ get; set; }
        ///<summary>
        /// Master数据盘类型：ssd.gp1,ssd.io1和hdd.std1
        ///Required:true
        ///</summary>
        [Required]
        public string MasterDiskType{ get; set; }
        ///<summary>
        /// Master数据盘大小，单位GB
        ///Required:true
        ///</summary>
        [Required]
        public int MasterDiskVolume{ get; set; }
        ///<summary>
        /// Master数据盘ipos，只有在硬盘类型是ssd.gp1,ssd.io1时，才需要有iops，200起步，步长为10
        ///Required:true
        ///</summary>
        [Required]
        public int MasterDiskIops{ get; set; }
        ///<summary>
        /// master节点规格
        ///Required:true
        ///</summary>
        [Required]
        public string MasterInstanceType{ get; set; }
        ///<summary>
        /// Slave节点数量
        ///Required:true
        ///</summary>
        [Required]
        public int SlaveNodeCount{ get; set; }
        ///<summary>
        /// Slave节点CPU
        ///</summary>
        public int? SlaveCore{ get; set; }
        ///<summary>
        /// Slave节点内存(推荐至少4G内存，否则服务可能会部署失败)
        ///</summary>
        public int? SlaveMemory{ get; set; }
        ///<summary>
        /// Slave系统硬盘类型：ssd.gp1,ssd.io1和hdd.std1
        ///Required:true
        ///</summary>
        [Required]
        public string SlaveSystemDiskType{ get; set; }
        ///<summary>
        /// Slave系统硬盘大小，单位GB
        ///Required:true
        ///</summary>
        [Required]
        public int SlaveSystemDiskVolume{ get; set; }
        ///<summary>
        /// Slave系统硬盘iops，只有在硬盘类型是ssd.gp1,ssd.io1时，才需要有iops，200起步，步长为10
        ///Required:true
        ///</summary>
        [Required]
        public int SlaveSystemDiskIops{ get; set; }
        ///<summary>
        /// Slave数据盘类型：ssd.gp1,ssd.io1和hdd.std1
        ///Required:true
        ///</summary>
        [Required]
        public string SlaveDiskType{ get; set; }
        ///<summary>
        /// Slave数据盘大小，单位GB
        ///Required:true
        ///</summary>
        [Required]
        public int SlaveDiskVolume{ get; set; }
        ///<summary>
        /// Slave数据盘ipos，只有在硬盘类型是ssd.gp1,ssd.io1时，才需要有iops，200起步，步长为10
        ///Required:true
        ///</summary>
        [Required]
        public int SlaveDiskIops{ get; set; }
        ///<summary>
        /// slave节点规格
        ///Required:true
        ///</summary>
        [Required]
        public string CoreInstanceType{ get; set; }
        ///<summary>
        /// 关联JSS
        ///Required:true
        ///</summary>
        [Required]
        public bool JssFlag{ get; set; }
        ///<summary>
        /// 数据中心，即regionId
        ///Required:true
        ///</summary>
        [Required]
        public string DataCenter{ get; set; }
        ///<summary>
        /// 软件列表
        ///Required:true
        ///</summary>
        [Required]
        public string SoftwareList{ get; set; }
        ///<summary>
        /// 集群是否为高可用，默认为高可用集群
        ///Required:true
        ///</summary>
        [Required]
        public bool HaFlag{ get; set; }
        ///<summary>
        /// Vpc网络ID
        ///Required:true
        ///</summary>
        [Required]
        public string VpcId{ get; set; }
        ///<summary>
        /// Vpc子网ID
        ///Required:true
        ///</summary>
        [Required]
        public string VpcSubnetId{ get; set; }
        ///<summary>
        /// 数据中心的可用区
        ///Required:true
        ///</summary>
        [Required]
        public string Az{ get; set; }
    }
}
