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
 * EdgeManager
 * iotcore-Edge管理
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
    ///  查询Edge详情
    /// </summary>
    public class DescribeEdgeDetailsWithCoreResult : JdcloudResult
    {
        ///<summary>
        /// Edge系统编号
        ///</summary>
        public   string EdgeId{ get; set; }
        ///<summary>
        /// Edge名称
        ///</summary>
        public   string EdgeName{ get; set; }
        ///<summary>
        /// Edge的identifier
        ///</summary>
        public   string Identifier{ get; set; }
        ///<summary>
        /// Edge描述
        ///</summary>
        public   string EdgeDesc{ get; set; }
        ///<summary>
        /// Edge的产品Key
        ///</summary>
        public   string ProductKey{ get; set; }
        ///<summary>
        /// 在线状态，0-未激活，1-离线状态，2-在线状态
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// Edge创建时间
        ///</summary>
        public   string CreateTime{ get; set; }
        ///<summary>
        /// 激活时间
        ///</summary>
        public   string ActiveTime{ get; set; }
        ///<summary>
        /// 最后在线时间
        ///</summary>
        public   string LastOnlineTime{ get; set; }
        ///<summary>
        /// 硬件平台
        ///</summary>
        public   string ArchitectureName{ get; set; }
        ///<summary>
        /// 操作系统
        ///</summary>
        public   string OsName{ get; set; }
        ///<summary>
        /// Edge生产厂家
        ///</summary>
        public   string Manufacturer{ get; set; }
        ///<summary>
        /// Edge型号
        ///</summary>
        public   string EdgeModel{ get; set; }
        ///<summary>
        /// Edge版本
        ///</summary>
        public   string EdgeVersion{ get; set; }
        ///<summary>
        /// Edge安装状态
        ///</summary>
        public   string EdgeUpgradeStatus{ get; set; }
        ///<summary>
        /// Edge正在安装的版本
        ///</summary>
        public   string EdgeUpgradeVersion{ get; set; }
        ///<summary>
        /// Edge Mac地址
        ///</summary>
        public   string EdgeMacAddr{ get; set; }
    }
}