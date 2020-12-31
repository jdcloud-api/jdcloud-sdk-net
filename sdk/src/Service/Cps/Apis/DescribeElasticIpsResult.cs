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
 * Cloud-Physical-Server
 * 云物理服务器弹性公网IP操作相关的接口
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

using JDCloudSDK.Cps.Model;

namespace  JDCloudSDK.Cps.Apis
{

    /// <summary>
    ///  查询弹性公网IP列表&lt;br/&gt;
        ///         /// 支持分页查询，默认每页20条&lt;br/&gt;
        ///         /// 
    /// </summary>
    public class DescribeElasticIpsResult : JdcloudResult
    {
        ///<summary>
        /// ElasticIps
        ///</summary>
        public List<ElasticIp> ElasticIps{ get; set; }

        ///<summary>
        /// 页码；默认为1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小；默认为20；取值范围[20, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 查询结果总数
        ///</summary>
        public   int? TotalCount{ get; set; }
    }
}