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
 * Backend
 * 后端服务相关接口
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
    ///  修改一个后端服务的信息
    /// </summary>
    public class UpdateBackendRequest : JdcloudRequest
    {
        ///<summary>
        /// 后端服务名称,只允许输入中文、数字、大小写字母、英文下划线“_”及中划线“-”，不允许为空且不超过32字符
        ///</summary>
        public   string BackendName{ get; set; }
        ///<summary>
        /// 健康检查信息
        ///</summary>
        public   HealthCheckSpec HealthCheckSpec{ get; set; }
        ///<summary>
        /// 调度算法 &lt;br&gt;【alb,nlb】取值范围为[IpHash, RoundRobin, LeastConn]（含义分别为：加权源Ip哈希，加权轮询和加权最小连接） &lt;br&gt;【dnlb】取值范围为[IpHash, QuintupleHash]（含义分别为：加权源Ip哈希和加权五元组哈希）
        ///</summary>
        public   string Algorithm{ get; set; }
        ///<summary>
        /// 虚拟服务器组的Id列表，目前只支持一个，且与agIds不能同时存在
        ///</summary>
        public List<string> TargetGroupIds{ get; set; }

        ///<summary>
        /// 高可用组的Id列表，目前只支持一个，且与targetGroupIds不能同时存在
        ///</summary>
        public List<string> AgIds{ get; set; }

        ///<summary>
        /// 【alb Tcp协议】是否启用Proxy ProtocolV1协议获取真实源ip, 取值为false(不开启)或者true(开启), 默认为false
        ///</summary>
        public   bool ProxyProtocol{ get; set; }
        ///<summary>
        /// 描述,允许输入UTF-8编码下的全部字符，不超过256字符
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 会话保持, 取值为false(不开启)或者true(开启)，默认为false &lt;br&gt;【alb Http协议，RoundRobin算法】支持基于cookie的会话保持 &lt;br&gt;【nlb】支持基于报文源目的IP的会话保持
        ///</summary>
        public   bool SessionStickiness{ get; set; }
        ///<summary>
        /// 【nlb】会话保持超时时间，sessionStickiness开启时生效, 取值范围[1-3600]
        ///</summary>
        public   int? SessionStickyTimeout{ get; set; }
        ///<summary>
        /// 【nlb】连接耗尽超时，移除target前，连接的最大保持时间，默认300s，取值范围[0-3600]
        ///</summary>
        public   int? ConnectionDrainingSeconds{ get; set; }
        ///<summary>
        /// 【alb Http协议】cookie的过期时间,sessionStickiness开启时生效，取值范围为[0-86400], 0表示cookie与浏览器同生命周期
        ///</summary>
        public   int? HttpCookieExpireSeconds{ get; set; }
        ///<summary>
        /// 【alb Http协议】获取负载均衡的协议, 取值为False(不获取)或True(获取)
        ///</summary>
        public   bool HttpForwardedProtocol{ get; set; }
        ///<summary>
        /// 【alb Http协议】获取负载均衡的端口, 取值为False(不获取)或True(获取)
        ///</summary>
        public   bool HttpForwardedPort{ get; set; }
        ///<summary>
        /// 【alb Http协议】获取负载均衡的host信息, 取值为False(不获取)或True(获取)
        ///</summary>
        public   bool HttpForwardedHost{ get; set; }
        ///<summary>
        /// 【alb Http协议】获取负载均衡的vip, 取值为False(不获取)或True(获取)
        ///</summary>
        public   bool HttpForwardedVip{ get; set; }
        ///<summary>
        /// 【alb,dnlb】关闭健康检查，取值为false(不关闭)或true(关闭)
        ///</summary>
        public   bool CloseHealthCheck{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// Backend Id
        ///Required:true
        ///</summary>
        [Required]
        public   string BackendId{ get; set; }
    }
}