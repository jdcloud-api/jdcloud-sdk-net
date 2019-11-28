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
 * 域名操作类接口
 * Openapi For JCLOUD cdn
 *
 * OpenAPI spec version: v1
 * Contact: pid-cdn@jd.com
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  查询域名组接口
    /// </summary>
    public class QueryDomainGroupListRequest : JdcloudRequest
    {
        ///<summary>
        /// 根据是否共享内存筛选
        ///</summary>
        public   string ShareCache{ get; set; }
        ///<summary>
        /// pageNumber
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// pageSize
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 根据主域名模糊查询
        ///</summary>
        public   string PrimaryDomain{ get; set; }
        ///<summary>
        /// 根据域名组模糊查询
        ///</summary>
        public   string DomainGroupName{ get; set; }
    }
}