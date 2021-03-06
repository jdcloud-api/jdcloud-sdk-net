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

namespace JDCloudSDK.Domainservice.Model
{

    /// <summary>
    ///  records
    /// </summary>
    public class Records
    {

        ///<summary>
        /// 解析记录值
        ///Required:true
        ///</summary>
        [Required]
        public string Record{ get; set; }
        ///<summary>
        /// 权重，A/AAAA权重范围：0-100、CNAME/JNAME权重范围：1-100。
        ///</summary>
        public int? Weight{ get; set; }
        ///<summary>
        /// 这条解析记录的TTL
        ///</summary>
        public int? Ttl{ get; set; }
        ///<summary>
        /// 优先级，只存在于MX类型的解析记录
        ///</summary>
        public int? Prior{ get; set; }
        ///<summary>
        /// 端口，只存在于SRV类型解析记录
        ///</summary>
        public int? Port{ get; set; }
    }
}
