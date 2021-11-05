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
    ///  SSL对访问者的连接进行加密，并保护信用卡号码和其他进出网站的个人数据。
        ///         /// SSL最多需要5分钟才能完全激活。需要在星盾激活你的根域或www域。
        ///         /// Off，访客和星盾之间没有SSL，星盾和你的Web服务器之间也没有SSL（所有HTTP流量）。
        ///         /// Flexible, 访客和星盾之间的 SSL -- 访客在你的网站上看到 HTTPS，但星盾和你的 Web 服务器之间没有 SSL。您不需要在您的 Web 服务器上安装 SSL 证书，但您的访客仍会看到启用 HTTPS 的网站。
        ///         /// Full, 访客和星盾之间的 SSL -- 访客在你的网站上看到 HTTPS，以及星盾和你的 Web 服务器之间的 SSL。您至少需要有自己的 SSL 证书或自签名的证书。
        ///         /// Full (Strict), 访客和星盾之间的 SSL -- 访客在您的网站上看到 HTTPS，以及星盾和您的 Web 服务器之间的 SSL。你需要在你的网络服务器上安装一个有效的SSL证书。
        ///         /// 这个证书必须由一个证书机构签署，有一个在未来的到期日，并为请求的域名（主机名）作出回应。
        ///         /// 
    /// </summary>
    public class GetSSLSettingResult : JdcloudResult
    {
        ///<summary>
        /// Data
        ///</summary>
        public   SSL Data{ get; set; }
    }
}