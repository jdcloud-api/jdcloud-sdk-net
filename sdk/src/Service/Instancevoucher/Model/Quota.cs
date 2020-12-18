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


namespace JDCloudSDK.Instancevoucher.Model
{

    /// <summary>
    ///  quota
    /// </summary>
    public class Quota
    {

        ///<summary>
        /// 产品类型
        ///</summary>
        public string ResourceType{ get; set; }
        ///<summary>
        /// 资源分配方式
        ///</summary>
        public string ReservedType{ get; set; }
        ///<summary>
        /// cpu 核数上限
        ///</summary>
        public int? CpuLimit{ get; set; }
        ///<summary>
        /// cpu 已使用核数
        ///</summary>
        public int? CpuUsed{ get; set; }
        ///<summary>
        /// gpu 卡数上限
        ///</summary>
        public int? GpuLimit{ get; set; }
        ///<summary>
        /// gpu 已使用卡数
        ///</summary>
        public int? GpuUsed{ get; set; }
    }
}