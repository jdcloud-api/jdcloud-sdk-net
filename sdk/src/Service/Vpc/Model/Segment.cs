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


namespace JDCloudSDK.Vpc.Model
{

    /// <summary>
    ///  segment
    /// </summary>
    public class Segment
    {

        ///<summary>
        /// 网段的Id
        ///</summary>
        public string SegmentId{ get; set; }
        ///<summary>
        /// 网段名称，只允许输入中文、数字、大小写字母、英文下划线“_”及中划线“-”，不允许为空且不超过32字符。
        ///</summary>
        public string SegmentName{ get; set; }
        ///<summary>
        /// 网段描述，允许输入UTF-8编码下的全部字符，不超过256字符。
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 网络地址段
        ///</summary>
        public string AddressPrefix{ get; set; }
        ///<summary>
        /// 网段可用ip数量
        ///</summary>
        public int? AvailableIpCount{ get; set; }
        ///<summary>
        /// IP服务商，取值为bgp或no_bgp，cn-north-1：bgp；cn-south-1：[bgp，no_bgp]；cn-east-1：[bgp，no_bgp]；cn-east-2：bgp
        ///</summary>
        public string Provider{ get; set; }
        ///<summary>
        /// 网段的起始地址
        ///</summary>
        public string StartIp{ get; set; }
        ///<summary>
        /// 网段的结束地址
        ///</summary>
        public string EndIp{ get; set; }
    }
}
