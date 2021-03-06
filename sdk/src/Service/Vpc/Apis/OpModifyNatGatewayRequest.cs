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
 * NAT-Gateway
 * NAT网关相关接口
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

namespace  JDCloudSDK.Vpc.Apis
{

    /// <summary>
    ///  运营修改NAT网关，修改带宽需要先停止网关
    /// </summary>
    public class OpModifyNatGatewayRequest : JdcloudRequest
    {
        ///<summary>
        /// 公网IP的限速（单位：Mbps），取值范围为[1-4000]
        ///Required:true
        ///</summary>
        [Required]
        public   int BandwidthMbps{ get; set; }
        ///<summary>
        /// 资源所属的用户pin
        ///Required:true
        ///</summary>
        [Required]
        public   string UserPin{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// natGateway ID
        ///Required:true
        ///</summary>
        [Required]
        public   string NatGatewayId{ get; set; }
    }
}