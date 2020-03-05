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

namespace JDCloudSDK.Es.Model
{

    /// <summary>
    ///  instanceSpec
    /// </summary>
    public class InstanceSpec
    {

        ///<summary>
        /// 私有网络vpcId
        ///Required:true
        ///</summary>
        [Required]
        public string VpcId{ get; set; }
        ///<summary>
        /// 子网subnetId
        ///Required:true
        ///</summary>
        [Required]
        public string SubnetId{ get; set; }
        ///<summary>
        /// es版本，当前支持5.6.9和6.5.4
        ///Required:true
        ///</summary>
        [Required]
        public string InstanceVersion{ get; set; }
        ///<summary>
        /// es集群名称，不可为空，只支持大小写字母、数字、英文下划线或者中划线，以字母开头且不能超过32位
        ///Required:true
        ///</summary>
        [Required]
        public string InstanceName{ get; set; }
        ///<summary>
        /// 可用区，各可用区编码请参考：https://docs.jdcloud.com/cn/jcs-for-elasticsearch/restrictions
        ///Required:true
        ///</summary>
        [Required]
        public string AzId{ get; set; }
        ///<summary>
        /// 规格配置，规格代码请参考：https://docs.jdcloud.com/cn/jcs-for-elasticsearch/specifications
        ///Required:true
        ///</summary>
        [Required]
        public InstanceClassSpec InstanceClass{ get; set; }
        ///<summary>
        /// 是否支持ipv6，支持值为v4&amp;v6,不支持为空
        ///</summary>
        public string IpVersion{ get; set; }
        ///<summary>
        /// 是否包含专用主节点，默认false
        ///</summary>
        public bool DedicatedMaster{ get; set; }
        ///<summary>
        /// 是否包含协调节点，默认false
        ///</summary>
        public bool Coordinating{ get; set; }
        ///<summary>
        /// 自动快照设置。
        ///</summary>
        public AutoSnapshot AutoSnapshot{ get; set; }
        ///<summary>
        /// es数据面身份验证设置信息
        ///</summary>
        public AuthConfig AuthConfig{ get; set; }
    }
}