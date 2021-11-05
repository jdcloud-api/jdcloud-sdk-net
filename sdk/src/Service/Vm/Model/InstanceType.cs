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

namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  实例规格详细信息。
    /// </summary>
    public class InstanceType
    {

        ///<summary>
        /// 实例规格族。
        ///</summary>
        public string Family{ get; set; }
        ///<summary>
        /// 实例规格。
        ///</summary>
        [JsonProperty("instanceType")]
        public string InstanceTypeValue{ get; set; }
        ///<summary>
        /// cpu个数。
        ///</summary>
        public int? Cpu{ get; set; }
        ///<summary>
        /// 内存大小。
        ///</summary>
        public int? MemoryMB{ get; set; }
        ///<summary>
        /// 支持绑定的弹性网卡数量，包括主网卡。
        ///</summary>
        public int? NicLimit{ get; set; }
        ///<summary>
        /// 支持挂载的云硬盘数量，包括云盘系统盘。
        ///</summary>
        public int? CloudDiskCountLimit{ get; set; }
        ///<summary>
        /// 实例规格描述。
        ///</summary>
        public string Desc{ get; set; }
        ///<summary>
        /// 实例规格售卖状态。已售罄的实例规格无法使用。
        ///</summary>
        public List<InstanceTypeState> State{ get; set; }
        ///<summary>
        /// GPU配置，针对GPU类型的实例规格有效。
        ///</summary>
        public Gpu Gpu{ get; set; }
        ///<summary>
        /// 本地数据盘配置（缓存盘），针对GPU类型、或本地存储型的实例规格有效。
        ///</summary>
        public List<LocalDisk> LocalDisks{ get; set; }
        ///<summary>
        /// 实例规格代数。
        ///</summary>
        public int? Generation{ get; set; }
    }
}
