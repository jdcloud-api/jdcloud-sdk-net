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

using JDCloudSDK.Disk.Model;
using JDCloudSDK.Charge.Model;

namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  云硬盘信息详情
    /// </summary>
    public class Disk
    {

        ///<summary>
        /// 云硬盘ID
        ///</summary>
        public string DiskId{ get; set; }
        ///<summary>
        /// 云硬盘所属AZ
        ///</summary>
        public string Az{ get; set; }
        ///<summary>
        /// 云硬盘名称，只允许输入中文、数字、大小写字母、英文下划线“_”及中划线“-”，不允许为空且不超过32字符。
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 云硬盘描述，允许输入UTF-8编码下的全部字符，不超过256字符。
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 云硬盘类型，取值为 ssd,premium-hdd,ssd.gp1,ssd.io1,hdd.std1
        ///</summary>
        public string DiskType{ get; set; }
        ///<summary>
        /// 云硬盘大小，单位为 GiB
        ///</summary>
        public int? DiskSizeGB{ get; set; }
        ///<summary>
        /// 该云硬盘实际应用的iops值
        ///</summary>
        public int? Iops{ get; set; }
        ///<summary>
        /// 该云硬盘实际应用的吞吐量的数值
        ///</summary>
        public int? Throughput{ get; set; }
        ///<summary>
        /// 云硬盘状态，取值为 creating、available、in-use、extending、restoring、deleting、deleted、error_create、error_delete、error_restore、error_extend 之一
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 挂载信息
        ///</summary>
        public List<DiskAttachment> Attachments{ get; set; }
        ///<summary>
        /// 创建该云硬盘的快照ID
        ///</summary>
        public string SnapshotId{ get; set; }
        ///<summary>
        /// 云盘是否支持多挂载
        ///</summary>
        public bool MultiAttachable{ get; set; }
        ///<summary>
        /// 云盘是否为加密盘
        ///</summary>
        public bool Encrypted{ get; set; }
        ///<summary>
        /// 云盘是否被暂停（IOPS限制为极低）
        ///</summary>
        public bool Enabled{ get; set; }
        ///<summary>
        /// 创建云硬盘时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 云硬盘计费配置信息
        ///</summary>
        public JDCloudSDK.Charge.Model.Charge Charge{ get; set; }
        ///<summary>
        /// null
        ///</summary>
        public List<Tag> Tags{ get; set; }
        ///<summary>
        /// SnapshotPolicies
        ///</summary>
        public List<SnapshotPolicy> SnapshotPolicies{ get; set; }
    }
}
