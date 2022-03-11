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

namespace JDCloudSDK.Antipro.Model
{

    /// <summary>
    ///  createAclSpec
    /// </summary>
    public class CreateAclSpec
    {

        ///<summary>
        /// 规则优先级
        ///Required:true
        ///</summary>
        [Required]
        public int Priority{ get; set; }
        ///<summary>
        /// 源IP类型: 0: IP, 1: IP地址库
        ///Required:true
        ///</summary>
        [Required]
        public int SipType{ get; set; }
        ///<summary>
        /// 源IP, sipType 为 0 时有效, 否则为空
        ///</summary>
        public string Sip{ get; set; }
        ///<summary>
        /// IP地址库 Id, sipType 为 1 时必传, 可以使用自定义地址库或以下地址库。&lt;br&gt;&#39;-1&#39; IP高防回源地址&lt;br&gt;&#39;-2&#39; Web应用防火墙回源地址
        ///</summary>
        public string SipIpSetId{ get; set; }
        ///<summary>
        /// 目的IP类型: 0: IP, 1: IP地址库
        ///Required:true
        ///</summary>
        [Required]
        public int DipType{ get; set; }
        ///<summary>
        /// 目的IP, dipType 为 0 时有效, 否则为空
        ///</summary>
        public string Dip{ get; set; }
        ///<summary>
        /// IP地址库 Id, dipType 为 1 时必传, 可以使用自定义地址库或以下地址库。&lt;br&gt;&#39;-1&#39; IP高防回源地址&lt;br&gt;&#39;-2&#39; Web应用防火墙回源地址
        ///</summary>
        public string DipIpSetId{ get; set; }
        ///<summary>
        /// 协议类型: 支持 All Traffic, TCP, UDP, ICMP
        ///Required:true
        ///</summary>
        [Required]
        public string Protocol{ get; set; }
        ///<summary>
        /// 端口类型: 0: 端口或端口范围, 1: 端口库
        ///</summary>
        public int? PortType{ get; set; }
        ///<summary>
        /// 端口或端口范围, portType 为 0 时有效，否则为空
        ///</summary>
        public string Port{ get; set; }
        ///<summary>
        /// 端口库Id, portType 为 1 时必传
        ///</summary>
        public string PortSetId{ get; set; }
        ///<summary>
        /// 动作: 0: 放行, 1: 阻断. 阻断动作对ICMP协议所有端口生效, 所以动作为阻断, 且协议类型为 ICMP 时, 阻断动作端口类型, 端口或端口范围, 端口Id三个字段无效, 可不传
        ///Required:true
        ///</summary>
        [Required]
        public int Action{ get; set; }
        ///<summary>
        /// 备注
        ///Required:true
        ///</summary>
        [Required]
        public string Remark{ get; set; }
    }
}
