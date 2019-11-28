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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace JDCloudSDK.Kubernetes.Model
{

    /// <summary>
    ///  描述工作节点组配置信息
    /// </summary>
    public class NodeGroup
    {

        ///<summary>
        /// 集群 id
        ///</summary>
        public string ClusterId{ get; set; }
        ///<summary>
        /// 工作节点组 id
        ///</summary>
        public string NodeGroupId{ get; set; }
        ///<summary>
        /// 工作节点组名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 工作节点组描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 工作节点组配置信息
        ///</summary>
        public NodeConfig NodeConfig{ get; set; }
        ///<summary>
        /// 工作节点版本
        ///</summary>
        [JsonProperty("version")]
        public string VersionValue{ get; set; }
        ///<summary>
        /// 工作节点所属的网络信息
        ///</summary>
        public NodeNetwork NodeNetwork{ get; set; }
        ///<summary>
        /// 当前工作节点数量
        ///</summary>
        public int? CurrentCount{ get; set; }
        ///<summary>
        /// 期望的工作节点数量
        ///</summary>
        public int? ExpectCount{ get; set; }
        ///<summary>
        /// 工作节点组的ag id ，通过agid可以查询该工作节点组下的实例
        ///</summary>
        public string AgId{ get; set; }
        ///<summary>
        /// 工作节点组所在的 az
        ///</summary>
        public List<string> Azs{ get; set; }
        ///<summary>
        /// 工作节点组的 ag 对应的实例模板
        ///</summary>
        public string InstanceTemplateId{ get; set; }
        ///<summary>
        /// 状态  [pending,running,resizing,reconciling,deleting,deleted,error,running_with_error(部分节点有问题)]
        ///</summary>
        public string State{ get; set; }
        ///<summary>
        /// Tags
        ///</summary>
        public List<Tag> Tags{ get; set; }
        ///<summary>
        /// 更新时间
        ///</summary>
        public string UpdateTime{ get; set; }
        ///<summary>
        /// 状态变更原因
        ///</summary>
        public string StateMessage{ get; set; }
        ///<summary>
        /// 是否开启自动修复
        ///</summary>
        public bool AutoRepair{ get; set; }
        ///<summary>
        /// 控制节点操作进度
        ///</summary>
        public NodeGroupProgress Progress{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreatedTime{ get; set; }
    }
}
