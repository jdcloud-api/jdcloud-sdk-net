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

namespace JDCloudSDK.Redis.Model
{

    /// <summary>
    ///  某缓存Redis实例规格信息
    /// </summary>
    public class InstanceClass
    {

        ///<summary>
        /// 实例规格代码,参见实例规格代码表
        ///</summary>
        [JsonProperty("instanceClass")]
        public string InstanceClassValue{ get; set; }
        ///<summary>
        /// cpu
        ///</summary>
        public int? Cpu{ get; set; }
        ///<summary>
        /// 内存
        ///</summary>
        public int? MemoryMB{ get; set; }
        ///<summary>
        /// 磁盘
        ///</summary>
        public int? DiskGB{ get; set; }
        ///<summary>
        /// 最大链接数
        ///</summary>
        public int? MaxConnetction{ get; set; }
        ///<summary>
        /// 带宽
        ///</summary>
        public int? BandwidthMbps{ get; set; }
    }
}
