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


namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  云硬盘信息。
    /// </summary>
    public class LightCloudDiskInfo
    {

        ///<summary>
        /// 云硬盘ID。
        ///</summary>
        public string DiskId{ get; set; }
        ///<summary>
        /// 云硬盘类型。取值范围：&#x60;ssd、premium-hdd、hdd.std1、ssd.gp1、ssd.io1&#x60;。
        ///</summary>
        public string DiskType{ get; set; }
        ///<summary>
        /// 云硬盘大小，单位为 GiB。
        ///</summary>
        public int? DiskSizeGB{ get; set; }
    }
}
