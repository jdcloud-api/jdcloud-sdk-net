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


namespace JDCloudSDK.Starshield.Model
{

    /// <summary>
    ///  pageRuleOnlyPriority
    /// </summary>
    public class PageRuleOnlyPriority
    {

        ///<summary>
        /// API item identifier tag
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// A number that indicates the preference for a page rule over another.
        /// In the case where you may have a catch-all page rule (e.g., #1: &#39;/images/&#39;)
        /// but want a rule that is more specific to take precedence (e.g., #2: &#39;/images/special/&#39;),
        /// you&#39;ll want to specify a higher priority on the latter (#2) so it will override the first.
        /// 
        ///</summary>
        public int? Priority{ get; set; }
    }
}