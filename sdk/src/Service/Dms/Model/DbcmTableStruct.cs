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


namespace JDCloudSDK.Dms.Model
{

    /// <summary>
    ///  dbcmTableStruct
    /// </summary>
    public class DbcmTableStruct
    {

        ///<summary>
        /// 表中全部列信息。
        ///</summary>
        public List<DbcmColumn> Table_column{ get; set; }
        ///<summary>
        /// 主键列名。
        ///</summary>
        public string Primary_index{ get; set; }
        ///<summary>
        /// Table_info
        ///</summary>
        public DbcmTableInfo Table_info{ get; set; }
        ///<summary>
        /// 建表语句。
        ///</summary>
        public string Ddl{ get; set; }
        ///<summary>
        /// 列表中元素为列信息，类型hashmap，key名称有index_column，index_name，index_type，old_index_name；索引类型有NORMAL，UNIQUE
        ///</summary>
        public List<Dictionary<String,string>> Comm_index{ get; set; }
    }
}
