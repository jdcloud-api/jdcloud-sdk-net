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
 * Domain-Name
 * 域名系统接口
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
using Newtonsoft.Json;

namespace  JDCloudSDK.Domain.Apis
{

    /// <summary>
    ///  域名注册
        ///         /// 域名注册前，请确保用户的京东云账户有足够的资金支付，Openapi接口回返回订单号，可以用此订单号向计费系统查阅详情
        ///         /// 
    /// </summary>
    public class CreateDomainRequest : JdcloudRequest
    {
        ///<summary>
        /// 域名
        ///Required:true
        ///</summary>
        [Required]
        public   string DomainName{ get; set; }
        ///<summary>
        /// 注册年限，最多10年
        ///Required:true
        ///</summary>
        [Required]
        public   int Term{ get; set; }
        ///<summary>
        /// 模板ID
        ///Required:true
        ///</summary>
        [Required]
        public   long TemplateId{ get; set; }
        ///<summary>
        /// 实例所属的地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}