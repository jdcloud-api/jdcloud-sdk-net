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

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Starshield.Apis
{

    /// <summary>
    ///  获取页面规则列表
    /// </summary>
    public class ListPageRulesRequest : JdcloudRequest
    {
        ///<summary>
        /// 页面规则的状态
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// 用于按顺序排列页面规则的字段
        ///</summary>
        public   string Order{ get; set; }
        ///<summary>
        /// asc - 升序；desc - 降序
        ///</summary>
        public   string Direction{ get; set; }
        ///<summary>
        /// 是否匹配所有搜索要求或至少一个（任何）
        ///</summary>
        public   string Match{ get; set; }
        ///<summary>
        /// Zone_identifier
        ///Required:true
        ///</summary>
        [Required]
        public   string Zone_identifier{ get; set; }
    }
}