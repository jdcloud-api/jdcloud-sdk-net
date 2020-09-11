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
 * 头条回源参数配置接口
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
    ///  dash鉴权设置
    /// </summary>
    public class SetAuthConfigRequest : JdcloudRequest
    {
        ///<summary>
        /// 是否开启鉴权[on,off]
        ///</summary>
        public   string EnableUrlAuth{ get; set; }
        ///<summary>
        /// 鉴权key
        ///</summary>
        public   string AuthKey{ get; set; }
        ///<summary>
        /// 鉴权时间戳过期时间，默认为0
        ///</summary>
        public   int? Age{ get; set; }
        ///<summary>
        /// 鉴权参数加密算法，默认为md5且只支持md5
        ///</summary>
        public   string EncAlgorithm{ get; set; }
        ///<summary>
        /// 时间戳格式[hex,dec]
        ///</summary>
        public   string TimeFormat{ get; set; }
        ///<summary>
        /// 加密算法版本[dash,dashv2,video],默认dashv2
        ///</summary>
        public   string UriType{ get; set; }
        ///<summary>
        /// 鉴权key生成顺序
        ///</summary>
        public   string Rule{ get; set; }
        ///<summary>
        /// 用户域名
        ///Required:true
        ///</summary>
        [Required]
        public   string Domain{ get; set; }
    }
}