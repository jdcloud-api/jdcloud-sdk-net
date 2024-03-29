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


namespace JDCloudSDK.Clickhouse.Model
{

    /// <summary>
    ///  auditLog
    /// </summary>
    public class AuditLog
    {

        ///<summary>
        /// 源IP
        ///</summary>
        public string Ip{ get; set; }
        ///<summary>
        /// 初始请求ID
        ///</summary>
        public string RequestId{ get; set; }
        ///<summary>
        /// 节点名称
        ///</summary>
        public string SegmentName{ get; set; }
        ///<summary>
        /// SQL语句
        ///</summary>
        public string Sql{ get; set; }
        ///<summary>
        /// accountName
        ///</summary>
        public string AccountName{ get; set; }
        ///<summary>
        /// SQL开始执行时间
        ///</summary>
        public string StartTime{ get; set; }
    }
}
