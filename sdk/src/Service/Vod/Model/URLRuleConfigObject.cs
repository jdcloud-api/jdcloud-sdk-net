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
    ///  URL鉴权规则配置对象
    /// </summary>
    public class URLRuleConfigObject
    {

        ///<summary>
        /// 鉴权类型。取值范围：
        ///   by_params - 参数鉴权
        ///   by_path - 路径鉴权
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public string AuthType{ get; set; }
        ///<summary>
        /// 鉴权密钥
        ///Required:true
        ///</summary>
        [Required]
        public string AuthKey{ get; set; }
    }
}
