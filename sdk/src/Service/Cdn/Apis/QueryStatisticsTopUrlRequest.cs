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
 * 统计查询类接口
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
    ///  查询TOP Url，仅可查询中国境内的相关信息
    /// </summary>
    public class QueryStatisticsTopUrlRequest : JdcloudRequest
    {
        ///<summary>
        /// 查询起始时间,UTC时间，格式为:yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，示例:2018-10-21T10:00:00Z
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// 查询截止时间,UTC时间，格式为:yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，示例:2018-10-21T10:00:00Z
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 需要查询的域名, 必须为用户pin下有权限的域名
        ///</summary>
        public   string Domain{ get; set; }
        ///<summary>
        /// 待查询的子域名,查询泛域名时，指定的子域名列表，多个用逗号分隔。非泛域名时，传入空即可
        ///</summary>
        public   string SubDomain{ get; set; }
        ///<summary>
        /// 查询的topN的条数，取值范围：1-100，默认为20
        ///</summary>
        public   int? Size{ get; set; }
        ///<summary>
        /// 排序依据,当前可选：pv,flow，bandwidth, 分别表示按pv、按流量、按带宽topN url，默认为&quot;pv&quot;
        ///</summary>
        public   string TopBy{ get; set; }
    }
}