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
 * Renew Management APIs
 * 续费管理相关接口
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Renewal.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Renewal.Apis
{

    /// <summary>
    ///  对相关实例进行续费。调用该接口会创建一个续费订单，并自动扣除您账户可用代金券和余额完成支付，如因为某些原因支付失败，订单会自动取消。
    /// </summary>
    public class RenewInstanceRequest : JdcloudRequest
    {
        ///<summary>
        /// RenewInstanceParam
        ///Required:true
        ///</summary>
        [Required]
        public   RenewInstanceParam RenewInstanceParam{ get; set; }
        ///<summary>
        /// 地域
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}