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


namespace JDCloudSDK.Smartdba.Model
{

    /// <summary>
    ///  slowLog
    /// </summary>
    public class SlowLog
    {

        ///<summary>
        /// 开始时间
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 用户名
        ///</summary>
        public string UserName{ get; set; }
        ///<summary>
        /// 执行时间(秒)
        ///</summary>
        public float? ExecTime{ get; set; }
        ///<summary>
        /// 锁等待时间(秒)
        ///</summary>
        public float? LockTime{ get; set; }
        ///<summary>
        /// 返回行数
        ///</summary>
        public float? RowsSent{ get; set; }
        ///<summary>
        /// 扫描行数
        ///</summary>
        public float? RowsExamined{ get; set; }
        ///<summary>
        /// sql语句
        ///</summary>
        public string Sql{ get; set; }
        ///<summary>
        /// 数据库名
        ///</summary>
        public string Database{ get; set; }
        ///<summary>
        /// 客户端IP
        ///</summary>
        public string Host{ get; set; }
        ///<summary>
        /// 日志类型
        ///</summary>
        public string LogType{ get; set; }
    }
}
