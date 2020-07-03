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


namespace JDCloudSDK.Iotcore.Model
{

    /// <summary>
    ///  deviceOnlineInfo
    /// </summary>
    public class DeviceOnlineInfo
    {

        ///<summary>
        /// 设备ID
        ///</summary>
        public string Device_id{ get; set; }
        ///<summary>
        /// 在线时长
        ///</summary>
        public int? Online_time{ get; set; }
        ///<summary>
        /// 上线次数
        ///</summary>
        public int? Count_time{ get; set; }
        ///<summary>
        /// 连接码
        ///</summary>
        public string Identifier{ get; set; }
        ///<summary>
        /// 设备状态
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 采集器类型
        ///</summary>
        public string CollDeviceType{ get; set; }
    }
}
