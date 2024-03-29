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
    ///  instancesInfo
    /// </summary>
    public class InstancesInfo
    {

        ///<summary>
        /// rds实例id
        ///</summary>
        public string ClusterGid{ get; set; }
        ///<summary>
        /// 端口号
        ///</summary>
        public int? Port{ get; set; }
        ///<summary>
        /// rds实例名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 数据库版本, 如： MySQL
        ///</summary>
        public string EngineVersion{ get; set; }
        ///<summary>
        /// 实例类型，如：cluster，standalone
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// 接入状态
        ///</summary>
        public string InstanceStatus{ get; set; }
        ///<summary>
        /// 接入状态描述
        ///</summary>
        public string Message{ get; set; }
        ///<summary>
        /// 接入来源，目前默认rds
        ///</summary>
        public string Source{ get; set; }
    }
}
