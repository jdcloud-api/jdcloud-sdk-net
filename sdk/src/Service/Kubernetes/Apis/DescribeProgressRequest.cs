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
 * Cluster
 * 集群相关接口
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

namespace  JDCloudSDK.Kubernetes.Apis
{

    /// <summary>
    ///  查询集群操作进度
    /// </summary>
    public class DescribeProgressRequest : JdcloudRequest
    {
        ///<summary>
        /// 节点组 ID
        ///</summary>
        public List<string> NodeGroupIds{ get; set; }

        ///<summary>
        /// 地域 ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 集群 ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ClusterId{ get; set; }
    }
}