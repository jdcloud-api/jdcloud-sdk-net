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
 * Domain
 * Domain API
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

using JDCloudSDK.Waf.Model;

namespace  JDCloudSDK.Waf.Apis
{

    /// <summary>
    ///  获取网站
    /// </summary>
    public class ListMainCfgResult : JdcloudResult
    {
        ///<summary>
        /// 实例id
        ///</summary>
        public   string WafInstanceId{ get; set; }
        ///<summary>
        /// 网站配置详情列表
        ///</summary>
        public List<DomainMainConfig> List{ get; set; }

        ///<summary>
        /// 页码
        ///</summary>
        public   int? PageIndex{ get; set; }
        ///<summary>
        /// 页大小
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 最大支持的数目
        ///</summary>
        public   int? MaxLimit{ get; set; }
    }
}