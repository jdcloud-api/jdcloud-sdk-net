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

namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  putBody
    /// </summary>
    public class PutBody
    {

        ///<summary>
        /// 目前统一用jcloud
        ///Required:true
        ///</summary>
        [Required]
        public string AppCode{ get; set; }
        ///<summary>
        /// 资源的类型，取值vm,ip,database,storage,disk,cdn,redis,balance,nat_gw,db_ro,vpn,ddos等,新接入的产品要求与opentapi命名的产品线名称一致
        ///Required:true
        ///</summary>
        [Required]
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 地域信息，如 cn-north-1 等
        ///Required:true
        ///</summary>
        [Required]
        public string Region{ get; set; }
        ///<summary>
        /// 资源的唯一表示，一般为uuid
        ///Required:true
        ///</summary>
        [Required]
        public string ResourceId{ get; set; }
        ///<summary>
        /// 监控数据点
        ///Required:true
        ///</summary>
        [Required]
        public List<DataPointX> DataPoints{ get; set; }
    }
}
