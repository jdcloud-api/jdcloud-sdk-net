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
    ///  设备信息
    /// </summary>
    public class DeviceInfoVO
    {

        ///<summary>
        /// 激活时间
        ///</summary>
        public DateTime? ActivateTime{ get; set; }
        ///<summary>
        /// 代理设备id
        ///</summary>
        public string ConnectAgentDeviceId{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// CustomProfiles
        ///</summary>
        public List<CustomProfileVO> CustomProfiles{ get; set; }
        ///<summary>
        /// 设备标识id
        ///</summary>
        public string DeviceId{ get; set; }
        ///<summary>
        /// 设备名称
        ///</summary>
        public string DeviceName{ get; set; }
        ///<summary>
        /// DeviceTagList
        ///</summary>
        public List<TagVO> DeviceTagList{ get; set; }
        ///<summary>
        /// GlobalProfiles
        ///</summary>
        public List<GlobalProfileVO> GlobalProfiles{ get; set; }
        ///<summary>
        /// 最近一次上线时间
        ///</summary>
        public DateTime? LastConnectTime{ get; set; }
        ///<summary>
        /// 最近一次离线时间
        ///</summary>
        public DateTime? LastDisconnectTime{ get; set; }
        ///<summary>
        /// 纬度
        ///</summary>
        public string Latitude{ get; set; }
        ///<summary>
        /// 经度
        ///</summary>
        public string Longitude{ get; set; }
        ///<summary>
        /// 设备mac地址
        ///</summary>
        public string MacAddress{ get; set; }
        ///<summary>
        /// 生产厂商ID
        ///</summary>
        public string ManufactureId{ get; set; }
        ///<summary>
        /// 生产厂商名称
        ///</summary>
        public string ManufactureName{ get; set; }
        ///<summary>
        /// 设备连接类型
        ///</summary>
        public int? NodeType{ get; set; }
        ///<summary>
        /// 设备上报数据更新时间
        ///</summary>
        public DateTime? LastReportTime{ get; set; }
        ///<summary>
        /// 设备状态：0 停用;1 未激活;2 离线;3 在线
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 物模型ID
        ///</summary>
        public string ThingModelId{ get; set; }
        ///<summary>
        /// 物模型版本号
        ///</summary>
        public string ThingModelVersion{ get; set; }
        ///<summary>
        /// 物类型ID
        ///</summary>
        public string ThingTypeCode{ get; set; }
        ///<summary>
        /// 物类型名称
        ///</summary>
        public string ThingTypeName{ get; set; }
        ///<summary>
        /// 设备物理ID
        ///</summary>
        public string UniqueId{ get; set; }
        ///<summary>
        /// 更新时间
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
    }
}