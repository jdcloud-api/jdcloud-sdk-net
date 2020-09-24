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

namespace JDCloudSDK.Instancevoucher.Model
{

    /// <summary>
    ///  非资源预留型实例抵扣券参数
    /// </summary>
    public class NonReservedVoucherSpec
    {

        ///<summary>
        /// 实例规格族
        ///Required:true
        ///</summary>
        [Required]
        public string InstanceTypeFamily{ get; set; }
        ///<summary>
        /// cpu 核数 / gpu 卡数
        ///Required:true
        ///</summary>
        [Required]
        public int UnitCount{ get; set; }
    }
}
