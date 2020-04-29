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


namespace JDCloudSDK.Vpc.Model
{

    /// <summary>
    ///  subnet
    /// </summary>
    public class Subnet
    {

        ///<summary>
        /// Subnet的Id
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 子网名称
        ///</summary>
        public string SubnetName{ get; set; }
        ///<summary>
        /// 子网所属VPC的Id
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 子网网段，vpc内子网网段不能重叠，cidr的取值范围：10.0.0.0/8、172.16.0.0/12和192.168.0.0/16及它们包含的子网，且子网掩码长度为16-28之间，如果VPC含有Cidr，则必须为VPC所在Cidr的子网
        ///</summary>
        public string AddressPrefix{ get; set; }
        ///<summary>
        /// 子网可用ip数量
        ///</summary>
        public double? AvailableIpCount{ get; set; }
        ///<summary>
        /// 子网描述信息
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 子网关联的路由表Id
        ///</summary>
        public string RouteTableId{ get; set; }
        ///<summary>
        /// 子网关联的acl Id
        ///</summary>
        public string AclId{ get; set; }
        ///<summary>
        /// 子网的起始地址，子网第1个地位为路由器网关保留，第2个地址为dhcp服务保留
        ///</summary>
        public string StartIp{ get; set; }
        ///<summary>
        /// 子网的结束地址，子网第1个地位为路由器网关保留，第2个地址为dhcp服务保留
        ///</summary>
        public string EndIp{ get; set; }
        ///<summary>
        /// 子网创建时间
        ///</summary>
        public string CreatedTime{ get; set; }
        ///<summary>
        /// 子网类型，取值：standard(标准子网)，edge(边缘子网)
        ///</summary>
        public string SubnetType{ get; set; }
        ///<summary>
        /// 子网可用区
        ///</summary>
        public string Az{ get; set; }
    }
}
