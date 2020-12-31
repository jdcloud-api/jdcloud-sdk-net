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


namespace JDCloudSDK.Cps.Model
{

    /// <summary>
    ///  ipv6Gateway
    /// </summary>
    public class Ipv6Gateway
    {

        ///<summary>
        /// 地域，如cn-north-1
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// IPv6网关实例ID
        ///</summary>
        public string Ipv6GatewayId{ get; set; }
        ///<summary>
        /// IPv6网关名称
        ///</summary>
        public string Ipv6GatewayName{ get; set; }
        ///<summary>
        /// 私有网络ID
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 私有网络名称
        ///</summary>
        public string VpcName{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreateTime{ get; set; }
    }
}
