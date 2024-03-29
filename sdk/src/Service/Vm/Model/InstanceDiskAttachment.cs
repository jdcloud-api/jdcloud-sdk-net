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

namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  云主机实例磁盘挂载点信息。
    /// </summary>
    public class InstanceDiskAttachment
    {

        ///<summary>
        /// 磁盘类型。
        /// **系统盘**：取值为：&#x60;local&#x60; 本地系统盘 或 &#x60;cloud&#x60; 云盘系统盘。
        /// **数据盘**：取值为：&#x60;local&#x60; 本地数据盘 或 &#x60;cloud&#x60; 云盘数据盘。
        /// 
        ///</summary>
        public string DiskCategory{ get; set; }
        ///<summary>
        /// 是否随实例一起删除，即删除实例时是否自动删除此磁盘。此参数仅对按配置计费的非多点挂载云硬盘生效。
        /// &#x60;true&#x60;：随实例删除。
        /// &#x60;false&#x60;：不随实例删除。
        /// 
        ///</summary>
        public bool AutoDelete{ get; set; }
        ///<summary>
        /// 本地磁盘配置，对应 &#x60;diskCategory&#x3D;local&#x60;。
        ///</summary>
        public LocalDisk LocalDisk{ get; set; }
        ///<summary>
        /// 云硬盘配置，对应 &#x60;diskCategory&#x3D;cloud&#x60;。
        ///</summary>
        public JDCloudSDK.Disk.Model.Disk CloudDisk{ get; set; }
        ///<summary>
        /// 磁盘逻辑挂载点。
        /// **系统盘**：默认为vda。
        /// **数据盘**：取值范围：&#x60;[vdb~vdbm]&#x60;。
        /// 
        ///</summary>
        public string DeviceName{ get; set; }
        ///<summary>
        /// 磁盘挂载状态。
        /// 取值范围：&#x60;attaching、detaching、attached、detached、error_attach、error_detach&#x60;。
        ///</summary>
        public string Status{ get; set; }
    }
}
