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

namespace JDCloudSDK.Waf.Model
{

    /// <summary>
    ///  setBotUsrRuleReq
    /// </summary>
    public class SetBotUsrRuleReq
    {

        ///<summary>
        /// 规则id，新增时为0或不传
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 域名
        ///Required:true
        ///</summary>
        [Required]
        public string Domain{ get; set; }
        ///<summary>
        /// 规则名
        ///Required:true
        ///</summary>
        [Required]
        public string RuleName{ get; set; }
        ///<summary>
        /// 次数阈值，[1-20000]
        ///Required:true
        ///</summary>
        [Required]
        public int DetectThrsd{ get; set; }
        ///<summary>
        /// 检测时长，秒，[1-20000]
        ///Required:true
        ///</summary>
        [Required]
        public int DetectPeriod{ get; set; }
        ///<summary>
        /// 匹配条件集,总长度不能超过4096
        ///Required:true
        ///</summary>
        [Required]
        public List<BotMatchItem> MatchItems{ get; set; }
        ///<summary>
        /// 动作配置，默认为告警,仅支持1和4和5三种动作
        ///Required:true
        ///</summary>
        [Required]
        public DenyActionCfg Action{ get; set; }
        ///<summary>
        /// 规则类型，general-通用规则，advanced-高级规则，evaluate-智能规则 缺省为general
        ///</summary>
        public string RuleType{ get; set; }
        ///<summary>
        /// 响应状态码
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 状态码数量阀值
        ///</summary>
        public int? Ststhrst{ get; set; }
        ///<summary>
        /// 状态码比例阀值
        ///</summary>
        public int? StsthrstRatio{ get; set; }
        ///<summary>
        /// 响应码功能是否启用
        ///</summary>
        public int? StatusDisable{ get; set; }
        ///<summary>
        /// 规则生效时间是否启用
        ///</summary>
        public int? DateDisable{ get; set; }
        ///<summary>
        /// 统计维度
        ///</summary>
        public string Unit{ get; set; }
        ///<summary>
        /// 持续时间, 单位分钟，范围[1-24*60]
        ///</summary>
        public int? BlockTime{ get; set; }
    }
}
