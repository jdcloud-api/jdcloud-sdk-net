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


namespace JDCloudSDK.Ipanti.Model
{

    /// <summary>
    ///  ccsIpResource
    /// </summary>
    public class CcsIpResource
    {

        ///<summary>
        /// 云物理服务器公网 IP 地址
        ///</summary>
        public string Ip{ get; set; }
        ///<summary>
        /// 公网 IP 类型或绑定资源类型. &lt;br&gt;- 0: 未知类型&lt;br&gt;- 1: 弹性公网 IP(IP 为弹性公网 IP, 绑定资源类型未知)&lt;br&gt;- 10: 弹性公网 IP(IP 为弹性公网 IP, 但未绑定资源)&lt;br&gt;- 11: 弹性公网 IP, 绑定了云主机&lt;br&gt;- 12: 弹性公网 IP, 绑定了负载均衡&lt;br&gt;- 13: 弹性公网 IP, 绑定了原生容器实例&lt;br&gt;- 14: 弹性公网 IP, 绑定了原生容器 Pod&lt;br&gt;- 2: 云物理服务器公网 IP&lt;br&gt;- 4: 托管区公网 IP
        ///</summary>
        public int? ResourceType{ get; set; }
    }
}
