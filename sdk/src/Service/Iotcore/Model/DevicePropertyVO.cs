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

namespace JDCloudSDK.Iotcore.Model
{

    /// <summary>
    ///  设备属性控制
    /// </summary>
    public class DevicePropertyVO
    {

        ///<summary>
        /// {&quot;streamId1&quot;:&quot;value1&quot;,&quot;streamId2&quot;:2,&quot;streamId3&quot;:&quot;value3&quot;}
        ///</summary>
        public object Cmd{ get; set; }
        ///<summary>
        /// 设备标识ID
        ///</summary>
        public string DeviceId{ get; set; }
        ///<summary>
        /// 物类型
        ///</summary>
        public string ThingTypeName{ get; set; }
        ///<summary>
        /// 设备名称
        ///</summary>
        public string DeviceName{ get; set; }
        ///<summary>
        /// 版本号
        ///</summary>
        [JsonProperty("version")]
        public int? VersionValue{ get; set; }
    }
}
