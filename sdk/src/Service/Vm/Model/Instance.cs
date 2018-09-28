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
using JDCloudSDK.Disk.Model;

namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  instance
    /// </summary>
    public class Instance
    {

        ///<summary>
        /// 云主机ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 云主机名称
        ///</summary>
        public string InstanceName{ get; set; }
        ///<summary>
        /// 实例规格
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// 主网卡所属VPC的ID
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 主网卡所属子网的ID
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 主网卡主IP地址
        ///</summary>
        public string PrivateIpAddress{ get; set; }
        ///<summary>
        /// 主网卡主IP绑定弹性IP的ID
        ///</summary>
        public string ElasticIpId{ get; set; }
        ///<summary>
        /// 主网卡主IP绑定弹性IP的地址
        ///</summary>
        public string ElasticIpAddress{ get; set; }
        ///<summary>
        /// 云主机状态，&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/vm_status&quot;&gt;参考云主机状态&lt;/a&gt;
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 云主机描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 镜像ID
        ///</summary>
        public string ImageId{ get; set; }
        ///<summary>
        /// 系统盘配置
        ///</summary>
        public InstanceDiskAttachment SystemDisk{ get; set; }
        ///<summary>
        /// 数据盘配置
        ///</summary>
        public List<InstanceDiskAttachment> DataDisks{ get; set; }
        ///<summary>
        /// 主网卡配置
        ///</summary>
        public InstanceNetworkInterfaceAttachment PrimaryNetworkInterface{ get; set; }
        ///<summary>
        /// 辅助网卡配置
        ///</summary>
        public List<InstanceNetworkInterfaceAttachment> SecondaryNetworkInterfaces{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? LaunchTime{ get; set; }
        ///<summary>
        /// 云主机所在可用区
        ///</summary>
        public string Az{ get; set; }
        ///<summary>
        /// 密钥对名称
        ///</summary>
        public List<string> KeyNames{ get; set; }
        ///<summary>
        /// 计费信息
        ///</summary>
        public JDCloudSDK.Charge.Model.Charge Charge{ get; set; }
        ///<summary>
        /// 高可用组，如果创建云主机使用了高可用组，此处可展示高可用组名称
        ///</summary>
        public Ag Ag{ get; set; }
        ///<summary>
        /// 高可用组中的错误域
        ///</summary>
        public string FaultDomain{ get; set; }
        ///<summary>
        /// Tag信息
        ///</summary>
        public List<Tag> Tags{ get; set; }
    }
}
