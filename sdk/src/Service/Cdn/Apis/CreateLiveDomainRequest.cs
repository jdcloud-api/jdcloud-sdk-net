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

using JDCloudSDK.Cdn.Model;

namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  创建直播域名V2
    /// </summary>
    public class CreateLiveDomainRequest : JdcloudRequest
    {
        ///<summary>
        /// 播放域名（仅siteType&#x3D;1且publishDomain不为空时可为空）
        ///</summary>
        public   string PlayDomain{ get; set; }
        ///<summary>
        /// 推流域名（siteType&#x3D;push时playDomain与publishDomain不能同时传入）
        ///</summary>
        public   string PublishDomain{ get; set; }
        ///<summary>
        /// 回源类型只能是[ips,domain]中的一种
        ///</summary>
        public   string SourceType{ get; set; }
        ///<summary>
        /// BackHttpType
        ///</summary>
        public   string BackHttpType{ get; set; }
        ///<summary>
        /// 默认回源host
        ///</summary>
        public   string DefaultSourceHost{ get; set; }
        ///<summary>
        /// 站点类型1:push(推流模式),2:pull(拉流模式),3:mix(混合模式)
        ///</summary>
        public   string SiteType{ get; set; }
        ///<summary>
        /// 回源类型，支持rtmp, http-flv, https-flv, http-hls,https-hls，默认rtmp
        ///</summary>
        public   string BackSourceType{ get; set; }
        ///<summary>
        /// 播放协议，默认为rtmp,hdl,hls全选
        ///</summary>
        public List<string> PlayProtocol{ get; set; }

        ///<summary>
        /// 转推地址
        ///</summary>
        public   string ForwardCustomVhost{ get; set; }
        ///<summary>
        /// 回源IP信息
        ///</summary>
        public List<IpSourceInfo> IpSource{ get; set; }

        ///<summary>
        /// 回源域名信息
        ///</summary>
        public List<DomainSourceInfo> DomainSource{ get; set; }

        ///<summary>
        /// 默认为H.264
        ///</summary>
        public   string VideoType{ get; set; }
        ///<summary>
        /// 默认为AAC
        ///</summary>
        public   string AudioType{ get; set; }
    }
}