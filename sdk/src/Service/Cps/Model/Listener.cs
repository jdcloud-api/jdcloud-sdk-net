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


namespace JDCloudSDK.Cps.Model
{

    /// <summary>
    ///  listener
    /// </summary>
    public class Listener
    {

        ///<summary>
        /// 监听器ID
        ///</summary>
        public string ListenerId{ get; set; }
        ///<summary>
        /// 负载均衡ID
        ///</summary>
        public string LoadBalancerId{ get; set; }
        ///<summary>
        /// 协议
        ///</summary>
        public string Protocol{ get; set; }
        ///<summary>
        /// 端口
        ///</summary>
        public int? Port{ get; set; }
        ///<summary>
        /// 调度算法
        ///</summary>
        public string Algorithm{ get; set; }
        ///<summary>
        /// 会话保持状态，取值on|off
        ///</summary>
        public string StickySession{ get; set; }
        ///<summary>
        /// 获取真实ip
        ///</summary>
        public string RealIp{ get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 健康检查状态，取值on|off
        ///</summary>
        public string HealthCheck{ get; set; }
        ///<summary>
        /// 健康检查响应的最大超时时间，单位s
        ///</summary>
        public int? HealthCheckTimeout{ get; set; }
        ///<summary>
        /// 健康检查响应的最大间隔时间，单位s
        ///</summary>
        public int? HealthCheckInterval{ get; set; }
        ///<summary>
        /// 健康检查结果为success的阈值
        ///</summary>
        public int? HealthyThreshold{ get; set; }
        ///<summary>
        /// 健康检查结果为fail的阈值
        ///</summary>
        public int? UnhealthyThreshold{ get; set; }
        ///<summary>
        /// 健康检查ip
        ///</summary>
        public string HealthCheckIp{ get; set; }
        ///<summary>
        /// 服务器组id
        ///</summary>
        public string ServerGroupId{ get; set; }
        ///<summary>
        /// 会话保持超时时间，单位s
        ///</summary>
        public int? StickySessionTimeout{ get; set; }
        ///<summary>
        /// 会话类型，植入Cookie or 重写Cookie
        ///</summary>
        public string CookieType{ get; set; }
        ///<summary>
        /// 检查路径
        ///</summary>
        public string HealthCheckUri{ get; set; }
        ///<summary>
        /// 正常态码，要使用的Http状态码
        ///</summary>
        public string HealthCheckHttpCode{ get; set; }
        ///<summary>
        /// 证书ID
        ///</summary>
        public string CertificateId{ get; set; }
        ///<summary>
        /// 获取HTTP头字段：X-Forwarded-For、X-Forwarded-Proto、X- Forwarded-Port、X-Forwarded-LBIP
        ///</summary>
        public List<string> Headers{ get; set; }
    }
}
