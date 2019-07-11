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


namespace JDCloudSDK.Disk.Model
{

    /// <summary>
    ///  快照信息详情
    /// </summary>
    public class Snapshot
    {

        ///<summary>
        /// 云硬盘快照ID
        ///</summary>
        public string SnapshotId{ get; set; }
        ///<summary>
        /// 快照来源 可以有self，others两种来源
        ///</summary>
        public string SnapshotSource{ get; set; }
        ///<summary>
        /// 创建快照的云硬盘ID(snapshotSource为others时不展示)
        ///</summary>
        public string DiskId{ get; set; }
        ///<summary>
        /// 快照大小，单位为GiB
        ///</summary>
        public int? SnapshotSizeGB{ get; set; }
        ///<summary>
        /// 快照关联的所有镜像ID(snapshotSource为others时不展示)
        ///</summary>
        public List<string> Images{ get; set; }
        ///<summary>
        /// 快照名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 快照描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 快照状态，取值为 creating、available、in-use、deleting、error_create、error_delete 之一
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 共享信息
        ///</summary>
        public List<ShareInfo> SharInfo{ get; set; }
        ///<summary>
        /// 快照是否为加密盘的快照
        ///</summary>
        public bool Encrypted{ get; set; }
    }
}