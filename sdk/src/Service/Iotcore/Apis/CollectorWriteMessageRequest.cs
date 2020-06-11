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
    ///  写入采集器数据
    /// </summary>
    public class CollectorWriteMessageRequest : JdcloudRequest
    {
        ///<summary>
        /// 当前的链接码
        ///Required:true
        ///</summary>
        [Required]
        public   string Identifier{ get; set; }
        ///<summary>
        /// 当前的协议类型,非必填项
        /// 
        ///</summary>
        public   string Protocol{ get; set; }
        ///<summary>
        /// 当前待写入的数据
        /// 如指定播放设备，寄存地址：13对应16进制0x0D，寄存器值:2
        /// {
        ///   &quot;13&quot;:2
        /// }
        /// 如播放控制，寄存地址：14对应16进制0x0E，寄存器值:1
        /// {
        ///   &quot;14&quot;: 1
        /// }
        /// 如音量设置，寄存地址：15对应16进制0x0F，寄存器值:10，取值范围0~30
        /// {
        ///   &quot;15&quot;: 10
        /// }
        /// 如指定文件夹和文件播放,寄存地址：16对应16进制0x10，寄存器值:1
        /// 寄存器值为两字节，第一个字节为文件夹，第二个字节为文件名
        /// 如0x01文件夹,0x03文件名，0x0103换算为10进制为259
        /// {
        ///   &quot;16&quot;: 259
        /// }
        /// 如组合播放，寄存器地址：17、18和19，寄存器值：257、258和259，寄存器值的算法和指定文件夹和文件播放是一致的，如259可换算为0x01文件夹,0x03文件名
        /// {
        ///   &quot;17&quot;: 257,
        ///   &quot;18&quot;: 258,
        ///   &quot;19&quot;: 259
        /// }
        /// 如播放广告，寄存地址：32对应16进制0x20，寄存器值:259，寄存器值的算法和指定文件夹和文件播放是一致的，如259可换算为0x01文件夹,0x03文件名
        /// {
        ///   &quot;32&quot;: 259
        /// }
        /// 如指定文件夹循环播放，寄存地址：33对应16进制0x21，寄存器值:256，寄存器值的算法，如256可换算为0x0100文件夹
        /// {
        ///   &quot;33&quot;: 256
        /// }
        /// 如指定文件夹随机播放，寄存地址：34对应16进制0x22，寄存器值:256，寄存器值的算法，如256可换算为0x0100文件夹
        /// {
        ///   &quot;34&quot;: 256
        /// }
        /// 如指定曲目播放，寄存地址：35对应16进制0x23，寄存器值:13,歌曲选择范围为0~3000
        /// {
        ///   &quot;35&quot;: 13
        /// }
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   object Data{ get; set; }
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