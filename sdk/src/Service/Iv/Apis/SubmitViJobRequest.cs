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
 * Vi Job
 * 视频审查作业相关接口
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

namespace  JDCloudSDK.Iv.Apis
{

    /// <summary>
    ///  提交视频审查作业
    /// </summary>
    public class SubmitViJobRequest : JdcloudRequest
    {
        ///<summary>
        /// 视频审查模板ID
        ///Required:true
        ///</summary>
        [Required]
        public   string TemplateId{ get; set; }
        ///<summary>
        /// 对象存储区域，输入和输入同区域
        ///Required:true
        ///</summary>
        [Required]
        public   string Region{ get; set; }
        ///<summary>
        /// 输入空间
        ///</summary>
        public   string InputBucket{ get; set; }
        ///<summary>
        /// 输入文件
        ///</summary>
        public   string InputFileKey{ get; set; }
        ///<summary>
        /// 输入空间
        ///</summary>
        public   string OutputBucket{ get; set; }
        ///<summary>
        /// 输入路径
        ///</summary>
        public   string OutputFilePath{ get; set; }
    }
}