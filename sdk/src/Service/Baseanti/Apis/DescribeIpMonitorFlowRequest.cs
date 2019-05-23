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
 * Attack Log APIs
 * Anti DDoS Basic Attack Log APIs
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Baseanti.Apis
{

    /// <summary>
    ///  查询多个公网 IP 的监控流量, 支持 ipv4 和 ipv6
    /// </summary>
    public class DescribeIpMonitorFlowRequest : JdcloudRequest
    {
        ///<summary>
        /// 开始时间, UTC 时间, 格式: yyyy-MM-dd&#39;T&#39;HH:mm:ssZ
        ///Required:true
        ///</summary>
        [Required]
        public   string StartTime{ get; set; }
        ///<summary>
        /// 结束时间, UTC 时间, 格式: yyyy-MM-dd&#39;T&#39;HH:mm:ssZ
        ///Required:true
        ///</summary>
        [Required]
        public   string EndTime{ get; set; }
        ///<summary>
        /// 基础防护已防护的公网 IP
        /// - 使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describeelasticipresources&quot;&gt;describeElasticIpResources&lt;/a&gt; 接口查询基础防护已防护的私有网络弹性公网 IP
        /// - 使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-basic/api/describecpsipresources&quot;&gt;describeCpsIpResources&lt;/a&gt; 接口查询基础防护已防护的云物理服务器公网IP 和 弹性公网 IP
        /// 
        ///</summary>
        public List<string> Ip{ get; set; }

    }
}