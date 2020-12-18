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


namespace JDCloudSDK.Rds.Model
{

    /// <summary>
    ///  readWriteProxy
    /// </summary>
    public class ReadWriteProxy
    {

        ///<summary>
        /// 读写分离代理服务 ID
        ///</summary>
        public string ReadWriteProxyId{ get; set; }
        ///<summary>
        /// 读写分离代理服务的状态；参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 读写分离代理服务关联的RDS实例 ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 读写分离代理服务公网域名
        ///</summary>
        public string PublicDomainName{ get; set; }
        ///<summary>
        /// 读写分离代理服务内网域名
        ///</summary>
        public string InternalDomainName{ get; set; }
        ///<summary>
        /// 读写分离代理服务访问端口
        ///</summary>
        public string Port{ get; set; }
        ///<summary>
        /// 延迟阈值
        ///</summary>
        public int? DelayThreshold{ get; set; }
        ///<summary>
        /// 读写分离代理后端实例负载均衡策略；当前支持的负载均衡策略请查看[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///</summary>
        public string LoadBalancerPolicy{ get; set; }
        ///<summary>
        /// 后端实例健康检查配置详情
        ///</summary>
        public HealthCheck HealthCheck{ get; set; }
    }
}