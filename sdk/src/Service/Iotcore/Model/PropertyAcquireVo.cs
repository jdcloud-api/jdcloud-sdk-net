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
using Newtonsoft.Json;

namespace JDCloudSDK.Iotcore.Model
{

    /// <summary>
    ///  设备属性信息
    /// </summary>
    public class PropertyAcquireVo
    {

        ///<summary>
        /// 属性状态
        ///Required:true
        ///</summary>
        [Required]
        public State State{ get; set; }
        ///<summary>
        /// 元数据
        ///Required:true
        ///</summary>
        [Required]
        public MetaData MetaData{ get; set; }
        ///<summary>
        /// 版本号
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("version")]
        public int VersionValue{ get; set; }
    }
}