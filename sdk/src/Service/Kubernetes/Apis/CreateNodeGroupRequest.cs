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
 * NodeGroup
 * 工作节点组相关接口
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

using JDCloudSDK.Kubernetes.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Kubernetes.Apis
{

    /// <summary>
    ///  创建工作节点组&lt;br&gt;
        ///         /// - 要求集群状态为running
        ///         /// 
    /// </summary>
    public class CreateNodeGroupRequest : JdcloudRequest
    {
        ///<summary>
        /// 名称（同一用户的 cluster 内部唯一）
        ///Required:true
        ///</summary>
        [Required]
        public   string Name{ get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 工作节点所属的集群
        ///Required:true
        ///</summary>
        [Required]
        public   string ClusterId{ get; set; }
        ///<summary>
        /// 工作节点配置信息
        ///Required:true
        ///</summary>
        [Required]
        public   NodeConfigSpec NodeConfig{ get; set; }
        ///<summary>
        /// 工作节点组的 az，必须为集群az的子集，默认为集群az
        ///</summary>
        public List<string> Azs{ get; set; }

        ///<summary>
        /// 工作节点组初始化大小
        ///Required:true
        ///</summary>
        [Required]
        public   int InitialNodeCount{ get; set; }
        ///<summary>
        /// 工作节点组初始化大小运行的VPC
        ///Required:true
        ///</summary>
        [Required]
        public   string VpcId{ get; set; }
        ///<summary>
        /// 工作节点组的cidr
        ///Required:true
        ///</summary>
        [Required]
        public   string NodeCidr{ get; set; }
        ///<summary>
        /// 是否开启工作节点组的自动修复，默认关闭
        ///</summary>
        public   bool AutoRepair{ get; set; }
        ///<summary>
        /// 地域 ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}