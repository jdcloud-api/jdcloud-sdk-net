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

namespace JDCloudSDK.Vpc.Model
{

    /// <summary>
    ///  elasticIp
    /// </summary>
    public class ElasticIp
    {

        ///<summary>
        /// 弹性公网IP的Id
        ///</summary>
        public string ElasticIpId{ get; set; }
        ///<summary>
        /// 弹性公网IP的地址
        ///</summary>
        public string ElasticIpAddress{ get; set; }
        ///<summary>
        /// 弹性公网IP的限速（单位：Mbps)
        ///</summary>
        public int? BandwidthMbps{ get; set; }
        ///<summary>
        /// 弹性公网IP的线路，标准公网IP的线路、取值为bgp或no_bgp；边缘公网IP的线路、可通过describeEdgeIpProviders接口获取
        ///</summary>
        public string Provider{ get; set; }
        ///<summary>
        /// 私有IP的IPV4地址
        ///</summary>
        public string PrivateIpAddress{ get; set; }
        ///<summary>
        /// 配置弹性网卡Id
        ///</summary>
        public string NetworkInterfaceId{ get; set; }
        ///<summary>
        /// 实例Id
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 实例类型,取值为：compute、lb、container、pod
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// 计费配置
        ///</summary>
        public JDCloudSDK.Charge.Model.Charge Charge{ get; set; }
        ///<summary>
        /// 弹性公网IP的创建时间
        ///</summary>
        public string CreatedTime{ get; set; }
        ///<summary>
        /// 弹性公网IP的可用区属性，如果为空，表示全可用区
        ///</summary>
        public string Az{ get; set; }
        ///<summary>
        /// Tag信息
        ///</summary>
        public List<Tag> Tags{ get; set; }
        ///<summary>
        /// 弹性公网IP的IP类型，取值：standard(标准弹性IP)、edge(边缘弹性IP)
        ///</summary>
        public string IpType{ get; set; }
    }
}
