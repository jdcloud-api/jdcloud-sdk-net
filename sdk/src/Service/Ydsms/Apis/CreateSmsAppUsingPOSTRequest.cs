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
 * 云鼎短信服务-应用相关接口
 * 云鼎短信服务-应用相关接口
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

namespace  JDCloudSDK.Ydsms.Apis
{

    /// <summary>
    ///  创建短信应用
    /// </summary>
    public class CreateSmsAppUsingPOSTRequest : JdcloudRequest
    {
        ///<summary>
        /// 应用描述
        ///Required:true
        ///</summary>
        [Required]
        public   string AppDesc{ get; set; }
        ///<summary>
        /// 云鼎应用id
        ///</summary>
        public   string AppId{ get; set; }
        ///<summary>
        /// 应用名称
        ///Required:true
        ///</summary>
        [Required]
        public   string AppName{ get; set; }
        ///<summary>
        /// accessKeyId
        ///</summary>
        public   string AccessKeyId{ get; set; }
        ///<summary>
        /// accessKeySecret
        ///</summary>
        public   string AccessKeySecret{ get; set; }
    }
}