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


namespace JDCloudSDK.Iotlink.Model
{

    /// <summary>
    ///  onOffStatusResp
    /// </summary>
    public class OnOffStatusResp
    {

        ///<summary>
        /// 物联网卡iccid
        ///</summary>
        public string Iccid{ get; set; }
        ///<summary>
        /// 物联网卡msisdn
        ///</summary>
        public string Msisdn{ get; set; }
        ///<summary>
        /// 物联网卡imsi
        ///</summary>
        public string Imsi{ get; set; }
        ///<summary>
        /// 终端的开关机状态(00:关机;01:开机;02:该运营商不支持查询;03:未知)
        ///</summary>
        public string Status{ get; set; }
    }
}