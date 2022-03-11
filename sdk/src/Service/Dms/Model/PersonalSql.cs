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
    ///  personalSql
    /// </summary>
    public class PersonalSql
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
        /// 修改用户。
        ///</summary>
        public string ModifiedBy{ get; set; }
        ///<summary>
        /// 数据状态。
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 创建时间，格式为：YYYY-MM-DD HH:mm:ss。
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 收藏消息用户。
        ///</summary>
        public string User{ get; set; }
        ///<summary>
        /// Sql备注。
        ///</summary>
        public string Hint{ get; set; }
    }
}
