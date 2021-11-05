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
 * 私有域名zone
 * 私有域名zone API
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

namespace JDCloudSDK.Privatezone.Client
{

    /// <summary>
    ///  - 添加一个私有解析的zone，可添加以下三种类型的zone
        /// - 云内全局zone：zone的后缀是指定的后缀，如：local。该域名在云内自动全局生效，不用关联vpc即可在vpc内解析，该类型全局唯一，不能重复添加
        /// - 反向解析zone：zone的后缀是in-addr.arpa时，我们认为他是一个反向解析的zone，反向解析域名前缀目前支持10/172.16-31/192.168网段，如：10.in-addr.arpa、16.172.in-addr.arpa。反向解析的zone只能添加反向解析的记录
        /// - 私有解析zone：该类型的zone可以时任意符合格式的域名，私有解析zone需要关联vpc后，在vpc内生效解析
        /// 
    /// </summary>
    public class CreateZoneExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  - 添加一个私有解析的zone，可添加以下三种类型的zone
        /// - 云内全局zone：zone的后缀是指定的后缀，如：local。该域名在云内自动全局生效，不用关联vpc即可在vpc内解析，该类型全局唯一，不能重复添加
        /// - 反向解析zone：zone的后缀是in-addr.arpa时，我们认为他是一个反向解析的zone，反向解析域名前缀目前支持10/172.16-31/192.168网段，如：10.in-addr.arpa、16.172.in-addr.arpa。反向解析的zone只能添加反向解析的记录
        /// - 私有解析zone：该类型的zone可以时任意符合格式的域名，私有解析zone需要关联vpc后，在vpc内生效解析
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "POST";
            }
        }
        /// <summary>
        ///  - 添加一个私有解析的zone，可添加以下三种类型的zone
        /// - 云内全局zone：zone的后缀是指定的后缀，如：local。该域名在云内自动全局生效，不用关联vpc即可在vpc内解析，该类型全局唯一，不能重复添加
        /// - 反向解析zone：zone的后缀是in-addr.arpa时，我们认为他是一个反向解析的zone，反向解析域名前缀目前支持10/172.16-31/192.168网段，如：10.in-addr.arpa、16.172.in-addr.arpa。反向解析的zone只能添加反向解析的记录
        /// - 私有解析zone：该类型的zone可以时任意符合格式的域名，私有解析zone需要关联vpc后，在vpc内生效解析
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/zones";
            }
        }
    }
}
