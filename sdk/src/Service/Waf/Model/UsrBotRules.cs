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
    ///  usrBotRules
    /// </summary>
    public class UsrBotRules
    {

        ///<summary>
        /// 规则id
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 规则名
        ///</summary>
        public string RuleName{ get; set; }
        ///<summary>
        /// 次数阈值
        ///</summary>
        public int? DetectThrsd{ get; set; }
        ///<summary>
        /// 检测时长，秒
        ///</summary>
        public int? DetectPeriod{ get; set; }
        ///<summary>
        /// 匹配条件集,总长度不能超过4096
        ///</summary>
        public List<BotMatchItem> MatchItems{ get; set; }
        ///<summary>
        /// 动作配置，默认为告警
        ///</summary>
        public DenyActionCfg Action{ get; set; }
        ///<summary>
        /// 0-使用中 1-禁用
        ///</summary>
        public int? Disable{ get; set; }
        ///<summary>
        /// 更新时间
        ///</summary>
        public int? UpdateTime{ get; set; }
    }
}
