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
 * 直播域名操作类接口
 * Openapi For JCLOUD cdn
 *
 * OpenAPI spec version: v1
 * Contact: pid-cdn@jd.com
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  设置URL鉴权
    /// </summary>
    public class SetLiveDomainAccessKeyRequest : JdcloudRequest
    {
        ///<summary>
        /// url鉴权开启1关闭0
        ///</summary>
        public   int? AccesskeyType{ get; set; }
        ///<summary>
        /// url鉴权开启时必传
        ///</summary>
        public   string AccesskeyKey{ get; set; }
        ///<summary>
        /// 开启时默认值为300s,关闭时为0
        ///</summary>
        public   int? AuthLifeTime{ get; set; }
        ///<summary>
        /// 用户域名
        ///Required:true
        ///</summary>
        [Required]
        public   string Domain{ get; set; }
    }
}