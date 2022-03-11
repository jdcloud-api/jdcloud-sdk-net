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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Dbs.Model
{

    /// <summary>
    ///  restoreSourceEndpoint
    /// </summary>
    public class RestoreSourceEndpoint
    {

        ///<summary>
        /// 备份代理的ID，仅初始化时可设置，设置完成并开始备份后，不可修改
        ///Required:true
        ///</summary>
        [Required]
        public string BackupAgentId{ get; set; }
        ///<summary>
        /// 源数据库的网络类型 PublicAccess 和 RDS
        ///Required:true
        ///</summary>
        [Required]
        public string NetworkType{ get; set; }
        ///<summary>
        /// 源数据库的端口，仅初始化时可设置，设置完成并开始备份后，不可修改
        ///Required:true
        ///</summary>
        [Required]
        public int Port{ get; set; }
        ///<summary>
        /// 源数据库的账号
        ///Required:true
        ///</summary>
        [Required]
        public string AccountName{ get; set; }
        ///<summary>
        /// 源数据库的密码
        ///</summary>
        public string Password{ get; set; }
        ///<summary>
        /// 不同数据库引擎独有的配置参数
        ///</summary>
        public EngineRelatedConfig EngineRelatedConfig{ get; set; }
    }
}
