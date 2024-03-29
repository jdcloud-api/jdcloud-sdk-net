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

namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  实例模板弹性网卡挂载点信息。
    /// </summary>
    public class InstanceTemplateNetworkInterfaceAttachment
    {

        ///<summary>
        /// 网卡设备Index。创建实例时此参数无须指定且指定无效。
        /// 对于主网卡默认Index为1，辅助网卡自动分配。
        /// 
        ///</summary>
        public int? DeviceIndex{ get; set; }
        ///<summary>
        /// 是否随实例一起删除。
        /// &#x60;true&#x60;：随实例删除。
        /// &#x60;false&#x60;（默认值）：不随实例删除。
        /// 
        ///</summary>
        public bool AutoDelete{ get; set; }
        ///<summary>
        /// 网卡设备详细配置。
        ///Required:true
        ///</summary>
        [Required]
        public InstanceTemplateNetworkInterface NetworkInterface{ get; set; }
    }
}
