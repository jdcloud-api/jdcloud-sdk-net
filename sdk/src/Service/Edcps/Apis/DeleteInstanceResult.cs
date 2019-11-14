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
 * 分布式云物理服务器
 * 分布式云物理服务器操作相关的接口
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


namespace  JDCloudSDK.Edcps.Apis
{

    /// <summary>
    ///  删除单台云物理物理服务器，只能删除运行running、停止stopped、错误error状态的服务器&lt;br/&gt;
        ///         /// 不能删除没有计费信息的服务器&lt;br/&gt;
        ///         /// 
    /// </summary>
    public class DeleteInstanceResult : JdcloudResult
    {
        ///<summary>
        /// 删除操作是否成功
        ///</summary>
        public   bool Success{ get; set; }
    }
}