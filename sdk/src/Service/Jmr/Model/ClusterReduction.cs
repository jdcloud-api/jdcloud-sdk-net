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

namespace JDCloudSDK.Jmr.Model
{

    /// <summary>
    ///  clusterReduction
    /// </summary>
    public class ClusterReduction
    {

        ///<summary>
        /// 集群ID
        ///Required:true
        ///</summary>
        [Required]
        public string ClusterId{ get; set; }
        ///<summary>
        /// 保留的节点个数
        ///</summary>
        public string ReserveNum{ get; set; }
        ///<summary>
        /// 缩容节点类型。 仅支持 Task ，即计算节点
        ///</summary>
        public string NodeType{ get; set; }
    }
}