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
 * Distributed-Cloud-Physical-Server
 * 分布式云物理服务器弹性公网IP操作相关的接口
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


namespace  JDCloudSDK.Edcps.Apis
{

    /// <summary>
    ///  查询弹性公网IP库存
    /// </summary>
    public class DescribeElasticIpStockResult : JdcloudResult
    {
        ///<summary>
        /// 地域
        ///</summary>
        public   string Region{ get; set; }
        ///<summary>
        /// 可用弹性公网IP库存
        ///</summary>
        public   int? Available{ get; set; }
        ///<summary>
        /// 可用带宽库存
        ///</summary>
        public   int? AvailableBandwidth{ get; set; }
        ///<summary>
        /// 可用额外上行带宽库存
        ///</summary>
        public   int? AvailableExtraUplinkBandwidth{ get; set; }
    }
}