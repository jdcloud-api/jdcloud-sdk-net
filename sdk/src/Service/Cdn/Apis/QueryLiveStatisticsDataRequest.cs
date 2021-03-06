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
    public class QueryLiveStatisticsDataRequest : JdcloudRequest
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
        /// app名,查询的App名称，多个用逗号分隔。注意，传如多个AppName时，表示查询这些AppName的和值，即“或”的关系。默认为空，表示查询所有App
        ///</summary>
        public   string AppName{ get; set; }
        ///<summary>
        /// 流名,查询的流名称，多个用逗号分隔。注意，传如多个StreamName时，表示查询这些StreamName的和值，即“或”的关系。默认为空，表示查询所有Stream
        ///</summary>
        public   string StreamName{ get; set; }
        ///<summary>
        /// 子域名,查询泛域名时，指定的子域名列表，多个用逗号分隔。非泛域名时，传入空即可
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
        /// 当前取值范围(&quot;GET,HEAD,forward,forward-hls,ingest,play,publish,detour-ingest,Forward-Origin&quot;)
        ///</summary>
        public   string ReqMethod{ get; set; }
        ///<summary>
        /// 查询的流协议类型,取值范围：&quot;rtmp,hdl,hls&quot;，多个用逗号分隔，默认为空，表示查询所有协议。
        ///</summary>
        public   string Scheme{ get; set; }
        ///<summary>
        /// cacheLevel,可选值：[L1,L2,L3]
        ///</summary>
        public   string CacheLevel{ get; set; }
        ///<summary>
        /// 时间粒度，可选值:[oneMin,fiveMin,followTime],followTime只会返回一个汇总后的数据
        ///</summary>
        public   string Period{ get; set; }
        ///<summary>
        /// 查询节点层级，可选值:[all,edge,mid],默认查询all,edge边缘 mid中间
        ///</summary>
        public   string CacheType{ get; set; }
    }
}