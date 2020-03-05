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
 * Transcode
 * 视频转码任务相关接口
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

using JDCloudSDK.Mps.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Mps.Apis
{

    /// <summary>
    ///  提交转码作业
    /// </summary>
    public class SubmitTranscodeJobRequest : JdcloudRequest
    {
        ///<summary>
        /// 输入对象存储 accessKey，必须参数
        ///Required:true
        ///</summary>
        [Required]
        public   string AccessKey{ get; set; }
        ///<summary>
        /// 输入对象存储 accessKey，必须参数
        ///Required:true
        ///</summary>
        [Required]
        public   string SecretKey{ get; set; }
        ///<summary>
        /// 输入对象存储 endpoint。必须参数，内网域名，如 s3-internal.cn-north-1.jcloudcs.com
        ///Required:true
        ///</summary>
        [Required]
        public   string Endpoint{ get; set; }
        ///<summary>
        /// 输入对象存储 bucket，必须参数
        ///Required:true
        ///</summary>
        [Required]
        public   string Bucket{ get; set; }
        ///<summary>
        /// 输入对象存储 objectKey，必须参数
        ///Required:true
        ///</summary>
        [Required]
        public   string ObjectKey{ get; set; }
        ///<summary>
        /// 输入视频标题，可选参数，默认会从 objectKey 中截取
        ///</summary>
        public   string Title{ get; set; }
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
        public   TranscodeOutputConfig OutputConfig{ get; set; }
    }
}