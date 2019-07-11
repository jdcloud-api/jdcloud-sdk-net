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
    ///  transcodeInfo
    /// </summary>
    public class TranscodeInfo
    {

        ///<summary>
        /// 视频编码格式
        ///   - 取值：h264,h265，默认h264
        /// 
        ///</summary>
        public string VideoCodec{ get; set; }
        ///<summary>
        /// 转码输出的码率值:
        ///   - 取值: [200,15000]
        ///   - 单位: kpbs
        /// 
        ///</summary>
        public int? VideoCodeRate{ get; set; }
        ///<summary>
        /// 转码输出的帧率值:
        ///   - 取值：[1,30]
        /// 
        ///</summary>
        public string VideoFrameRate{ get; set; }
        ///<summary>
        /// 转码输出视频宽度:
        ///   - 取值: [100,3840]
        ///   - 等比: 如果只填写一个参数,则按参数比例调节输出转码视频
        ///   - 随源: 如果两个参数都不填写，则按照源比例输出转码视频
        /// 
        ///</summary>
        public int? Width{ get; set; }
        ///<summary>
        /// 转码输出视频高度:
        ///   - 取值: [100,2160]
        ///   - 等比: 如果只填写一个参数,则按参数比例调节输出转码视频
        ///   - 随源: 如果两个参数都不填写，则按照源比例输出转码视频
        /// 
        ///</summary>
        public int? Height{ get; set; }
        ///<summary>
        /// 转码模板自定义名称:
        ///   - 自定义模板: 枚举类型校验，忽略大小写，自动删除空格,
        ///               取值要求：数字、大小写字母或短横线(&quot;-&quot;),
        ///               首尾不能有特殊字符(&quot;-&quot;)
        ///   - 注意: 不能与标准的转码模板和已定义命名重复
        /// 
        ///</summary>
        public string Template{ get; set; }
        ///<summary>
        /// 转码模板名称
        /// 
        ///</summary>
        public string TemplateName{ get; set; }
        ///<summary>
        /// 转码输出音频编码格式:
        ///   - 取值: aac、mp3
        ///   - 不区分大小写
        /// 
        ///</summary>
        public string AudioCodec{ get; set; }
        ///<summary>
        /// 转码输出音频格式:
        ///   - 取值: aac_lc，aac_low，aac_he，aac_he_v2
        ///   - 不区分大小写
        /// 
        ///</summary>
        public string AudioFormat{ get; set; }
        ///<summary>
        /// 转码输出音频采样率:
        ///   - 取值: [44100,48000]
        /// 
        ///</summary>
        public int? AudioSampleRate{ get; set; }
        ///<summary>
        /// 转码输出音频通道数:
        ///   - 1  单声道
        ///   - 2  双声道
        /// 
        ///</summary>
        public int? AudioChannel{ get; set; }
        ///<summary>
        /// 转码输出音频码率:
        ///   - 取值: [16,128]
        ///   - 单位: kbps
        /// 
        ///</summary>
        public int? AudioCodeRate{ get; set; }
        ///<summary>
        /// 京享超清
        /// - 取值: jdchd-1.0,off
        /// 
        ///</summary>
        public string Jdchd{ get; set; }
        ///<summary>
        /// 舒适音频
        /// - 取值: on,off
        /// 
        ///</summary>
        public string AudioComfort{ get; set; }
    }
}
