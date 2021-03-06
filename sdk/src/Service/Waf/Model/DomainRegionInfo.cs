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


namespace JDCloudSDK.Waf.Model
{

    /// <summary>
    ///  domainRegionInfo
    /// </summary>
    public class DomainRegionInfo
    {

        ///<summary>
        /// 域名的在华北的vip和选中信息
        ///</summary>
        public RegionVipInfo Hb_bgp{ get; set; }
        ///<summary>
        /// 域名的在华东的vip和选中信息
        ///</summary>
        public RegionVipInfo Hd_bgp{ get; set; }
        ///<summary>
        /// 域名的在华南的vip和选中信息
        ///</summary>
        public RegionVipInfo Hn{ get; set; }
    }
}
