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
 * WAF Rules
 * A firewall rule for a zone
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
    ///  包内的搜索、排序和筛选规则
    /// </summary>
    public class ListRulesRequest : JdcloudRequest
    {
        ///<summary>
        /// 已将规则覆盖到的设置
        ///</summary>
        public   string Mode{ get; set; }
        ///<summary>
        /// 在相关组中执行单个规则的顺序
        ///</summary>
        public   string Priority{ get; set; }
        ///<summary>
        /// 是否匹配所有搜索要求或至少一个（任何）
        ///</summary>
        public   string Match{ get; set; }
        ///<summary>
        /// 按指定字段排序
        ///</summary>
        public   string Order{ get; set; }
        ///<summary>
        /// 分页结果的页码
        ///</summary>
        public   double? Page{ get; set; }
        ///<summary>
        /// 每页的规则数
        ///</summary>
        public   double? Per_page{ get; set; }
        ///<summary>
        /// WAF组标识符标签
        ///</summary>
        public   string Group_id{ get; set; }
        ///<summary>
        /// 规则的公开说明
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// asc-升序；desc-降序
        ///</summary>
        public   string Direction{ get; set; }
        ///<summary>
        /// Zone_id
        ///Required:true
        ///</summary>
        [Required]
        public   string Zone_id{ get; set; }
        ///<summary>
        /// Package_id
        ///Required:true
        ///</summary>
        [Required]
        public   string Package_id{ get; set; }
    }
}