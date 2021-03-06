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
 * CoreSystem
 * coreSystem管理
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

using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Iotedge.Apis
{

    /// <summary>
    ///  上线核心系统和安装包
    /// </summary>
    public class OnlineRequest : JdcloudRequest
    {
        ///<summary>
        /// 操作人
        ///</summary>
        public   string Operator{ get; set; }
        ///<summary>
        /// 文件版本号
        ///</summary>
        public   string SysVersion{ get; set; }
        ///<summary>
        /// 文件类型1-系统文件，2-安装包
        ///</summary>
        public   string FileType{ get; set; }
        ///<summary>
        /// 设备归属的实例所在区域
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 系统Id
        ///Required:true
        ///</summary>
        [Required]
        public   string OsId{ get; set; }
        ///<summary>
        /// 硬件Id
        ///Required:true
        ///</summary>
        [Required]
        public   string HardwareId{ get; set; }
    }
}