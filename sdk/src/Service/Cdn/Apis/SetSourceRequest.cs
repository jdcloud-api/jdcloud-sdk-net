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
 * 域名操作类接口
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

using JDCloudSDK.Cdn.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  设置源站信息
    /// </summary>
    public class SetSourceRequest : JdcloudRequest
    {
        ///<summary>
        /// 回源类型只能是[ips,domain,oss]中的一种
        ///</summary>
        public   string SourceType{ get; set; }
        ///<summary>
        /// 回源方式,只能是[https,http]中的一种,默认http
        ///</summary>
        public   string BackSourceType{ get; set; }
        ///<summary>
        /// 加速区域,必须是[mainland,nonMainland,all]中的一种,分别代表大陆,海外+中国港澳台,全球
        ///</summary>
        public   string AccelerateRegion{ get; set; }
        ///<summary>
        /// IpSource
        ///</summary>
        public List<IpSourceInfo> IpSource{ get; set; }

        ///<summary>
        /// DomainSource
        ///</summary>
        public List<DomainSourceInfo> DomainSource{ get; set; }

        ///<summary>
        /// oss回源域名
        ///</summary>
        public   string OssSource{ get; set; }
        ///<summary>
        /// 默认回源host
        ///</summary>
        public   string DefaultSourceHost{ get; set; }
        ///<summary>
        /// 用户域名
        ///Required:true
        ///</summary>
        [Required]
        public   string Domain{ get; set; }
    }
}