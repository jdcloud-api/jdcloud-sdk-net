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


namespace JDCloudSDK.Baseanti.Model
{

    /// <summary>
    ///  ipResourceInfo
    /// </summary>
    public class IpResourceInfo
    {

        ///<summary>
        /// 公网IP
        ///</summary>
        public string Ip{ get; set; }
        ///<summary>
        /// 0-&gt;安全 1-&gt;清洗 2-&gt;黑洞
        ///</summary>
        public int? SafeStatus{ get; set; }
        ///<summary>
        /// 地域，cn-north-1、cn-south-1、cn-east-1、cn-east-2
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 黑洞阈值，单位bps
        ///</summary>
        public long? BlackHoleThreshold{ get; set; }
        ///<summary>
        /// 触发清洗的流量速率，单位bps
        ///</summary>
        public long? CleanThresholdBps{ get; set; }
        ///<summary>
        /// 触发清洗的包速率，单位pps
        ///</summary>
        public long? CleanThresholdPps{ get; set; }
    }
}
