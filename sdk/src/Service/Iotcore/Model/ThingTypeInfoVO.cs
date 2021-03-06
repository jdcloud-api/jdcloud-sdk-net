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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Iotcore.Model
{

    /// <summary>
    ///  设备型号信息
    /// </summary>
    public class ThingTypeInfoVO
    {

        ///<summary>
        /// 认证方式 1: 一机一密 2：一型一密
        ///</summary>
        public int? AuthType{ get; set; }
        ///<summary>
        /// 连接类型,蜂窝（2G/3G/4G）
        ///</summary>
        public string ConnectType{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreatedTime{ get; set; }
        ///<summary>
        /// 更新时间
        ///</summary>
        public string UpdateTime{ get; set; }
        ///<summary>
        /// 自定义档案信息
        ///</summary>
        public List<CustomProfileVO> CustomProfiles{ get; set; }
        ///<summary>
        /// 设备类型编号
        ///</summary>
        public string DeviceTypeCode{ get; set; }
        ///<summary>
        /// 设备类型名称 例如：ttu、电表
        ///Required:true
        ///</summary>
        [Required]
        public string DeviceTypeName{ get; set; }
        ///<summary>
        /// GlobalProfiles
        ///</summary>
        public List<GlobalProfileVO> GlobalProfiles{ get; set; }
        ///<summary>
        /// 制造商编号
        ///</summary>
        public string ManufacturerId{ get; set; }
        ///<summary>
        /// 制造商名称
        ///</summary>
        public string ManufacturerName{ get; set; }
        ///<summary>
        /// 节点类型1:直连终端、2:边缘代理、3:非直连终端
        ///</summary>
        public int? NodeType{ get; set; }
        ///<summary>
        /// 所属物类型Code
        ///Required:true
        ///</summary>
        [Required]
        public string Code{ get; set; }
        ///<summary>
        /// 所属物类型名称
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
    }
}
