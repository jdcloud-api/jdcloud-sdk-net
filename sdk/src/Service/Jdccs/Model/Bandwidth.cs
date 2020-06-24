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

namespace JDCloudSDK.Jdccs.Model
{

    /// <summary>
    ///  带宽（出口）
    /// </summary>
    public class Bandwidth
    {

        ///<summary>
        /// 机房英文标识
        ///</summary>
        public string Idc{ get; set; }
        ///<summary>
        /// 机房名称
        ///</summary>
        public string IdcName{ get; set; }
        ///<summary>
        /// 带宽实例ID
        ///</summary>
        public string BandwidthId{ get; set; }
        ///<summary>
        /// 带宽名称
        ///</summary>
        public string BandwidthName{ get; set; }
        ///<summary>
        /// 状态 normal:正常 abnormal:异常
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 线路类型 dynamicBGP:动态BGP thirdLineBGP:三线BGP telecom:电信单线 unicom:联通单线 mobile:移动单线
        ///</summary>
        public string LineType{ get; set; }
        ///<summary>
        /// 计费方式 fixedBandwidth:固定带宽 95thPercentile:95峰值 merge95thPercentile:合并95峰值
        ///</summary>
        public string ChargeType{ get; set; }
        ///<summary>
        /// 合同带宽（Mbps）
        ///</summary>
        [JsonProperty("bandwidth")]
        public int? BandwidthValue{ get; set; }
        ///<summary>
        /// 关联的公网IP
        ///</summary>
        public List<RelatedIp> RelatedIp{ get; set; }
        ///<summary>
        /// 交换机信息
        ///</summary>
        public List<Switchboard> Switchboard{ get; set; }
    }
}
