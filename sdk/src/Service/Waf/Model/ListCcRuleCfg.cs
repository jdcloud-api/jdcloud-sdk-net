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
    ///  listCcRuleCfg
    /// </summary>
    public class ListCcRuleCfg
    {

        ///<summary>
        /// WAF实例id
        ///</summary>
        public string WafInstanceId{ get; set; }
        ///<summary>
        /// 域名
        ///</summary>
        public string Domain{ get; set; }
        ///<summary>
        /// 规则名称
        ///</summary>
        public string RuleName{ get; set; }
        ///<summary>
        /// uri以/开头
        ///</summary>
        public string Uri{ get; set; }
        ///<summary>
        /// 匹配uri 类型 0 精确匹配，1 前缀匹配（目前就支持精确匹配）
        ///</summary>
        public int? MatchType{ get; set; }
        ///<summary>
        /// 检测周期，单位是秒，[30~600]
        ///</summary>
        public int? DetectPeriod{ get; set; }
        ///<summary>
        /// ip访问次数，[1~9999999]
        ///</summary>
        public int? SingleIpLimit{ get; set; }
        ///<summary>
        /// 阻断类型 3:封禁，2:人机交互
        ///</summary>
        public int? BlockType{ get; set; }
        ///<summary>
        /// block 持续时间，单位为分钟[1~9999999]
        ///</summary>
        public int? BlockTime{ get; set; }
        ///<summary>
        /// 更新时间，s
        ///</summary>
        public int? UpdateTime{ get; set; }
        ///<summary>
        /// 0-使用中 1-禁用
        ///</summary>
        public int? Disable{ get; set; }
        ///<summary>
        /// blockType 为3 时，为自定义页面名称，缺省为default
        ///</summary>
        public string Redirection{ get; set; }
        ///<summary>
        /// cc 统计维度，ip或cookie
        ///</summary>
        public string Dimension{ get; set; }
        ///<summary>
        /// cookiename, 只有当 dimension 为 cookie 时才有效
        ///</summary>
        public string Dmvalue{ get; set; }
    }
}
