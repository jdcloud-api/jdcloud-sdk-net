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
    ///  新建数据库的配置
    /// </summary>
    public class DatabaseSpec
    {

        ///<summary>
        /// 数据库名称，库名,长度限制32字节,允许英文字母,数字,下划线,中划线和中文
        ///</summary>
        public string DbName{ get; set; }
        ///<summary>
        /// 数据库地址, 可以是IP或域名，支持IPv6
        ///</summary>
        public string DbAddr{ get; set; }
        ///<summary>
        /// 数据库端口
        ///</summary>
        public int? DbPort{ get; set; }
        ///<summary>
        /// 数据库类型: 
        /// 0-&gt;Oracle
        /// 1-&gt;SQLServer
        /// 2-&gt;DB2
        /// 3-&gt;MySQL
        /// 4-&gt;Cache
        /// 5-&gt;Sybase
        /// 6-&gt;DM7
        /// 7-&gt;Informix
        /// 9-&gt;人大金仓
        /// 10-&gt;Teradata
        /// 11-&gt;Postgresql
        /// 12-&gt;Gbase
        /// 16-&gt;Hive
        /// 17-&gt;MongoDB
        /// 
        ///</summary>
        public int? DbType{ get; set; }
        ///<summary>
        /// 数据库版本
        ///</summary>
        public string DbVersion{ get; set; }
        ///<summary>
        /// 用户名，SQLServer获取登录信息使用
        ///</summary>
        public string Username{ get; set; }
        ///<summary>
        /// 密码，SQLServer获取登录信息使用
        ///</summary>
        public string Password{ get; set; }
        ///<summary>
        /// 数据库的描述
        ///</summary>
        public string DbDesc{ get; set; }
        ///<summary>
        /// 是否对数据进行掩码
        ///</summary>
        public bool DataMask{ get; set; }
        ///<summary>
        /// 是否对响应进行审计
        ///</summary>
        public bool AuditResponse{ get; set; }
    }
}