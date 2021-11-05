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
 * 云主机
 * 与主机操作相关的接口
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

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  
        ///         /// 为云主机绑定弹性公网IP。
        ///         /// 
        ///         /// 详细操作说明请参考帮助文档：[绑定弹性公网IP](https://docs.jdcloud.com/cn/virtual-machines/associate-elastic-ip)
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 该接口只支持在实例的主网卡的主内网IP上绑定弹性公网IP。
        ///         /// - 一台云主机的主网卡的主内网IP只能绑定一个弹性公网IP，若已绑定弹性公网IP，操作绑定会返回错误。
        ///         /// - 弹性公网IP所在的可用区需要与云主机的可用区保持一致，或者弹性公网IP是全可用区类型的，才允许绑定操作。
        ///         /// 
    /// </summary>
    public class AssociateElasticIpRequest : JdcloudRequest
    {
        ///<summary>
        /// 弹性公网IP的ID。
        ///Required:true
        ///</summary>
        [Required]
        public   string ElasticIpId{ get; set; }
        ///<summary>
        /// 地域ID。
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 云主机ID。
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}