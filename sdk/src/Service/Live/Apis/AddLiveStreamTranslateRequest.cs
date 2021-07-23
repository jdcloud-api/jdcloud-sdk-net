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
 * Live-Video
 * 直播管理API
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

namespace  JDCloudSDK.Live.Apis
{

    /// <summary>
    ///  添加流翻译配置
        ///         /// - 添加流级别的翻译模板配置
        ///         /// - 一个流最多可绑定一个翻译模板
        ///         /// - 重新推流后生效
        ///         /// 
    /// </summary>
    public class AddLiveStreamTranslateRequest : JdcloudRequest
    {
        ///<summary>
        /// 推流域名
        ///Required:true
        ///</summary>
        [Required]
        public   string PublishDomain{ get; set; }
        ///<summary>
        /// 应用名称
        ///Required:true
        ///</summary>
        [Required]
        public   string AppName{ get; set; }
        ///<summary>
        /// 流名称
        ///Required:true
        ///</summary>
        [Required]
        public   string StreamName{ get; set; }
        ///<summary>
        /// 翻译模版
        /// - 取值范围: 系统标准翻译模板, 用户自定义翻译模板
        /// - 系统标准翻译模板
        ///   system-zh-en (中译英)
        ///   system-en-zh (英译中)
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string Template{ get; set; }
    }
}