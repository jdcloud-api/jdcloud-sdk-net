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

using JDCloudSDK.Pod.Model;

namespace JDCloudSDK.Pod.Model
{

    /// <summary>
    ///  pod 中的 dns 配置。
    /// </summary>
    public class DnsConfig
    {

        ///<summary>
        /// DNS服务器IP地址列表，重复的将会被移除。&lt;br&gt;
        /// eg [&quot;8.8.8.8&quot;, &quot;4.2.2.2&quot;]。列表长度：[0-20]，元素符合IPv4格式。
        /// 
        ///</summary>
        public List<string> Nameservers{ get; set; }
        ///<summary>
        /// DNS搜索域列表，用于主机名查找。&lt;br&gt;
        /// eg [&quot;ns1.svc.cluster.local&quot;, &quot;my.dns.search.suffix&quot;]。列表长度：[0-6]，列表中所有字符总长度不超过256个。
        /// 
        ///</summary>
        public List<string> Searches{ get; set; }
        ///<summary>
        /// DNS解析器选项列表。&lt;br&gt;
        /// eg  [&quot;ndots&quot;:&quot;2&quot;, &quot;edns0&quot;:&quot;&quot;]。列表长度：[0-10]
        ///</summary>
        public List<PodDnsConfigOption> Options{ get; set; }
    }
}
