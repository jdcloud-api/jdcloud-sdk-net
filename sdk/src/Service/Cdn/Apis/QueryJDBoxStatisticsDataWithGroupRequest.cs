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
 * PCdn统计查询接口
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
    ///  无线宝按group查询的统计接口
    /// </summary>
    public class QueryJDBoxStatisticsDataWithGroupRequest : JdcloudRequest
    {
        ///<summary>
        /// 查询起始时间,时间戳
        ///</summary>
        public   long? StartTime{ get; set; }
        ///<summary>
        /// 查询截止时间,时间戳
        ///</summary>
        public   long? EndTime{ get; set; }
        ///<summary>
        /// 取值范围：area，isp，pin ,mac_addr，category，多个用,隔开,多个维度的查询，必须要限制较短的时间间隔
        ///</summary>
        public   string GroupBy{ get; set; }
        ///<summary>
        /// 查询的字段，取值范围(avgbandwidth,pv,flow)。多个用逗号分隔。默认为空，表示查询带宽流量
        ///</summary>
        public   string Fields{ get; set; }
        ///<summary>
        /// 区域
        ///</summary>
        public   string Area{ get; set; }
        ///<summary>
        /// 运营商
        ///</summary>
        public   string Isp{ get; set; }
        ///<summary>
        /// 查询周期，当前取值范围：“oneMin,fiveMin”，分别表示1min，5min。默认为空，表示fiveMin
        ///</summary>
        public   string Period{ get; set; }
        ///<summary>
        /// 业务类型
        ///</summary>
        public   string Category{ get; set; }
        ///<summary>
        /// 设备id
        ///</summary>
        public   string MacAddr{ get; set; }
        ///<summary>
        /// 插件pin
        ///</summary>
        public   string PluginPin{ get; set; }
    }
}