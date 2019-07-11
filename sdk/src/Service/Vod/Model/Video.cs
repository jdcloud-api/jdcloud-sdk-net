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
 * Video Transcode Template Management
 * 水印管理
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Vod.Model
{

    /// <summary>
    ///  视频参数配置
    /// </summary>
    public class Video
    {

        ///<summary>
        /// 视频编码
        ///</summary>
        public string Codec{ get; set; }
        ///<summary>
        /// 码率
        ///</summary>
        public int? Bitrate{ get; set; }
        ///<summary>
        /// 帧率
        ///</summary>
        public int? Fps{ get; set; }
        ///<summary>
        /// 宽度
        ///</summary>
        public int? Width{ get; set; }
        ///<summary>
        /// 高度
        ///</summary>
        public int? Height{ get; set; }
    }
}
