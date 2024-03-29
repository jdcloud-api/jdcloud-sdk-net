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
 * Listener
 * 监听器资源相关接口
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

using JDCloudSDK.Lb.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Lb.Apis
{

    /// <summary>
    ///  创建一个监听器
    /// </summary>
    public class CreateListenerRequest : JdcloudRequest
    {
        ///<summary>
        /// Listener的名字,只允许输入中文、数字、大小写字母、英文下划线“_”及中划线“-”，不允许为空且不超过32字符
        ///Required:true
        ///</summary>
        [Required]
        public   string ListenerName{ get; set; }
        ///<summary>
        /// 监听协议, 取值为Tcp, Tls, Http, Https, Udp &lt;br&gt;【alb】支持Http, Https，Tcp、Tls和Udp &lt;br&gt;【nlb】支持Tcp, Udp  &lt;br&gt;【dnlb】支持Tcp, Udp
        ///Required:true
        ///</summary>
        [Required]
        public   string Protocol{ get; set; }
        ///<summary>
        /// 【alb使用https时支持】是否开启HSTS，True(开启)， False(关闭)，缺省为False
        ///</summary>
        public   bool HstsEnable{ get; set; }
        ///<summary>
        /// 【alb使用https时支持】HSTS过期时间(秒)，取值范围为[1, 94608000(3年)]，缺省为31536000(1年)
        ///</summary>
        public   int? HstsMaxAge{ get; set; }
        ///<summary>
        /// 监听端口，取值范围为[1, 65535]
        ///Required:true
        ///</summary>
        [Required]
        public   int Port{ get; set; }
        ///<summary>
        /// 默认的后端服务Id
        ///Required:true
        ///</summary>
        [Required]
        public   string BackendId{ get; set; }
        ///<summary>
        /// Listener所属loadBalancer的Id
        ///Required:true
        ///</summary>
        [Required]
        public   string LoadBalancerId{ get; set; }
        ///<summary>
        /// 【alb Https和Http协议】转发规则组Id
        ///</summary>
        public   string UrlMapId{ get; set; }
        ///<summary>
        /// 默认后端服务的转发策略,取值为Forward或Redirect, 现只支持Forward, 默认为Forward
        ///</summary>
        public   string Action{ get; set; }
        ///<summary>
        /// 【alb Https和Tls协议】Listener绑定的默认证书，最多支持两个，两个证书的加密算法需要不同
        ///</summary>
        public List<CertificateSpec> CertificateSpecs{ get; set; }

        ///<summary>
        /// 【alb、nlb】空闲连接超时时间, 范围为[1,86400]。 &lt;br&gt;（Tcp和Tls协议）默认为：1800s &lt;br&gt;（Udp协议）默认为：300s &lt;br&gt;（Http和Https协议）默认为：60s &lt;br&gt;【dnlb】不支持
        ///</summary>
        public   int? ConnectionIdleTimeSeconds{ get; set; }
        ///<summary>
        /// 描述,允许输入UTF-8编码下的全部字符，不超过256字符
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}