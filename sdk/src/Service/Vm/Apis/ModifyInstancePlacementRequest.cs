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
        ///         /// 存量主机加入高可用组。
        ///         /// 
        ///         /// 存量主机加入高可用组，或者主机从一个高可用组移动到另一个高可用组
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 不支持专属宿主机上的实例调整高可用组。
        ///         /// - 除GPU、vGPU（以P开头）外的一代机暂不支持调整高可用组。
        ///         /// - 与该高可用组关联实例模板的VPC不同的不支持调整高可用组。
        ///         /// - 与该高可用组可用区不匹配的实例不支持调整高可用组。
        ///         /// - 本地系统盘机型不支持强制均衡。
        ///         /// - 仅支持实例状态为已停止的实例强制均衡调整高可用组。
        ///         /// - 若不强制均衡，仅支持实例状态为运行中或已停止的实例调整高可用组。
        ///         /// - 若强制均衡，带本地数据盘的实例需确认清除本地盘数据。
        ///         /// 
    /// </summary>
    public class ModifyInstancePlacementRequest : JdcloudRequest
    {
        ///<summary>
        /// 高可用组Id，必填项。
        /// 可查询 [DescribeAgs](https://docs.jdcloud.com/cn/availability-group/api/describeags) 接口获得高可用组信息。
        /// 
        ///</summary>
        public   string AgId{ get; set; }
        ///<summary>
        /// 是否强制均衡，默认 false
        /// 
        ///</summary>
        public   bool Balance{ get; set; }
        ///<summary>
        /// 是否确认清除本地盘数据，默认 false
        /// 
        ///</summary>
        public   bool ClearLocalDisk{ get; set; }
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