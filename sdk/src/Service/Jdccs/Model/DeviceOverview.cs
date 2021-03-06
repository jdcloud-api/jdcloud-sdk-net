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


namespace JDCloudSDK.Jdccs.Model
{

    /// <summary>
    ///  设备概览
    /// </summary>
    public class DeviceOverview
    {

        ///<summary>
        /// 设备总数目
        ///</summary>
        public int? Sum{ get; set; }
        ///<summary>
        /// 服务器总数目
        ///</summary>
        public int? Server{ get; set; }
        ///<summary>
        /// 网络设备总数目
        ///</summary>
        public int? Network{ get; set; }
        ///<summary>
        /// 存储设备总数目
        ///</summary>
        public int? Storage{ get; set; }
        ///<summary>
        /// 其它设备总数目
        ///</summary>
        public int? Other{ get; set; }
        ///<summary>
        /// 已开通
        ///</summary>
        public int? Opened{ get; set; }
        ///<summary>
        /// 已上架
        ///</summary>
        public int? Launched{ get; set; }
        ///<summary>
        /// 操作中
        ///</summary>
        public int? Operating{ get; set; }
        ///<summary>
        /// 变更中
        ///</summary>
        public int? Modifying{ get; set; }
        ///<summary>
        /// 退订中
        ///</summary>
        public int? Canceling{ get; set; }
    }
}
