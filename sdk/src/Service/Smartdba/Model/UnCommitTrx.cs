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
    ///  unCommitTrx
    /// </summary>
    public class UnCommitTrx
    {

        ///<summary>
        /// 会话用户
        ///</summary>
        public string User{ get; set; }
        ///<summary>
        /// 数据库
        ///</summary>
        public string Db{ get; set; }
        ///<summary>
        /// 会话源端IP
        ///</summary>
        public string Host{ get; set; }
        ///<summary>
        /// 当前状态
        ///</summary>
        public string State{ get; set; }
        ///<summary>
        /// session开始时间
        ///</summary>
        public int? StartTime{ get; set; }
        ///<summary>
        /// 最后执行的sql
        ///</summary>
        public string LastSql{ get; set; }
    }
}