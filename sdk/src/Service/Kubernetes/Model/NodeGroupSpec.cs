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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Kubernetes.Model
{

    /// <summary>
    ///  描述工作节点组配置信息
    /// </summary>
    public class NodeGroupSpec
    {

        ///<summary>
        /// 名称
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// Description
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 工作节点组的信息
        ///Required:true
        ///</summary>
        [Required]
        public NodeConfigSpec NodeConfig{ get; set; }
        ///<summary>
        /// 工作节点组的 az，必须为集群az的子集，默认为集群az
        ///</summary>
        public List<string> Azs{ get; set; }
        ///<summary>
        /// 工作节点组初始化大小，至少为1个
        ///Required:true
        ///</summary>
        [Required]
        public int InitialNodeCount{ get; set; }
        ///<summary>
        /// 工作节点组运行的vpc
        ///Required:true
        ///</summary>
        [Required]
        public string VpcId{ get; set; }
        ///<summary>
        /// 工作节点组的cidr
        ///</summary>
        public string NodeCidr{ get; set; }
        ///<summary>
        /// 是否开启自动修复，默认不开启。
        ///</summary>
        public bool AutoRepair{ get; set; }
        ///<summary>
        /// 自动伸缩配置
        ///</summary>
        public CAConfigSpec CaConfig{ get; set; }
    }
}
