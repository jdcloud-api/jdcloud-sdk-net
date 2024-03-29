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
 * 配额
 * 与配额相关的接口
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

using JDCloudSDK.Common.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  
        ///         /// 查询资源配额。
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 调用该接口可查询 &#x60;云主机&#x60;、&#x60;镜像&#x60;、&#x60;密钥&#x60;、&#x60;实例模板&#x60;、&#x60;镜像共享&#x60; 的配额。
        ///         /// 
    /// </summary>
    public class DescribeQuotasRequest : JdcloudRequest
    {
        ///<summary>
        /// &lt;b&gt;filters 中支持使用以下关键字进行过滤&lt;/b&gt;
        /// &#x60;resourceTypes&#x60;: 资源类型，支持多个，可选范围：&#x60;instance、keypair、image、instanceTemplate、imageShare&#x60;
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

        ///<summary>
        /// 私有镜像Id。
        /// 查询镜像共享 &#x60;imageShare&#x60; 的配额时，此参数必传。
        /// 
        ///</summary>
        public   string ImageId{ get; set; }
        ///<summary>
        /// 地域ID。
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}