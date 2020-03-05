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
    ///  导出转码时长数据
    /// </summary>
    public class ExportLiveTranscodingDurationDataRequest : JdcloudRequest
    {
        ///<summary>
        /// 码率档次，可以查询指定档次的转码时长，取值：
        /// - video_h264_4k_1
        /// - video_h264_2k_1
        /// - video_h264_shd_1
        /// - video_h264_hd_1
        /// - video_h264_sd_1
        /// - video_h265_4k_1
        /// - video_h265_2k_1
        /// - video_h265_shd_1
        /// - video_h265_hd_1
        /// - video_h265_sd_1
        /// 
        ///</summary>
        public   string Grade{ get; set; }
        ///<summary>
        /// 查询周期，取值范围：“day,month,year,followTime”，分别表示1天，1月，1年，跟随时间。默认为空，表示day。当传入followTime时，表示按Endtime-StartTime的周期，只返回一个点
        /// 
        ///</summary>
        public   string Period{ get; set; }
        ///<summary>
        /// 查询起始时间，UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string StartTime{ get; set; }
        ///<summary>
        /// 查询截至时间，UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，为空时默认为当前时间
        /// 
        ///</summary>
        public   string EndTime{ get; set; }
    }
}