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
 * 云物理服务器操作相关的接口
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
    ///  查询单个云物理服务器已安装的RAID信息，包括系统盘RAID信息和数据盘RAID信息
    /// </summary>
    public class DescribeInstanceRaidResult : JdcloudResult
    {
        ///<summary>
        /// 系统盘RAID类型ID
        ///</summary>
        public   string SysRaidTypeId{ get; set; }
        ///<summary>
        /// 系统盘RAID类型
        ///</summary>
        public   string SysRaidType{ get; set; }
        ///<summary>
        /// 数据盘RAID类型ID
        ///</summary>
        public   string DataRaidTypeId{ get; set; }
        ///<summary>
        /// 数据盘RAID类型
        ///</summary>
        public   string DataRaidType{ get; set; }
    }
}