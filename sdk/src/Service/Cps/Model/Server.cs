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


namespace JDCloudSDK.Cps.Model
{

    /// <summary>
    ///  server
    /// </summary>
    public class Server
    {

        ///<summary>
        /// 服务器ID
        ///</summary>
        public string ServerId{ get; set; }
        ///<summary>
        /// 资源类型
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public string InstanceName{ get; set; }
        ///<summary>
        /// 后端云物理服务器ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 可用区
        ///</summary>
        public string Az{ get; set; }
        ///<summary>
        /// 内网Ip
        ///</summary>
        public string PrivateIp{ get; set; }
        ///<summary>
        /// 端口
        ///</summary>
        public int? Port{ get; set; }
        ///<summary>
        /// 后端云物理服务器权重
        ///</summary>
        public int? Weight{ get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 健康状态
        ///</summary>
        public string HealthyStatus{ get; set; }
    }
}