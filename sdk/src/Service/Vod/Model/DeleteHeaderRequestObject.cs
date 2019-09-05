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

namespace JDCloudSDK.Vod.Model
{

    /// <summary>
    ///  删除域名头参数请求
    /// </summary>
    public class DeleteHeaderRequestObject
    {

        ///<summary>
        /// 头参数名。当前支持的访问头参数取值范围：
        ///   Content-Disposition
        ///   Content-Language
        ///   Expires
        ///   Access-Control-Allow-Origin
        ///   Access-Control-Allow-Methods
        ///   Access-Control-Max-Age
        ///   Access-Control-Expose-Headers
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public string HeaderName{ get; set; }
        ///<summary>
        /// 头参数类型，取值范围：req、resp
        ///Required:true
        ///</summary>
        [Required]
        public string HeaderType{ get; set; }
    }
}
