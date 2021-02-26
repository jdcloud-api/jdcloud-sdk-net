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
 * Cloud-Physical-Server
 * Http/Https证书操作相关的接口
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

using JDCloudSDK.Cps.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Cps.Apis
{

    /// <summary>
    ///  创建证书
        ///         /// 
    /// </summary>
    public class CreateCertRequest : JdcloudRequest
    {
        ///<summary>
        /// 由客户端生成，用于保证请求的幂等性，长度不能超过36个字符；&lt;br/&gt;
        /// 如果多个请求使用了相同的clientToken，只会执行第一个请求，之后的请求直接返回第一个请求的结果&lt;br/&gt;
        /// 
        ///</summary>
        public   string ClientToken{ get; set; }
        ///<summary>
        /// 弹性公网IP配置
        ///Required:true
        ///</summary>
        [Required]
        public   CertSpec CertSpec{ get; set; }
        ///<summary>
        /// 地域ID，可调用接口（describeRegiones）获取云物理服务器支持的地域
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}