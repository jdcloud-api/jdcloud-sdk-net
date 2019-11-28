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


namespace JDCloudSDK.Yunding.Model
{

    /// <summary>
    ///  cluster
    /// </summary>
    public class Cluster
    {

        ///<summary>
        /// id
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 数据中心
        ///</summary>
        public string DataCenter{ get; set; }
        ///<summary>
        /// 域名
        ///</summary>
        public string Domain{ get; set; }
        ///<summary>
        /// 端口号
        ///</summary>
        public string ConnectionPort{ get; set; }
        ///<summary>
        /// 数据库引擎
        ///</summary>
        public string DbEngine{ get; set; }
        ///<summary>
        /// 数据库版本
        ///</summary>
        public string DbVersion{ get; set; }
    }
}
