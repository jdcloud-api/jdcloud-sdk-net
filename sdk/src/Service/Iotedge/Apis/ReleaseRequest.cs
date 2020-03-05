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
    ///  发布edge核心系统和安装包
    /// </summary>
    public class ReleaseRequest : JdcloudRequest
    {
        ///<summary>
        /// 硬件平台
        ///Required:true
        ///</summary>
        [Required]
        public   string HardwareId{ get; set; }
        ///<summary>
        /// 操作系统
        ///Required:true
        ///</summary>
        [Required]
        public   string OperSystemId{ get; set; }
        ///<summary>
        /// 资源来源iotcore，iothub，third
        ///Required:true
        ///</summary>
        [Required]
        public   string SourceId{ get; set; }
        ///<summary>
        /// 编译人
        ///Required:true
        ///</summary>
        [Required]
        public   string TriggerUser{ get; set; }
        ///<summary>
        /// 操作者
        ///Required:true
        ///</summary>
        [Required]
        public   string Operator{ get; set; }
        ///<summary>
        /// 系统版本编译时间
        ///Required:true
        ///</summary>
        [Required]
        public   string TriggerTime{ get; set; }
        ///<summary>
        /// 云翼里部署包的OSS地址
        ///Required:true
        ///</summary>
        [Required]
        public   string ArkPackageAddr{ get; set; }
        ///<summary>
        /// 云翼的编译编号
        ///Required:true
        ///</summary>
        [Required]
        public   string ArkId{ get; set; }
        ///<summary>
        /// 云翼编译分支
        ///Required:true
        ///</summary>
        [Required]
        public   string Branch{ get; set; }
        ///<summary>
        /// 设备归属的实例所在区域
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}