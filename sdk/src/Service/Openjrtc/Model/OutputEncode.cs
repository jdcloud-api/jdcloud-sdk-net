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


namespace JDCloudSDK.Openjrtc.Model
{

    /// <summary>
    ///  outputEncode
    /// </summary>
    public class OutputEncode
    {

        ///<summary>
        /// 混流类型：1：音频 2：视频  3：音视频
        ///</summary>
        public int? OutputKind{ get; set; }
        ///<summary>
        /// 音频采样率
        ///</summary>
        public int? AudioSampleRate{ get; set; }
        ///<summary>
        /// 音频比特率：取值范围[8,500]
        ///</summary>
        public int? AudioBitrate{ get; set; }
        ///<summary>
        /// 通道：取值范围[1,2]
        ///</summary>
        public int? AudioChannels{ get; set; }
        ///<summary>
        /// 视频比特率：取值范围[1,10000]
        ///</summary>
        public int? VideoBitrate{ get; set; }
        ///<summary>
        /// 视频帧率：取值范围[1,60]
        ///</summary>
        public int? VideoFrame{ get; set; }
        ///<summary>
        /// 视频宽：取值范围[1,1920]
        ///</summary>
        public int? VideoWidth{ get; set; }
        ///<summary>
        /// 视频高：取值范围[1,1080]
        ///</summary>
        public int? VideoHeight{ get; set; }
        ///<summary>
        /// 取值范围[1,5]
        ///</summary>
        public int? VideoGop{ get; set; }
    }
}
