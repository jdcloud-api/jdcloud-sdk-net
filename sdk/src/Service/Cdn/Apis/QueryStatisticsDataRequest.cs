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
    ///  查询统计数据
    /// </summary>
    public class QueryStatisticsDataRequest : JdcloudRequest
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
        /// 待查询的子域名
        ///</summary>
        public   string SubDomain{ get; set; }
        ///<summary>
        /// 需要查询的字段
        ///</summary>
        public   string Fields{ get; set; }
        ///<summary>
        /// Area
        ///</summary>
        public   string Area{ get; set; }
        ///<summary>
        /// Isp
        ///</summary>
        public   string Isp{ get; set; }
        ///<summary>
        /// Origin
        ///</summary>
        public   string Origin{ get; set; }
        ///<summary>
        /// 时间粒度，可选值:[oneMin,fiveMin,followTime],followTime只会返回一个汇总后的数据
        ///</summary>
        public   string Period{ get; set; }
        ///<summary>
        /// true 代表查询境外数据，默认false查询境内数据
        ///</summary>
        public   bool Abroad{ get; set; }
    }
}