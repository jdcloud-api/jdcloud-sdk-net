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
    ///  riskUsrListCfg
    /// </summary>
    public class RiskUsrListCfg
    {

        ///<summary>
        /// 规则id
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// WAF实例id
        ///</summary>
        public string WafInstanceId{ get; set; }
        ///<summary>
        /// 域名
        ///</summary>
        public string Domain{ get; set; }
        ///<summary>
        /// 名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 编码信息
        ///</summary>
        public string Code{ get; set; }
        ///<summary>
        /// 描述信息
        ///</summary>
        public string Desc{ get; set; }
        ///<summary>
        /// 0-使用中 1-禁用
        ///</summary>
        public int? Disable{ get; set; }
        ///<summary>
        /// 更新时间，s
        ///</summary>
        public int? UpdateTime{ get; set; }
        ///<summary>
        /// rules，format:[&quot;13311112222&quot;,&quot;13211112222&quot;]
        ///</summary>
        public List<string> Rules{ get; set; }
    }
}
