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
 * Live-Video
 * 直播管理API
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

namespace  JDCloudSDK.Live.Apis
{

    /// <summary>
    ///  查询地域/运营商分组统计数据
    /// </summary>
    public class DescribeLiveStatisticGroupByAreaIspRequest : JdcloudRequest
    {
        ///<summary>
        /// 播放域名
        ///Required:true
        ///</summary>
        [Required]
        public   string DomainName{ get; set; }
        ///<summary>
        /// 应用名称
        ///Required:true
        ///</summary>
        [Required]
        public   string AppName{ get; set; }
        ///<summary>
        /// 流名称
        ///Required:true
        ///</summary>
        [Required]
        public   string StreamName{ get; set; }
        ///<summary>
        /// 运营商
        /// 
        ///</summary>
        public   string IspName{ get; set; }
        ///<summary>
        /// 查询的区域，如beijing,shanghai。多个用逗号分隔
        /// 
        ///</summary>
        public   string LocationName{ get; set; }
        ///<summary>
        /// 查询的流协议类型，取值范围：&quot;rtmp,hdl,hls&quot;，多个时以逗号分隔
        /// 
        ///</summary>
        public   string ProtocolType{ get; set; }
        ///<summary>
        /// 查询周期，当前取值范围：“oneMin,fiveMin,halfHour,hour,twoHour,sixHour,day,followTime”，分别表示1min，5min，半小时，1小时，2小时，6小时，1天，跟随时间。默认为空，表示fiveMin。当传入followTime时，表示按Endtime-StartTime的周期，只返回一个点
        /// 
        ///</summary>
        public   string Period{ get; set; }
        ///<summary>
        /// 起始时间
        /// - UTC时间
        ///   格式:yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        ///   示例:2018-10-21T10:00:00Z
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string StartTime{ get; set; }
        ///<summary>
        /// 结束时间:
        /// - UTC时间
        ///   格式:yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        ///   示例:2018-10-21T10:00:00Z
        /// - 为空,默认为当前时间，查询时间跨度不超过1天
        /// 
        ///</summary>
        public   string EndTime{ get; set; }
    }
}