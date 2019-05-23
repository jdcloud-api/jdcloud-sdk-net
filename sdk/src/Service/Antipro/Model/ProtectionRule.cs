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

using JDCloudSDK.Antipro.Model;

namespace JDCloudSDK.Antipro.Model
{

    /// <summary>
    ///  protectionRule
    /// </summary>
    public class ProtectionRule
    {

        ///<summary>
        /// 防护规则类型: 0: 默认防护包规则, 1: IP 自定义规则
        ///</summary>
        public int? Type{ get; set; }
        ///<summary>
        /// 清洗触发值 bps
        ///</summary>
        public long? CleanThresholdBps{ get; set; }
        ///<summary>
        /// 清洗触发值 pps
        ///</summary>
        public long? CleanThresholdPps{ get; set; }
        ///<summary>
        /// 虚假源开启
        ///</summary>
        public int? SpoofIpEnable{ get; set; }
        ///<summary>
        /// 源新建连接限速开启
        ///</summary>
        public int? SrcNewConnLimitEnable{ get; set; }
        ///<summary>
        /// 源新建连接速率
        ///</summary>
        public long? SrcNewConnLimitValue{ get; set; }
        ///<summary>
        /// 目的新建连接开启
        ///</summary>
        public int? DstNewConnLimitEnable{ get; set; }
        ///<summary>
        /// 目的新建连接速率
        ///</summary>
        public long? DstNewConnLimitValue{ get; set; }
        ///<summary>
        /// 报文最小长度
        ///</summary>
        public long? DatagramRangeMin{ get; set; }
        ///<summary>
        /// 报文最大长度
        ///</summary>
        public long? DatagramRangeMax{ get; set; }
        ///<summary>
        /// geo 拦截地域列表
        ///</summary>
        public List<GeoBlack> GeoBlackList{ get; set; }
    }
}
