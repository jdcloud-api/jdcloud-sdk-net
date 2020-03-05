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
 * hufu-scene
 * 场景相关接口
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

namespace  JDCloudSDK.Hufu.Apis
{

    /// <summary>
    ///  生成sdk、文档
    /// </summary>
    public class GenerateSdkAndDocumentRequest : JdcloudRequest
    {
        ///<summary>
        /// 环境信息,test、online,默认为online
        ///</summary>
        public   string Environment{ get; set; }
        ///<summary>
        /// 语言，英文逗号分隔，默认为java
        ///</summary>
        public   string Language{ get; set; }
        ///<summary>
        /// 修订版本号,默认为线上最新版本
        ///</summary>
        public   string Revision{ get; set; }
        ///<summary>
        /// 场景ID
        ///Required:true
        ///</summary>
        [Required]
        public   int SceneId{ get; set; }
    }
}