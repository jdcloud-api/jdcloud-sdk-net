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
 * Elastic-Network-Interface-Permission
 * 弹性网卡授权相关接口
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
    ///  创建NetworkInterfacePermission接口
    /// </summary>
    public class CreateNetworkInterfacePermissionRequest : JdcloudRequest
    {
        ///<summary>
        /// 弹性网卡ID
        ///Required:true
        ///</summary>
        [Required]
        public   string NetworkInterfaceId{ get; set; }
        ///<summary>
        /// 授信用户,需要存在于京东云许可的服务账号名单中
        ///</summary>
        public   string TrustUser{ get; set; }
        ///<summary>
        /// 授权策略, 授权后，该弹性网卡可以关联的服务端账号的资源类型，取值范围，instance-attach：可以关联服务端账号的实例资源，eip-associate：可以关联服务端账号的弹性公网IP资源
        ///</summary>
        public List<string> Policy{ get; set; }

        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}