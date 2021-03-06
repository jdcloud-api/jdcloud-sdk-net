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

namespace JDCloudSDK.Ipanti.Model
{

    /// <summary>
    ///  createDispatchRuleSpec
    /// </summary>
    public class CreateDispatchRuleSpec
    {

        ///<summary>
        /// 规则名称
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 高防 IP
        ///</summary>
        public string ServiceIp{ get; set; }
        ///<summary>
        /// 云内IP
        ///Required:true
        ///</summary>
        [Required]
        public List<string> InnerIps{ get; set; }
        ///<summary>
        /// 触发调度的流量阈值, 单位 Mbps
        ///Required:true
        ///</summary>
        [Required]
        public long DispatchThresholdMbps{ get; set; }
        ///<summary>
        /// 触发调度的报文阈值, 单位 pps
        ///Required:true
        ///</summary>
        [Required]
        public long DispatchThresholdPps{ get; set; }
    }
}
