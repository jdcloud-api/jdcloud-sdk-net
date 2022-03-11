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
    ///  rateLimitRuleCfg
    /// </summary>
    public class RateLimitRuleCfg
    {

        ///<summary>
        /// 序号id,更新时需要
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 规则名称
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 限速host配置
        ///</summary>
        public MatchOpValCfg Host{ get; set; }
        ///<summary>
        /// 限速url配置
        ///</summary>
        public MatchOpValCfg Url{ get; set; }
        ///<summary>
        /// ip配置
        ///</summary>
        public string Ip{ get; set; }
        ///<summary>
        /// 限速大小
        ///</summary>
        public int? Rate{ get; set; }
        ///<summary>
        /// 限速burst大小
        ///</summary>
        public int? Burst{ get; set; }
        ///<summary>
        /// forbidden redirect，缺省为forbidden
        ///</summary>
        public string MatchAction{ get; set; }
        ///<summary>
        /// 跳转地址，matchAction为redirect时必须为当前实例下的域名的url，forbidden时为自定义页面名称，缺省为default
        ///</summary>
        public string Redirection{ get; set; }
    }
}
