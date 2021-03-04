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
 * 快照策略相关接口
 * 云硬盘相关接口，快照策略的创建，更新，删除，查询，绑定/解绑磁盘等接口。
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

using JDCloudSDK.Disk.Model;

namespace  JDCloudSDK.Disk.Apis
{

    /// <summary>
    ///  查询快照策略与磁盘绑定关系
    /// </summary>
    public class DescribeSnapshotPolicyDiskRelationsResult : JdcloudResult
    {
        ///<summary>
        /// 总数量
        ///</summary>
        public   int? TotalCount{ get; set; }
        ///<summary>
        /// 绑定关系
        ///</summary>
        public List<DescSnapshotRelationsData> RelationResults{ get; set; }

    }
}