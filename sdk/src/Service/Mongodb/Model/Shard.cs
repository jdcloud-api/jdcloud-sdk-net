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


namespace JDCloudSDK.Mongodb.Model
{

    /// <summary>
    ///  shard
    /// </summary>
    public class Shard
    {

        ///<summary>
        /// shard节点ID
        ///</summary>
        public string ShardNodeId{ get; set; }
        ///<summary>
        /// shard节点状态
        ///</summary>
        public string ShardNodeStatus{ get; set; }
        ///<summary>
        /// shard节点名称，shad-N
        ///</summary>
        public string ShardNodeName{ get; set; }
        ///<summary>
        /// shard节点规格代码
        ///</summary>
        public string ShardNodeType{ get; set; }
        ///<summary>
        /// shard节点存储空间
        ///</summary>
        public int? ShardNodeStorageGB{ get; set; }
        ///<summary>
        /// shard节点所在地域
        ///</summary>
        public string ShardNodeAzId{ get; set; }
        ///<summary>
        /// shard节点的CPU
        ///</summary>
        public int? ShardNodeCPU{ get; set; }
        ///<summary>
        /// shard节点的Memory
        ///</summary>
        public int? ShardNodeMemoryGB{ get; set; }
    }
}
