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
    ///  listWafConditionsReq
    /// </summary>
    public class ListWafConditionsReq
    {

        ///<summary>
        /// WAF实例id
        ///Required:true
        ///</summary>
        [Required]
        public string WafInstanceId{ get; set; }
        ///<summary>
        /// 域名
        ///Required:true
        ///</summary>
        [Required]
        public string Domain{ get; set; }
        ///<summary>
        /// 页码，[1-100]，默认是1
        ///</summary>
        public int? PageIndex{ get; set; }
        ///<summary>
        /// 页大小，[1-100]，默认是10
        ///</summary>
        public int? PageSize{ get; set; }
        ///<summary>
        /// 可选，筛选条件，对值不做校验
        ///</summary>
        public string ConditionName{ get; set; }
        ///<summary>
        /// 可选，筛选条件，模糊匹配
        ///</summary>
        public string ConditionType{ get; set; }
        ///<summary>
        /// 可选，筛选条件
        ///</summary>
        public int? Id{ get; set; }
    }
}
