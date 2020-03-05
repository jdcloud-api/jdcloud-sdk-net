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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Mps.Model
{

    /// <summary>
    ///  创建转码模板请求信息
    /// </summary>
    public class CreateTranscodeTemplateRequestInfo
    {

        ///<summary>
        /// 模板标题。长度不超过 128 个字符，最少 2 个字符。UTF-8 编码。
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public string Title{ get; set; }
        ///<summary>
        /// 视频参数配置
        ///Required:true
        ///</summary>
        [Required]
        public VideoStreamSettings Video{ get; set; }
        ///<summary>
        /// 音频参数配置
        ///Required:true
        ///</summary>
        [Required]
        public AudioStreamSettings Audio{ get; set; }
        ///<summary>
        /// 容器封装配置
        ///Required:true
        ///</summary>
        [Required]
        public ContainerSettings Container{ get; set; }
        ///<summary>
        /// 加密配置
        ///</summary>
        public EncryptionSettings Encryption{ get; set; }
        ///<summary>
        /// 清晰度规格标记。取值范围：
        ///   SD - 标清
        ///   HD - 高清
        ///   FHD - 超清
        ///   2K
        ///   4K
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public string Definition{ get; set; }
        ///<summary>
        /// 转码方式。取值范围：
        ///   normal - 普通转码
        ///   jdchd - 京享超清
        ///   jdchs - 极速转码
        /// 默认值为 normal
        /// 
        ///</summary>
        public string TranscodeType{ get; set; }
    }
}
