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
 * Resource-Tag-APIs
 * 资源标签接口
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

namespace JDCloudSDK.Resourcetag.Client
{

    /// <summary>
    ///  根据标签查找资源。 &lt;br/&gt;
        /// 若要查找cdn产品线的资源则url中的regionId必须指定为cn-all。
        /// 
    /// </summary>
    public class QueryResourceExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  根据标签查找资源。 &lt;br/&gt;
        /// 若要查找cdn产品线的资源则url中的regionId必须指定为cn-all。
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "POST";
            }
        }
        /// <summary>
        ///  根据标签查找资源。 &lt;br/&gt;
        /// 若要查找cdn产品线的资源则url中的regionId必须指定为cn-all。
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/queryResource";
            }
        }
    }
}
