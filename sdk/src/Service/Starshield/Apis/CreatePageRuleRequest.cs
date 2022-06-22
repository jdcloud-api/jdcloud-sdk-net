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
 * Page Rules for a Zone
 * A rule describing target patterns for requests and actions to perform on matching requests
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Starshield.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Starshield.Apis
{

    /// <summary>
    ///  创建页面规则
    /// </summary>
    public class CreatePageRuleRequest : JdcloudRequest
    {
        ///<summary>
        /// 根据请求评估的目标
        ///</summary>
        public List<Target> Targets{ get; set; }

        ///<summary>
        /// 如果此规则的目标与请求匹配，则要执行的操作集。操作可以将url重定向到另一个url或覆盖设置（但不能同时覆盖两者）
        ///</summary>
        public List<JDCloudSDK.Starshield.Model.Action> Actions{ get; set; }

        ///<summary>
        /// 一个数字，表示一个页面规则优先于另一个页面规则。
        /// 如果您可能有一个全面的页面规则（例如#1 “/images/”）
        /// 但是想要更具体的规则优先（例如#2 &#39;/images/special/&#39;），
        /// 您需要在后者（#2）上指定更高的优先级，以便它将覆盖第一个优先级。
        /// 
        ///</summary>
        public   int? Priority{ get; set; }
        ///<summary>
        /// 页面规则的状态
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// Zone_identifier
        ///Required:true
        ///</summary>
        [Required]
        public   string Zone_identifier{ get; set; }
    }
}