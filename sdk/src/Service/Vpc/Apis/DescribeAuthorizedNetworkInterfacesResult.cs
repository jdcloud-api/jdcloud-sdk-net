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
 * Elastic-Network-Interface
 * 弹性网卡相关接口
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

using JDCloudSDK.Vpc.Model;

namespace  JDCloudSDK.Vpc.Apis
{

    /// <summary>
    ///  查询授信弹性网卡列表，仅支持京东云许可服务账号使用
    /// </summary>
    public class DescribeAuthorizedNetworkInterfacesResult : JdcloudResult
    {
        ///<summary>
        /// networkInterface资源信息列表
        ///</summary>
        public List<NetworkInterface> NetworkInterfaces{ get; set; }

        ///<summary>
        /// 总数量
        ///</summary>
        public   double? TotalCount{ get; set; }
    }
}