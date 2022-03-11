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
 * Inspect-Diagnose
 * 诊断和巡检相关接口
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Smartdba.Model;

namespace  JDCloudSDK.Smartdba.Apis
{

    /// <summary>
    ///  获取巡检记录
    /// </summary>
    public class DescribeInspectResult : JdcloudResult
    {
        ///<summary>
        /// 巡检分值
        ///</summary>
        public   int? Score{ get; set; }
        ///<summary>
        /// 巡检范围的起始时间，如：2021-11-09T00:00:00Z
        ///</summary>
        public   string BeginTime{ get; set; }
        ///<summary>
        /// 巡检范围的截至时间，如：2021-11-09T23:59:59Z
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 资源使用率
        ///</summary>
        public   SystemView SystemView{ get; set; }
        ///<summary>
        /// 连接数
        ///</summary>
        public   ConnectView ConnectView{ get; set; }
        ///<summary>
        /// 锁信息
        ///</summary>
        public   EngineView EngineView{ get; set; }
        ///<summary>
        /// 库表空间
        ///</summary>
        public   SchemaView SchemaView{ get; set; }
        ///<summary>
        /// 磁盘空间
        ///</summary>
        public   DiskView DiskView{ get; set; }
        ///<summary>
        /// 慢sql
        ///</summary>
        public   SlowLowView SlowLowView{ get; set; }
        ///<summary>
        /// 扣分明细
        ///</summary>
        public List<KV> Detail{ get; set; }

    }
}