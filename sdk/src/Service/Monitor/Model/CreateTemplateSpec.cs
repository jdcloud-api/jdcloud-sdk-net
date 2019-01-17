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

namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  createTemplateSpec
    /// </summary>
    public class CreateTemplateSpec
    {

        ///<summary>
        /// 幂等性校验参数,最长36位
        ///Required:true
        ///</summary>
        [Required]
        public string ClientToken{ get; set; }
        ///<summary>
        /// 模板描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 规则的资源类型
        ///Required:true
        ///</summary>
        [Required]
        public string RuleServiceCode{ get; set; }
        ///<summary>
        /// 模板的资源类型
        ///Required:true
        ///</summary>
        [Required]
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 模板名称,长度1-32个字符，只允许中英文、数字、&#39;&#39;-&#39;&#39;和&quot;_&quot;
        ///Required:true
        ///</summary>
        [Required]
        public string TemplateName{ get; set; }
        ///<summary>
        /// 模板内包含的规则
        ///Required:true
        ///</summary>
        [Required]
        public List<BaseRuleT> TemplateRules{ get; set; }
    }
}