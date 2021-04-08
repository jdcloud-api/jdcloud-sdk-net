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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Waf.Model
{

    /// <summary>
    ///  addDomain
    /// </summary>
    public class AddDomain
    {

        ///<summary>
        /// 实例id，代表要设置的WAF实例
        ///Required:true
        ///</summary>
        [Required]
        public string WafInstanceId{ get; set; }
        ///<summary>
        /// 域名，单个
        ///Required:true
        ///</summary>
        [Required]
        public string Domain{ get; set; }
        ///<summary>
        /// 域名数组
        ///</summary>
        public List<string> Domains{ get; set; }
        ///<summary>
        /// 使用协议，eg:[&quot;http&quot;,&quot;https&quot;]
        ///Required:true
        ///</summary>
        [Required]
        public List<string> Protocols{ get; set; }
        ///<summary>
        /// ssl协议，eg:[&quot;TLSv1&quot;,&quot;TLSv1.1&quot;,&quot;TLSv1.2&quot;,&quot;SSLv2&quot;,&quot;SSLv3&quot;]
        ///</summary>
        public List<string> SslProtocols{ get; set; }
        ///<summary>
        /// 负载均衡算法，eg:&quot;rr&quot;，&quot;ip_hash&quot;,&quot;weight_rr&quot;
        ///Required:true
        ///</summary>
        [Required]
        public string LbType{ get; set; }
        ///<summary>
        /// 回源配置
        ///Required:true
        ///</summary>
        [Required]
        public RsConfig RsConfig{ get; set; }
        ///<summary>
        /// 是否使用前置代理，0为未使用，1为使用
        ///</summary>
        public int? PureClient{ get; set; }
        ///<summary>
        /// 1为跳转 0为不跳转
        ///</summary>
        public int? HttpsRedirect{ get; set; }
        ///<summary>
        /// 用户服务器是否只能http回源，1为是，0为否
        ///</summary>
        public int? RsOnlySupportHttp{ get; set; }
        ///<summary>
        /// Waf侧支持http版本，不传时默认值为http1.1,传&quot;http2&quot;为http2
        ///</summary>
        public string HttpVersion{ get; set; }
        ///<summary>
        /// 回源是否支持长链接，0为否
        ///</summary>
        public int? EnableKeepalive{ get; set; }
        ///<summary>
        /// 加密套件等级，0表示默认为中级，1表示高级，2表示低级
        ///</summary>
        public int? SuiteLevel{ get; set; }
        ///<summary>
        /// 请求头是否支持下划线，0-否，1-是。缺省为0
        ///</summary>
        public int? EnableUnderscores{ get; set; }
        ///<summary>
        /// 禁用被动健康检查，缺省为0-否
        ///</summary>
        public int? DisableHealthCheck{ get; set; }
        ///<summary>
        /// 连接超时时间，3-60s
        ///</summary>
        public int? ProxyConnectTimeout{ get; set; }
    }
}
