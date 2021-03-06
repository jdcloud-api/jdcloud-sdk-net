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
 * CoreSystem
 * coreSystem管理
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Iotedge.Apis
{

    /// <summary>
    ///  查询已发布核心系统和安装包的发布记录
    /// </summary>
    public class QueryResult : JdcloudResult
    {
        ///<summary>
        /// 核心系统版本
        ///</summary>
        public   string ComposeVersion{ get; set; }
        ///<summary>
        /// 安装包版本
        ///</summary>
        public   string AgentVersion{ get; set; }
        ///<summary>
        /// 核心系统状态，0-发布成功，1-发布失败，2-审核通过，3-审核不通过，4-上线，5-下线  99 未发布
        ///</summary>
        public   string ComposeFileStatus{ get; set; }
        ///<summary>
        /// 安装包状态，0-发布成功，1-发布失败，2-审核通过，3-审核不通过，4-上线，5-下线  99 未发布
        ///</summary>
        public   string AgentFileStatus{ get; set; }
        ///<summary>
        /// 核心系统发布时间
        ///</summary>
        public   string Compose_release_time{ get; set; }
        ///<summary>
        /// 安装包发布时间
        ///</summary>
        public   string Agent_release_time{ get; set; }
    }
}