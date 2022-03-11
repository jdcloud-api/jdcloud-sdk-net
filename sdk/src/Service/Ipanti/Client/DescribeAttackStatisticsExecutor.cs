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
 * Anti DDoS Pro Attack Log APIs
 * Anti DDoS Pro Attack Log APIs
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

namespace JDCloudSDK.Ipanti.Client
{

    /// <summary>
    ///  查询攻击次数及流量峰值
        /// 参数 serviceIp 优先级大于 instanceId.
        /// - 指定 serviceIp 参数时, 忽略 instanceId 参数, 统计 ip 相关攻击
        /// - 未指定 serviceIp 时, 统计 instanceId 指定实例相关攻击
        /// - serviceIp 和 instanceId 均未指定时, 统计用户所有攻击记录
        /// CC攻击为实例级别, 查询类型 type 为 cc 时, 参数 serviceIp 无效
        /// 
    /// </summary>
    public class DescribeAttackStatisticsExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  查询攻击次数及流量峰值
        /// 参数 serviceIp 优先级大于 instanceId.
        /// - 指定 serviceIp 参数时, 忽略 instanceId 参数, 统计 ip 相关攻击
        /// - 未指定 serviceIp 时, 统计 instanceId 指定实例相关攻击
        /// - serviceIp 和 instanceId 均未指定时, 统计用户所有攻击记录
        /// CC攻击为实例级别, 查询类型 type 为 cc 时, 参数 serviceIp 无效
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "GET";
            }
        }
        /// <summary>
        ///  查询攻击次数及流量峰值
        /// 参数 serviceIp 优先级大于 instanceId.
        /// - 指定 serviceIp 参数时, 忽略 instanceId 参数, 统计 ip 相关攻击
        /// - 未指定 serviceIp 时, 统计 instanceId 指定实例相关攻击
        /// - serviceIp 和 instanceId 均未指定时, 统计用户所有攻击记录
        /// CC攻击为实例级别, 查询类型 type 为 cc 时, 参数 serviceIp 无效
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/attacklog:describeAttackStatistics";
            }
        }
    }
}
