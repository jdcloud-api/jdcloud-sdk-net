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
 * Cloud-Physical-Server
 * 云物理服务器后端服务器操作相关的接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Cps.Apis
{

    /// <summary>
    ///  修改后端服务器
    /// </summary>
    public class ModifyServerResult : JdcloudResult
    {
        ///<summary>
        /// 后端服务器ID
        ///</summary>
        public   string ServerId{ get; set; }
        ///<summary>
        /// 后端云物理服务器ID
        ///</summary>
        public   string InstanceId{ get; set; }
        ///<summary>
        /// 内网Ip
        ///</summary>
        public   string PrivateIp{ get; set; }
        ///<summary>
        /// 端口
        ///</summary>
        public   int? Port{ get; set; }
        ///<summary>
        /// 后端云物理服务器权重
        ///</summary>
        public   int? Weight{ get; set; }
    }
}