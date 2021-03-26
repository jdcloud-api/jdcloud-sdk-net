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


namespace JDCloudSDK.Waf.Model
{

    /// <summary>
    ///  antiEvent
    /// </summary>
    public class AntiEvent
    {

        ///<summary>
        /// 源ip
        ///</summary>
        public string RemoteAddr{ get; set; }
        ///<summary>
        /// 情报标签
        ///</summary>
        public string CsaInfo{ get; set; }
        ///<summary>
        /// 风险等级
        ///</summary>
        public string RiskLevel{ get; set; }
        ///<summary>
        /// 来源地区
        ///</summary>
        public string Area{ get; set; }
        ///<summary>
        /// 产生时间
        ///</summary>
        public int? AccessTime{ get; set; }
        ///<summary>
        /// 方法
        ///</summary>
        public string Method{ get; set; }
        ///<summary>
        /// 攻击类型
        ///</summary>
        public string AttackType{ get; set; }
        ///<summary>
        /// url
        ///</summary>
        public string Url{ get; set; }
        ///<summary>
        /// 恶意负载
        ///</summary>
        public string PayLoad{ get; set; }
        ///<summary>
        /// 动作
        ///</summary>
        public string Action{ get; set; }
        ///<summary>
        /// 规则名称
        ///</summary>
        public string RuleName{ get; set; }
        ///<summary>
        /// 日志Id
        ///</summary>
        public string LogId{ get; set; }
        ///<summary>
        /// 该信息是否已上报AI平台，0表示否
        ///</summary>
        public int? IsReported{ get; set; }
        ///<summary>
        /// 实例id
        ///</summary>
        public string WafInstanceId{ get; set; }
        ///<summary>
        /// 状态码
        ///</summary>
        public string AntiStatus{ get; set; }
        ///<summary>
        /// 状态标识
        ///</summary>
        public string UpstreamErr{ get; set; }
    }
}
