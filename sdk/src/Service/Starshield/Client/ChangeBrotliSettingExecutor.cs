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


using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Starshield.Client
{

    /// <summary>
    ///  当请求资产的客户端支持brotli压缩算法时，星盾将提供资产的brotli压缩版本。
    /// </summary>
    public class ChangeBrotliSettingExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  当请求资产的客户端支持brotli压缩算法时，星盾将提供资产的brotli压缩版本。接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "PATCH";
            }
        }
        /// <summary>
        ///  当请求资产的客户端支持brotli压缩算法时，星盾将提供资产的brotli压缩版本。接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/zones/{zone_identifier}/settings$$brotli";
            }
        }
    }
}