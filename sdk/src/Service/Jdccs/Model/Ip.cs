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


namespace JDCloudSDK.Jdccs.Model
{

    /// <summary>
    ///  公网IP
    /// </summary>
    public class Ip
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
        /// 公网IP实例ID
        ///</summary>
        public string IpId{ get; set; }
        ///<summary>
        /// IP地址段
        ///</summary>
        public string CidrAddr{ get; set; }
        ///<summary>
        /// 网络位地址
        ///</summary>
        public string NetworkAddr{ get; set; }
        ///<summary>
        /// 网关地址
        ///</summary>
        public int? GatewayAddr{ get; set; }
        ///<summary>
        /// 广播地址
        ///</summary>
        public int? BroadcastAddr{ get; set; }
        ///<summary>
        /// 状态 normal:正常 abnormal:异常
        ///</summary>
        public string Status{ get; set; }
    }
}
