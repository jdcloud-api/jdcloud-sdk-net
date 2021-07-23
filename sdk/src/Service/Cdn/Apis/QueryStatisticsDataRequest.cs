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
        /// 查询泛域名时，指定的子域名列表，多个用逗号分隔。非泛域名时，传入空即可
        ///</summary>
        public   string SubDomain{ get; set; }
        ///<summary>
        /// 需要查询的字段
        ///</summary>
        public   string Fields{ get; set; }
        ///<summary>
        /// 查询的区域，如beijing,shanghai。多个用逗号分隔
        ///</summary>
        public   string Area{ get; set; }
        ///<summary>
        /// 查询的运营商，cmcc,cnc,ct，表示移动、联通、电信。多个用逗号分隔
        ///</summary>
        public   string Isp{ get; set; }
        ///<summary>
        /// 是否查询回源统计信息。取值为true和false，默认为false。注意，如果查询回源信息，Fields的取值当前只支持oribandwidth，oripv，oricodestat三个，其余Fields忽略。
        ///</summary>
        public   bool Origin{ get; set; }
        ///<summary>
        /// 时间粒度，可选值:[oneMin,fiveMin,followTime],followTime只会返回一个汇总后的数据
        ///</summary>
        public   string Period{ get; set; }
        ///<summary>
        /// true 代表查询境外数据，默认false查询境内数据
        ///</summary>
        public   bool Abroad{ get; set; }
        ///<summary>
        /// 查询节点层级，可选值:[all,edge,mid],默认查询all,edge边缘 mid中间
        ///</summary>
        public   string CacheType{ get; set; }
    }
}