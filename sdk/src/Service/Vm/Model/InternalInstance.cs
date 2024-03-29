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


namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  云主机实例信息。
    /// </summary>
    public class InternalInstance
    {

        ///<summary>
        /// 云主机ID。
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 云主机名称。
        ///</summary>
        public string InstanceName{ get; set; }
        ///<summary>
        /// 实例规格。
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// 主网卡所属VPC的ID。
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 主网卡所属子网的ID。
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 主网卡主内网IP地址。
        ///</summary>
        public string PrivateIpAddress{ get; set; }
        ///<summary>
        /// 云主机状态，参考 [云主机状态](https://docs.jdcloud.com/virtual-machines/api/vm_status)。
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 云主机描述。
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 云主机使用的镜像ID。
        ///</summary>
        public string ImageId{ get; set; }
        ///<summary>
        /// 系统盘配置。
        ///</summary>
        public BriefInstanceDiskAttachment SystemDisk{ get; set; }
        ///<summary>
        /// 数据盘配置列表。
        ///</summary>
        public List<BriefInstanceDiskAttachment> DataDisks{ get; set; }
        ///<summary>
        /// 主网卡主IP关联的弹性公网IP配置。
        ///</summary>
        public BriefInstanceNetworkInterfaceAttachment PrimaryNetworkInterface{ get; set; }
        ///<summary>
        /// 辅助网卡配置列表。
        ///</summary>
        public List<BriefInstanceNetworkInterfaceAttachment> SecondaryNetworkInterfaces{ get; set; }
        ///<summary>
        /// 云主机实例的创建时间。
        ///</summary>
        public DateTime? LaunchTime{ get; set; }
        ///<summary>
        /// 云主机所在可用区。
        ///</summary>
        public string Az{ get; set; }
        ///<summary>
        /// 云主机使用的密钥对名称。
        ///</summary>
        public List<string> KeyNames{ get; set; }
        ///<summary>
        /// 高可用组中的错误域。
        ///</summary>
        public string FaultDomain{ get; set; }
        ///<summary>
        /// 停机不计费模式。该参数仅对按配置计费且系统盘为云硬盘的实例生效，并且不是专有宿主机中的实例。
        /// &#x60;keepCharging&#x60;：关机后继续计费。
        /// &#x60;stopCharging&#x60;：关机后停止计费。
        /// 
        ///</summary>
        public string ChargeOnStopped{ get; set; }
        ///<summary>
        /// 云主机所属的专有宿主机池。
        ///</summary>
        public string DedicatedPoolId{ get; set; }
        ///<summary>
        /// 云主机所属的专有宿主机ID。
        ///</summary>
        public string DedicatedHostId{ get; set; }
        ///<summary>
        /// 实例所在的物理机IP地址。
        ///</summary>
        public string HostIp{ get; set; }
        ///<summary>
        /// 实例所在机架信息。
        ///</summary>
        public string Rack{ get; set; }
    }
}
