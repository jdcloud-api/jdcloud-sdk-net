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
    ///  listWafRuleCfg
    /// </summary>
    public class ListWafRuleCfg
    {

        ///<summary>
        /// 使用的条件集
        ///</summary>
        public List<ConditionNameSet> Conditions{ get; set; }
        ///<summary>
        /// 规则id
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 匹配动作
        ///</summary>
        public string MatchAction{ get; set; }
        ///<summary>
        /// 重定向连接
        ///</summary>
        public string Redirection{ get; set; }
        ///<summary>
        /// 规则名称
        ///</summary>
        public string RuleName{ get; set; }
        ///<summary>
        /// 规则更新时间
        ///</summary>
        public int? UpdateTime{ get; set; }
        ///<summary>
        /// 0-使用中，1-禁用
        ///</summary>
        public int? Disable{ get; set; }
    }
}