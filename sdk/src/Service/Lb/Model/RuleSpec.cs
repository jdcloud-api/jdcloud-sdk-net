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

namespace JDCloudSDK.Lb.Model
{

    /// <summary>
    ///  ruleSpec
    /// </summary>
    public class RuleSpec
    {

        ///<summary>
        /// 域名，用于匹配URL的host字段,支持输入IPv4地址和域名。域名支持精确匹配和通配符匹配：1、仅支持输入大小写字母、数字、英文中划线“-”和点“.”，最少包括一个点&quot;.&quot;，不能以点&quot;.&quot;和中划线&quot;-&quot;开头或结尾，中划线&quot;-&quot;前后不能为点&quot;.&quot;，不区分大小写，且不能超过110字符；2、通配符匹配支持包括一个星&quot;\*&quot;，输入格式为\*.XXX或XXX.\*，不支持仅输入一个星“\*”。 host和path至少配置其一，host缺省为空（含义是匹配所有） ，path缺省为/\*（含义是匹配所有）
        ///</summary>
        public string Host{ get; set; }
        ///<summary>
        /// URL访问路径，用于匹配URL的path字段。URL路径支持精确匹配和前缀匹配：1、必须以/开头，仅支持输入大小写字母、数字和特殊字符：$-_.+!&#39;()%:@&amp;&#x3D;/，区分大小写，且不能超过128字符；2、前缀匹配支持包括一个星&quot;\*&quot;，输入格式为/XXX\*或/\*，仅输入&quot;/&quot;表示精确匹配。 host和path至少配置其一，host缺省为空（含义是匹配所有） ，path缺省为/\*（含义是匹配所有）
        ///</summary>
        public string Path{ get; set; }
        ///<summary>
        /// 匹配转发规则后执行的动作，取值为Forward或Redirect。现只支持Forward，表示转发到指定后端服务, 默认为Forward
        ///</summary>
        public string Action{ get; set; }
        ///<summary>
        /// 后端服务的Id
        ///Required:true
        ///</summary>
        [Required]
        public string BackendId{ get; set; }
    }
}
