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
 * 实名认证-服务管理接口
 * 实名认证-服务管理接口
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

namespace  JDCloudSDK.Cloudauth.Apis
{

    /// <summary>
    ///  代理人信息核验
    /// </summary>
    public class CheckAgentResult : JdcloudResult
    {
        ///<summary>
        /// 认证结果true 成功, false 失败
        ///Required:true
        ///</summary>
        [Required]
        public   bool Success{ get; set; }
        ///<summary>
        /// 是否有异常 true 有异常, false 无异常
        ///Required:true
        ///</summary>
        [Required]
        public   bool HasException{ get; set; }
        ///<summary>
        /// 认证结果状态码
        ///Required:true
        ///</summary>
        [Required]
        public   string Code{ get; set; }
        ///<summary>
        /// 1. 认证结果信息
        /// 2. 查询结果信息
        /// 3. 状态码信息
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string Message{ get; set; }
        ///<summary>
        /// 1. 认证结果信息
        /// 2. 查询结果信息
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string Detail{ get; set; }
    }
}