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
 * Anti DDoS Protection Package Attack Log APIs
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

namespace  JDCloudSDK.Antipro.Apis
{

    /// <summary>
    ///  查询各类型攻击次数, 参数 ip 优先级大于 instanceId
        ///         ///   - 指定 ip 参数时, 忽略 instanceId 参数, 查询 ip 相关攻击记录的各类型攻击次数
        ///         ///   - 未指定 ip 时, 查询 instanceId 指定实例相关攻击记录的各类型攻击次数
        ///         ///   - ip 和 instanceId 均未指定时, 查询用户所有公网 IP 攻击记录的各类型攻击次数
        ///         /// 
    /// </summary>
    public class DescribeAttackTypeCountRequest : JdcloudRequest
    {
        ///<summary>
        /// 开始时间, 只能查询最近 90 天以内的数据, UTC 时间, 格式: yyyy-MM-dd&#39;T&#39;HH:mm:ssZ
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
        /// 防护包实例 Id
        ///</summary>
        public   string InstanceId{ get; set; }
        ///<summary>
        /// DDoS 防护包已防护的公网 IP
        /// - 使用 &lt;a href&#x3D;&quot;http://docs.jdcloud.com/anti-ddos-protection-package/api/describeprotectediplist&quot;&gt;describeProtectedIpList&lt;/a&gt; 接口查询 DDoS 防护包已防护的公网 IP
        /// 
        ///</summary>
        public List<string> Ip{ get; set; }

    }
}