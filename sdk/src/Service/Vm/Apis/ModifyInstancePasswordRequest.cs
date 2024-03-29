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
 * 云主机
 * 与主机操作相关的接口
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

using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  
        ///         /// 修改云主机密码。
        ///         /// 
        ///         /// 详细操作说明请参考帮助文档：[重置密码](https://docs.jdcloud.com/cn/virtual-machines/reset-password)
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 实例没有正在进行中的任务时才可操作。
        ///         /// - 重置密码后，需要重启云主机后生效。
        ///         /// 
    /// </summary>
    public class ModifyInstancePasswordRequest : JdcloudRequest
    {
        ///<summary>
        /// 实例密码。
        /// 可用于SSH登录和VNC登录。
        /// 长度为8\~30个字符，必须同时包含大、小写英文字母、数字和特殊符号中的三类字符。特殊符号包括：&#x60;\(\)\&#x60;~!@#$%^&amp;\*\_-+&#x3D;\|{}\[ ]:&quot;;&#39;&lt;&gt;,.?/，&#x60;。
        /// 更多密码输入要求请参见 [公共参数规范](https://docs.jdcloud.com/virtual-machines/api/general_parameters)。
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string Password{ get; set; }
        ///<summary>
        /// 地域ID。
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 云主机ID。
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}