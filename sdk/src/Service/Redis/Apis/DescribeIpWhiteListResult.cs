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
 * Redis Instance API
 * 缓存Redis实例的创建、删除、修改基本信息、设置密码、变配、实例列表、备份、配置参数等接口
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


namespace  JDCloudSDK.Redis.Apis
{

    /// <summary>
    ///  获取Redis实例的IP白名单（只有白名单内的IP、网络才能访问该实例）
    /// </summary>
    public class DescribeIpWhiteListResult : JdcloudResult
    {
        ///<summary>
        /// IP白名单列表（IP格式为CIDR表示法：x.x.x.x/x），默认为0.0.0.0/0，表示所有IP
        ///</summary>
        public List<string> IpWhiteList{ get; set; }

    }
}