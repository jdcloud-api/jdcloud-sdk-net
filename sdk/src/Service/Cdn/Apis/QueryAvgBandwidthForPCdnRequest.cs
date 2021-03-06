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
 * PCdn统计查询接口
 * Openapi For JCLOUD cdn
 *
 * OpenAPI spec version: v1
 * Contact: pid-cdn@jd.com
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  查询平均带宽
    /// </summary>
    public class QueryAvgBandwidthForPCdnRequest : JdcloudRequest
    {
        ///<summary>
        /// 指定查询开始时间(格式:201906011000)，返回数据包含该时间点。
        ///Required:true
        ///</summary>
        [Required]
        public   string Starttime{ get; set; }
        ///<summary>
        /// 指定查询结束时间(格式:201906011100)，返回数据不包含该时间点
        ///Required:true
        ///</summary>
        [Required]
        public   string Stoptime{ get; set; }
        ///<summary>
        /// 按照设备ID查询设备带宽。
        ///</summary>
        public   string Clientid{ get; set; }
        ///<summary>
        /// 用于支持分页查询，默认为1，表示第几页。
        ///</summary>
        public   int? Page{ get; set; }
        ///<summary>
        /// 用于支持分页查询，表示每页返回多少条数据，默认每页返回10条数据，size必须是10的整数倍，并且最大值是100。
        ///</summary>
        public   int? Size{ get; set; }
    }
}