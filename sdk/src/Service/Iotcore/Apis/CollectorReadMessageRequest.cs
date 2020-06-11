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
 * LoongrayElevator
 * 朗锐电梯服务
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

using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Iotcore.Apis
{

    /// <summary>
    ///  获取协议信息
    /// </summary>
    public class CollectorReadMessageRequest : JdcloudRequest
    {
        ///<summary>
        /// 当前的链接码
        ///Required:true
        ///</summary>
        [Required]
        public   string Identifier{ get; set; }
        ///<summary>
        /// 当前的协议类型：
        /// 语音播报控制器-输入端子,0X00000~X0007：inputTerminal
        /// 语音播报控制器-播放信息,0X00024~X0027：playInfo
        /// LR001-516-5B边缘数据采集器-传感器管理：sensor
        /// LR001-516-5B边缘数据采集器-采集器属性：collectorProperty
        /// LR001-516-5B边缘数据采集器-电梯属性：elevatorProperty
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string Protocol{ get; set; }
        ///<summary>
        /// Hub实例Id
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        /// 区域Id
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}