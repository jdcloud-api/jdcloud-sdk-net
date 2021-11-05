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
 * Zone Settings
 * A Zone setting changes how the Zone works in relation to caching, security, or other features of JDC StarShield
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

namespace  JDCloudSDK.Starshield.Apis
{

    /// <summary>
    ///  当请求图像的客户端支持WebP图像编解码器时。当WebP比原始图像格式具有性能优势时，星盾将提供WebP版本的图像。
        ///         /// 
    /// </summary>
    public class ChangeWebPSettingRequest : JdcloudRequest
    {
        ///<summary>
        /// on - 开启；off - 关闭
        ///</summary>
        public   string Value{ get; set; }
        ///<summary>
        /// Zone_identifier
        ///Required:true
        ///</summary>
        [Required]
        public   string Zone_identifier{ get; set; }
    }
}