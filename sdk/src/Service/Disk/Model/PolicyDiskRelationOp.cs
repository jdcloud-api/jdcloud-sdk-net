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

namespace JDCloudSDK.Disk.Model
{

    /// <summary>
    ///  绑定/解绑 策略 与 Disk 的操作类
    /// </summary>
    public class PolicyDiskRelationOp
    {

        ///<summary>
        /// 磁盘ID
        ///Required:true
        ///</summary>
        [Required]
        public string DiskId{ get; set; }
        ///<summary>
        /// 磁盘地域ID
        ///Required:true
        ///</summary>
        [Required]
        public string DiskRegion{ get; set; }
        ///<summary>
        /// 快照策略ID
        ///Required:true
        ///</summary>
        [Required]
        public string PolicyId{ get; set; }
        ///<summary>
        /// 联系组id
        ///Required:true
        ///</summary>
        [Required]
        public int Op{ get; set; }
    }
}
