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
    ///  createInstanceSpec
    /// </summary>
    public class CreateInstanceSpec
    {

        ///<summary>
        /// 实例 Id, 升级时必传
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 实例名称, 新购时必传
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 购买类型. &lt;br&gt;- 1: 新购&lt;br&gt;- 3: 升级
        ///Required:true
        ///</summary>
        [Required]
        public int BuyType{ get; set; }
        ///<summary>
        /// 链路类型. &lt;br&gt;- 1: 电信&lt;br&gt;- 3: 电信、联通和移动&lt;br&gt;- 4: BGP 线路
        ///Required:true
        ///</summary>
        [Required]
        public int Carrier{ get; set; }
        ///<summary>
        /// 可防护 ip 类型, 目前仅电信线路支持 IPV6 线路&lt;br&gt;- 0: IPV4,&lt;br&gt;- 1: IPV4/IPV6
        ///</summary>
        public int? IpType{ get; set; }
        ///<summary>
        /// IP 数量
        ///</summary>
        public int? IpCount{ get; set; }
        ///<summary>
        /// 可配的转发端口数量
        ///</summary>
        public int? PortCount{ get; set; }
        ///<summary>
        /// 可配的网站规则域名数量
        ///</summary>
        public int? DomainCount{ get; set; }
        ///<summary>
        /// 保底带宽: 单位 Gbps
        ///Required:true
        ///</summary>
        [Required]
        public int Bp{ get; set; }
        ///<summary>
        /// 弹性带宽: 单位 Gbps
        ///Required:true
        ///</summary>
        [Required]
        public int Ep{ get; set; }
        ///<summary>
        /// 业务带宽: 单位 Mbps
        ///Required:true
        ///</summary>
        [Required]
        public int Bw{ get; set; }
        ///<summary>
        /// 购买时长, 新购高防实例时必传&lt;br&gt;- timeUnit 为 3 时, 可取值 1-9&lt;br&gt;- timeUnit 为 4 时, 可取值 1-3
        ///</summary>
        public int? TimeSpan{ get; set; }
        ///<summary>
        /// 购买时长类型, 新购高防实例时必传&lt;br&gt;- 3: 月&lt;br&gt;- 4: 年
        ///</summary>
        public int? TimeUnit{ get; set; }
        ///<summary>
        /// 支付成功后跳转的页面, 控制台交互模式传该字段
        ///</summary>
        public string ReturnUrl{ get; set; }
    }
}
