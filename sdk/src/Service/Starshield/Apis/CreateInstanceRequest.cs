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
 * instance
 * 实例管理模块
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

namespace  JDCloudSDK.Starshield.Apis
{

    /// <summary>
    ///  创建套餐实例
    /// </summary>
    public class CreateInstanceRequest : JdcloudRequest
    {
        ///<summary>
        /// 计费模式（CONFIG、FLOW、MONTHLY、ONCE）
        ///</summary>
        public   string ChargeMode{ get; set; }
        ///<summary>
        /// 套餐类型（FREE、BASIC、PROFESSIONAL、ENTERPRISE、ULTIMATE、SMB_BASIC、SMB_BUSINESS）
        ///</summary>
        public   string PackType{ get; set; }
        ///<summary>
        /// 域名增量包数量
        ///</summary>
        public   int? ZonePackNum{ get; set; }
        ///<summary>
        /// 计费时长
        ///</summary>
        public   int? Duration{ get; set; }
        ///<summary>
        /// 计费时长单位（MONTH、YEAR）
        ///</summary>
        public   string DurationUnit{ get; set; }
        ///<summary>
        /// 自动续费状态(OPEN-&gt;开通自动续费 CLOSE-&gt;关闭自动续费)
        ///</summary>
        public   string AutoRenewStatus{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public   string InstanceName{ get; set; }
        ///<summary>
        /// 备注
        ///</summary>
        public   string Memo{ get; set; }
        ///<summary>
        /// 支付成功返回路径
        ///</summary>
        public   string ReturnUrl{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}