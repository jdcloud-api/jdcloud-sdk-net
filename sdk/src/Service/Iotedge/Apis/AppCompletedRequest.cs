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
 * AppManager
 * AppStore统一管理
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
    ///  云翼发布结果回调接口
    /// </summary>
    public class AppCompletedRequest : JdcloudRequest
    {
        ///<summary>
        /// APP版本
        ///Required:true
        ///</summary>
        [Required]
        public   string AppVersion{ get; set; }
        ///<summary>
        /// APP的Docker上传地址
        ///Required:true
        ///</summary>
        [Required]
        public   string AppDockerPath{ get; set; }
        ///<summary>
        /// 0 - success or 1 - failture
        ///Required:true
        ///</summary>
        [Required]
        public   int Status{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// APP业务标识
        ///Required:true
        ///</summary>
        [Required]
        public   string AppId{ get; set; }
    }
}