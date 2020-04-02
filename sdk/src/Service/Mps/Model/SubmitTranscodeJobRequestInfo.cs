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
    ///  提交转码作业请求信息
    /// </summary>
    public class SubmitTranscodeJobRequestInfo
    {

        ///<summary>
        /// 输入对象存储 accessKey，必须参数
        ///Required:true
        ///</summary>
        [Required]
        public string AccessKey{ get; set; }
        ///<summary>
        /// 输入对象存储 accessKey，必须参数
        ///Required:true
        ///</summary>
        [Required]
        public string SecretKey{ get; set; }
        ///<summary>
        /// 输入对象存储 endpoint。必须参数，内网域名，如 s3-internal.cn-north-1.jcloudcs.com
        ///Required:true
        ///</summary>
        [Required]
        public string Endpoint{ get; set; }
        ///<summary>
        /// 输入对象存储 bucket，必须参数
        ///Required:true
        ///</summary>
        [Required]
        public string Bucket{ get; set; }
        ///<summary>
        /// 输入对象存储 objectKey，必须参数
        ///Required:true
        ///</summary>
        [Required]
        public string ObjectKey{ get; set; }
        ///<summary>
        /// 输入视频标题，可选参数，默认会从 objectKey 中截取
        ///</summary>
        public string Title{ get; set; }
        ///<summary>
        /// 转码模板ID集合，必须参数，非空集合
        ///Required:true
        ///</summary>
        [Required]
        public List<string> TemplateIds{ get; set; }
        ///<summary>
        /// 输出配置，必须参数
        ///Required:true
        ///</summary>
        [Required]
        public TranscodeOutputConfig OutputConfig{ get; set; }
        ///<summary>
        /// 附加参数，JSON格式的字符串。除非清楚了解其用途和用法，请勿使用此字段。
        /// 若参数在本次作业提交所关联的模板中，存在相同用途的对应字段，则该属性值会覆盖模板中的对应字段；
        /// 若参数在本次作业提交所关联的模板中，不存在相同用途的对应字段，则该属性值会作为补充设置，用于生产任务；
        /// 有特殊说明的除外。
        /// 当前支持的附加参数：
        ///   - hls.encrypt.key - HLS加密公钥，对应于转码模板中 encryption.hlsKey 字段
        ///   - hls.encrypt.keyUrl - HLS加密公钥地址，对应于转码模板中 encryption.hlsKeyUrl 字段
        ///   - hls.encrypt.encodeType - HLS加密公钥编码方式，对应于转码模板中 encryption.hlsKeyEncodeType 字段
        /// 特殊说明：
        ///   -  HLS加密相关参数，具有完整性要求，故 hls.encrypt 命名空间下的附加参数，依赖于 hls.encrypt.key 参数的设置情况。若设置 hls.encrypt.key 参数，则命名空间 hls.encrypt 下的其他参数也须同时设置；否则，其他参数会被忽略。
        /// 
        ///</summary>
        public string AdditionalProperties{ get; set; }
    }
}
