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

namespace JDCloudSDK.Baseanti.Model
{

    /// <summary>
    ///  cleanThresholdSpec
    /// </summary>
    public class CleanThresholdSpec
    {

        ///<summary>
        /// 触发清洗的流量速率, 单位 bps. 取值范围由 &lt;a href&#x3D;&#39;http://docs.jdcloud.com/anti-ddos-basic/api/describeipcleanthresholdrange&#39;&gt;describeIpCleanThresholdRange&lt;/a&gt; 接口查询可知
        ///Required:true
        ///</summary>
        [Required]
        public long CleanThresholdBps{ get; set; }
        ///<summary>
        /// 触发清洗的报文流量速率, 单位 bps. 取值范围由 &lt;a href&#x3D;&#39;http://docs.jdcloud.com/anti-ddos-basic/api/describeipcleanthresholdrange&#39;&gt;describeIpCleanThresholdRange&lt;/a&gt; 接口查询可知
        ///Required:true
        ///</summary>
        [Required]
        public long CleanThresholdPps{ get; set; }
    }
}
