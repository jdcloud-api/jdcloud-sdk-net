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

namespace JDCloudSDK.Ipanti.Model
{

    /// <summary>
    ///  forwardRuleSpec
    /// </summary>
    public class ForwardRuleSpec
    {

        ///<summary>
        /// 协议: TCP 或者 UDP
        ///Required:true
        ///</summary>
        [Required]
        public string Protocol{ get; set; }
        ///<summary>
        /// 高防 IP, serviceIps 为空时生效
        ///</summary>
        public string ServiceIp{ get; set; }
        ///<summary>
        /// 高防 IP 列表, 不为空时忽略 serviceIp, 传多个时后台会在高防IP封禁后随机切换其他未封禁的IP
        ///</summary>
        public List<string> ServiceIps{ get; set; }
        ///<summary>
        /// 端口号, 取值范围[1, 65535]
        ///Required:true
        ///</summary>
        [Required]
        public int Port{ get; set; }
        ///<summary>
        /// 转发规则. &lt;br&gt;- wrr: 带权重的轮询&lt;br&gt;- rr:  不带权重的轮询&lt;br&gt;- sh:  源地址hash
        ///Required:true
        ///</summary>
        [Required]
        public string Algorithm{ get; set; }
        ///<summary>
        /// 回源类型: A 或者 CNAME
        ///Required:true
        ///</summary>
        [Required]
        public string OriginType{ get; set; }
        ///<summary>
        /// OriginAddr
        ///</summary>
        public List<OriginAddrItem> OriginAddr{ get; set; }
        ///<summary>
        /// 备用的回源地址列表, 可以配置为一个域名或者多个 ip 地址
        ///</summary>
        public List<string> OnlineAddr{ get; set; }
        ///<summary>
        /// 回源域名
        ///</summary>
        public string OriginDomain{ get; set; }
        ///<summary>
        /// 回源端口号, 取值范围[1, 65535]
        ///Required:true
        ///</summary>
        [Required]
        public int OriginPort{ get; set; }
    }
}
