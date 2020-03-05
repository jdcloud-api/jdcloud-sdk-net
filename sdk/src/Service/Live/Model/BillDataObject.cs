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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Live.Model
{

    /// <summary>
    ///  账单用量数据
    /// </summary>
    public class BillDataObject
    {

        ///<summary>
        /// APPID
        ///</summary>
        public int? AppId{ get; set; }
        ///<summary>
        /// 用户PIN
        ///</summary>
        public string UserPin{ get; set; }
        ///<summary>
        /// 计费类型:
        ///   1、线上计费
        ///   2、线下计费
        /// 
        ///</summary>
        public int? BillType{ get; set; }
        ///<summary>
        /// 计费项:
        ///   enum:
        ///     - video_h264_sd_1             (视频H.264-SD（640×360）及以下-普通转码)
        ///     - video_h264_hd_1             (视频H.264-HD（1280×720）及以下-普通转码)
        ///     - video_h264_shd_1            (视频H.264-SHD（1920×1080）及以下-普通转码)
        ///     - video_h264_2k_1             (视频H.264-2K（2560×1440）及以下-普通转码)
        ///     - video_h264_4k_1             (视频H.264-4K（4096×2160）及以下-普通转码)
        ///     - video_h265_sd_1             (视频H.265-SD（640×360）及以下-普通转码)
        ///     - video_h265_hd_1             (视频H.265-HD（1280×720）及以下-普通转码)
        ///     - video_h265_shd_1            (视频H.265-SHD（1920×1080）及以下-普通转码)
        ///     - video_h265_2k_1             (视频H.265-2K（2560×1440）及以下-普通转码)
        ///     - video_h265_4k_1             (视频H.265-4K（4096×2160）及以下-普通转码)
        ///     - audio                       (音频)
        ///     - copy                        (转封装)
        /// 
        ///     - vo                          (存储容量费用)
        ///     - t                           (视频播放加速费用)
        ///     - picture_key                 (关键帧截图费用)
        ///     - picture_nonkey              (非关键帧截图费用)
        ///     - sexy                        (图片鉴黄费用)
        ///     - high_grade                  (高级录制、时移、回看、延播高级功能包费用)
        /// 
        ///</summary>
        public string ProductId{ get; set; }
        ///<summary>
        /// 计费用量
        ///</summary>
        public double? Amount{ get; set; }
        ///<summary>
        /// 开始时间
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 结束时间
        ///</summary>
        public string EndTime{ get; set; }
        ///<summary>
        /// 创建计费项时间
        ///</summary>
        public string CreateTime{ get; set; }
    }
}
