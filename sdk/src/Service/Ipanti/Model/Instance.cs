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
    ///  instance
    /// </summary>
    public class Instance
    {

        ///<summary>
        /// 实例 ID
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 链路类型, 1: 电信, 2: 电信、联通, 3: 电信、联通和移动
        ///</summary>
        public int? Carrier{ get; set; }
        ///<summary>
        /// 可防护 IP 类型, 目前仅电信线路支持 IPV6 线路:
        /// - 0: IPV4,
        /// - 1: IPV4/IPV6
        /// 
        ///</summary>
        public int? IpType{ get; set; }
        ///<summary>
        /// 触发弹性带宽的次数
        ///</summary>
        public int? ElasticTriggerCount{ get; set; }
        ///<summary>
        /// 超峰次数
        ///</summary>
        public int? AbovePeakCount{ get; set; }
        ///<summary>
        /// 保底带宽
        ///</summary>
        public int? InBitslimit{ get; set; }
        ///<summary>
        /// 弹性带宽
        ///</summary>
        public int? ResilientBitslimit{ get; set; }
        ///<summary>
        /// 业务带宽大小
        ///</summary>
        public int? BusinessBitslimit{ get; set; }
        ///<summary>
        /// CC 阈值大小
        ///</summary>
        public int? CcThreshold{ get; set; }
        ///<summary>
        /// CC 防护峰值, 单位: QPS
        ///</summary>
        public int? CcPeakQPS{ get; set; }
        ///<summary>
        /// 非网站类规则数
        ///</summary>
        public int? RuleCount{ get; set; }
        ///<summary>
        /// 网站类规则数
        ///</summary>
        public int? WebRuleCount{ get; set; }
        ///<summary>
        /// PAID|ARREARS|EXPIRED
        ///</summary>
        public string ChargeStatus{ get; set; }
        ///<summary>
        /// SAFE|CLEANING|BLOCKING
        ///</summary>
        public string SecurityStatus{ get; set; }
        ///<summary>
        /// 实例的创建的时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 实例的过期时间
        ///</summary>
        public string ExpireTime{ get; set; }
        ///<summary>
        /// 资源 ID, 升级和续费时使用
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// CC 防护观察者模式.
        /// - 0: 关闭
        /// - 1: 开启
        /// 
        ///</summary>
        public int? CcObserveMode{ get; set; }
        ///<summary>
        /// CC 防护模式.
        /// - 0: 正常
        /// - 1: 紧急
        /// - 2: 宽松
        /// - 3: 自定义
        /// 
        ///</summary>
        public int? CcProtectMode{ get; set; }
        ///<summary>
        /// CC 开关状态.
        /// - 0: 关闭
        /// - 1: 开启
        /// 
        ///</summary>
        public int? CcProtectStatus{ get; set; }
        ///<summary>
        /// CC 防护模式为自定义时的限速大小
        ///</summary>
        public int? CcSpeedLimit{ get; set; }
        ///<summary>
        /// CC 防护模式为自定义时的限速周期
        ///</summary>
        public int? CcSpeedPeriod{ get; set; }
        ///<summary>
        /// IP 黑名单列表
        ///</summary>
        public List<string> IpBlackList{ get; set; }
        ///<summary>
        /// IP 黑名单状态.
        /// - 0: 关闭
        /// - 1: 开启
        /// 
        ///</summary>
        public int? IpBlackStatus{ get; set; }
        ///<summary>
        /// IP 白名单列表
        ///</summary>
        public List<string> IpWhiteList{ get; set; }
        ///<summary>
        /// IP 白名单状态.
        /// - 0: 关闭
        /// - 1: 开启
        /// 
        ///</summary>
        public int? IpWhiteStatus{ get; set; }
        ///<summary>
        /// url白名单列表
        ///</summary>
        public List<string> UrlWhitelist{ get; set; }
        ///<summary>
        /// url白名单状态，0关闭，1开启
        ///</summary>
        public int? UrlWhitelistStatus{ get; set; }
        ///<summary>
        /// ccProtectMode为自定义模式时，每个Host的防护阈值
        ///</summary>
        public int? HostQps{ get; set; }
        ///<summary>
        /// ccProtectMode为自定义模式时，每个Host+URI的防护阈值
        ///</summary>
        public int? HostUrlQps{ get; set; }
        ///<summary>
        /// ccProtectMode为自定义模式时，每个源IP对Host的防护阈值
        ///</summary>
        public int? IpHostQps{ get; set; }
        ///<summary>
        /// ccProtectMode为自定义模式时，每个源IP对Host+URI的防护阈值
        ///</summary>
        public int? IpHostUrlQps{ get; set; }
    }
}