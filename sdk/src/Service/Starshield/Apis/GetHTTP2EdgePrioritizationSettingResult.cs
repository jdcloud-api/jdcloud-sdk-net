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
 * Zone Settings
 * A Zone setting changes how the Zone works in relation to caching, security, or other features of JDC StarShield
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Starshield.Model;

namespace  JDCloudSDK.Starshield.Apis
{

    /// <summary>
    ///  HTTP/2边缘优化，优化了通过HTTP/2提供的资源交付，提高了页面加载性能。当与Worker结合使用时，它还支持对内容交付的精细控制。
        ///         /// 
    /// </summary>
    public class GetHTTP2EdgePrioritizationSettingResult : JdcloudResult
    {
        ///<summary>
        /// Data
        ///</summary>
        public   HTTP2EdgePrioritization Data{ get; set; }
    }
}