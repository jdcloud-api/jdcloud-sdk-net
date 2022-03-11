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
    ///  userPolicyInfo
    /// </summary>
    public class UserPolicyInfo
    {

        ///<summary>
        /// 规则组id
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        /// 规则组名字
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 规则组里的规则个数
        ///</summary>
        public int? Count{ get; set; }
        ///<summary>
        /// 规则组应用的域名个数
        ///</summary>
        public int? DomainCnt{ get; set; }
        ///<summary>
        /// 规则是否自动更新, 0/1
        ///</summary>
        public int? AutoAdd{ get; set; }
        ///<summary>
        /// 导入规则集的等级，0/1/2/-1
        ///</summary>
        public int? ImportLevel{ get; set; }
        ///<summary>
        /// 规则id
        ///</summary>
        public List<int?> RuleIds{ get; set; }
        ///<summary>
        /// 更新时间
        ///</summary>
        public long? UpdateTime{ get; set; }
        ///<summary>
        /// 自定义规则集应用的域名信息
        ///</summary>
        public List<UserPolicyWafDomain> WafDomains{ get; set; }
    }
}
