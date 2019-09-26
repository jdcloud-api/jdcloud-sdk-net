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
 * DeviceInfo
 * device管理模块
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Iotcore.Apis
{

    /// <summary>
    ///  查看设备影子
    /// </summary>
    public class DescribeThingShadowResult : JdcloudResult
    {
        ///<summary>
        /// 设备状态
        ///</summary>
        public   object State{ get; set; }
        ///<summary>
        /// 当用户更新设备状态文档后，设备影子服务会自动更新metadata的值。设备状态的元数据的信息包含以 Epoch 时间表示的每个属性的时间戳，用来获取准确的更新时间。
        ///</summary>
        public   object Metadata{ get; set; }
        ///<summary>
        /// 设备影子版本
        ///</summary>
        public   int? Version{ get; set; }
        ///<summary>
        /// 设备影子更新时间
        ///</summary>
        public   long? Timestamp{ get; set; }
    }
}