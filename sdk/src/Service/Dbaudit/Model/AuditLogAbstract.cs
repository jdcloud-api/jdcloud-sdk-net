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


namespace JDCloudSDK.Dbaudit.Model
{

    /// <summary>
    ///  auditLogAbstract
    /// </summary>
    public class AuditLogAbstract
    {

        ///<summary>
        /// 日志ID
        ///</summary>
        public string LogId{ get; set; }
        ///<summary>
        /// 操作类型，如SELECT
        ///</summary>
        public string Operation{ get; set; }
        ///<summary>
        /// 捕获时间
        ///</summary>
        public string CaptureTime{ get; set; }
        ///<summary>
        /// 客户端IP
        ///</summary>
        public string ClientIp{ get; set; }
        ///<summary>
        /// 风险级别: 0-&gt;无风险，1-&gt;低风险，2-&gt;中风险，3-&gt;高风险
        ///</summary>
        public int? RiskLevel{ get; set; }
        ///<summary>
        /// 执行时间,如5μs,3ms
        ///</summary>
        public string Duration{ get; set; }
        ///<summary>
        /// 执行结果：
        /// 0：默认
        /// 1：未知
        /// 2：登录成功
        /// 3：登录失败
        /// 4：超时
        /// 5：执行成功
        /// 6：执行失败
        /// 7：语句不合法
        /// 8：注销
        /// 9：会话开始
        /// 10：阻断
        /// 11：会话断开
        /// 
        ///</summary>
        public int? ExecuteResult{ get; set; }
    }
}
