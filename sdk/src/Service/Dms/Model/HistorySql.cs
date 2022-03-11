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
    ///  historySql
    /// </summary>
    public class HistorySql
    {

        ///<summary>
        /// 主键id。
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 数据源id。
        ///</summary>
        public int? DataSourceId{ get; set; }
        ///<summary>
        /// 执行sql内容。
        ///</summary>
        public string SqlStr{ get; set; }
        ///<summary>
        /// 执行用户。
        ///</summary>
        public string User{ get; set; }
        ///<summary>
        /// 数据状态。0：有效，1：无效
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 创建时间，格式为：YYYY-MM-DD HH:mm:ss。
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 执行花费时间。
        ///</summary>
        public int? SpendTime{ get; set; }
        ///<summary>
        /// 执行消息。
        ///</summary>
        public string Message{ get; set; }
        ///<summary>
        /// dms执行地址。
        ///</summary>
        public string Ip{ get; set; }
        ///<summary>
        /// 数据库名称。
        ///</summary>
        public string DbName{ get; set; }
        ///<summary>
        /// 执行结束时间，格式为：YYYY-MM-DD HH:mm:ss。
        ///</summary>
        public string EndTime{ get; set; }
        ///<summary>
        /// 执行结果，SUCCESS：成功，FAILED失败。
        ///</summary>
        public string ExeStatus{ get; set; }
        ///<summary>
        /// sql类型, CREATE(&quot;CREATE&quot;, 0), ALTER_DATA(&quot;ALTER_DATA&quot;, 1), ALTER_STRUCT(&quot;ALTER_STRUCT&quot;, 2), DROP(&quot;DROP&quot;, 4), CONSOLE(&quot;CONSOLE&quot;, 5), BATCH_CREATE(&quot;BATCH_CREATE&quot;, 6), IMPORT_DATA(&quot;IMPORT_DATA&quot;, 7), EXPORT_STRUCT_DATA(&quot;EXPORT_STRUCT_DATA&quot;, 8);
        ///</summary>
        public string SqlType{ get; set; }
    }
}
