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

namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  networkInterfaceSpec
    /// </summary>
    public class NetworkInterfaceSpec
    {

        ///<summary>
        /// 子网ID
        ///Required:true
        ///</summary>
        [Required]
        public string SubnetId{ get; set; }
        ///<summary>
        /// 可用区，用户的默认可用区，该参数无效，不建议使用
        ///</summary>
        public string Az{ get; set; }
        ///<summary>
        /// 网卡名称，只允许输入中文、数字、大小写字母、英文下划线“_”及中划线“-”，不允许为空且不超过32字符。
        ///</summary>
        public string NetworkInterfaceName{ get; set; }
        ///<summary>
        /// 网卡主IP，如果不指定，会自动从子网中分配
        ///</summary>
        public string PrimaryIpAddress{ get; set; }
        ///<summary>
        /// SecondaryIp列表
        ///</summary>
        public List<string> SecondaryIpAddresses{ get; set; }
        ///<summary>
        /// 自动分配的SecondaryIp数量
        ///</summary>
        public int? SecondaryIpCount{ get; set; }
        ///<summary>
        /// 要绑定的安全组ID列表，最多指定5个安全组
        ///</summary>
        public List<string> SecurityGroups{ get; set; }
        ///<summary>
        /// 源和目标IP地址校验，取值为0或者1,默认为1
        ///</summary>
        public int? SanityCheck{ get; set; }
        ///<summary>
        /// 描述,​ 允许输入UTF-8编码下的全部字符，不超过256字符
        ///</summary>
        public string Description{ get; set; }
    }
}
