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

namespace JDCloudSDK.Kafka.Model
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
        /// ipVersion，空(代表v4)或者v4&amp;v6
        ///</summary>
        public string IpVersion{ get; set; }
        ///<summary>
        /// kafka版本，当前支持1.0.2
        ///Required:true
        ///</summary>
        [Required]
        public string InstanceVersion{ get; set; }
        ///<summary>
        /// kafka集群名称，不可为空，只支持大小写字母、数字、英文下划线或者中划线，以字母开头且不能超过32位
        ///Required:true
        ///</summary>
        [Required]
        public string InstanceName{ get; set; }
        ///<summary>
        /// azId
        ///Required:true
        ///</summary>
        [Required]
        public List<string> AzId{ get; set; }
        ///<summary>
        /// 集群规格配置
        ///Required:true
        ///</summary>
        [Required]
        public List<InstanceClassSpec> InstanceClassSpec{ get; set; }
        ///<summary>
        /// 扩展配置
        ///</summary>
        public ReqExtension Extension{ get; set; }
    }
}