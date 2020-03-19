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


namespace JDCloudSDK.Es.Model
{

    /// <summary>
    ///  resource
    /// </summary>
    public class Resource
    {

        ///<summary>
        /// 资源名称，即节点名称
        ///</summary>
        public string ResName{ get; set; }
        ///<summary>
        /// 节点宿主机IP
        ///</summary>
        public string HostIp{ get; set; }
        ///<summary>
        /// 节点IP及端口
        ///</summary>
        public string IpPort{ get; set; }
    }
}
