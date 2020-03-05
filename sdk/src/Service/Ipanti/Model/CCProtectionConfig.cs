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
    ///  cCProtectionConfig
    /// </summary>
    public class CCProtectionConfig
    {

        ///<summary>
        /// 网站规则的 CC 防护状态, 0: 关闭, 1: 开启
        ///</summary>
        public int? Enable{ get; set; }
        ///<summary>
        /// 观察者模式, 0: 关闭, 1: 开启
        ///</summary>
        public int? ObserverMode{ get; set; }
        ///<summary>
        /// 防护等级, 0: 正常, 1: 宽松, 2: 紧急, 3: 自定义
        ///</summary>
        public int? Level{ get; set; }
        ///<summary>
        /// HTTP 请求数阈值
        ///</summary>
        public long? CcThreshold{ get; set; }
        ///<summary>
        /// Host 的防护阈值
        ///</summary>
        public long? HostQps{ get; set; }
        ///<summary>
        /// Host + Url 的防护阈值
        ///</summary>
        public long? HostUrlQps{ get; set; }
        ///<summary>
        /// 每个源 IP 对 Host 的防护阈值
        ///</summary>
        public long? IpHostQps{ get; set; }
        ///<summary>
        /// 每个源 IP 对 Host + Url 的防护阈值
        ///</summary>
        public long? IpHostUrlQps{ get; set; }
        ///<summary>
        /// 开启的 CC 防护规则数量
        ///</summary>
        public long? CcProtectionRuleEnableCount{ get; set; }
    }
}
