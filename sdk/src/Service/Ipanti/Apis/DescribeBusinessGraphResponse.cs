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
 * Anti DDoS Pro Flow APIs
 * Anti DDoS Pro Flow APIs
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


namespace  JDCloudSDK.Ipanti.Apis
{

    /// <summary>
    ///  业务流量报表        
        ///         /// 参数 serviceIp 优先级大于 instanceId.
        ///         /// - 指定 serviceIp 参数时, 忽略 instanceId 参数, 查询 ip 相关报表
        ///         /// - 未指定 serviceIp 时, 查询 instanceId 指定实例相关报表
        ///         /// - serviceIp 和 instanceId 均未指定时, 查询用户所有实例报表
        ///         /// 
    /// </summary>
    public class DescribeBusinessGraphResponse : JdcloudResponse<DescribeBusinessGraphResult>
    {
    }
}