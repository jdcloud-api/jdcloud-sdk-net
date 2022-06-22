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
 * Firewall rules
 * Define Firewall rules using filter expressions for more control over how traffic is matched to the rule.
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

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Starshield.Apis
{

    /// <summary>
    ///  列出当前定义的所有防火墙规则。
    /// </summary>
    public class ListOfFirewallRulesRequest : JdcloudRequest
    {
        ///<summary>
        /// 防火墙规则标识符
        ///</summary>
        public   string Id{ get; set; }
        ///<summary>
        /// 描述中不区分大小写的搜索
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 规则操作上的精确匹配
        ///</summary>
        public   string Action{ get; set; }
        ///<summary>
        /// 此防火墙规则当前是否已暂停。
        ///</summary>
        public   bool Paused{ get; set; }
        ///<summary>
        /// 分页结果的页码
        ///</summary>
        public   double? Page{ get; set; }
        ///<summary>
        /// 每页的防火墙规则数
        ///</summary>
        public   double? Per_page{ get; set; }
        ///<summary>
        /// Zone_identifier
        ///Required:true
        ///</summary>
        [Required]
        public   string Zone_identifier{ get; set; }
    }
}