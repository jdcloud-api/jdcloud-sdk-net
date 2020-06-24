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
 * 用户类接口
 * 京东云内容安全-OpenAPI用户类接口
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

namespace  JDCloudSDK.Censor.Apis
{

    /// <summary>
    ///  运营后台获取用户列表
    /// </summary>
    public class DescribeUserPinsRequest : JdcloudRequest
    {
        ///<summary>
        /// 用户资源包状态，0-所有用户，1-有效，2-无效
        ///Required:true
        ///</summary>
        [Required]
        public   string Valid{ get; set; }
        ///<summary>
        /// 用户资源包状态，0-所有，1-付费包，2-试用包
        ///Required:true
        ///</summary>
        [Required]
        public   string Charge{ get; set; }
        ///<summary>
        /// 页面大小，缺省为10
        ///</summary>
        public   int? Size{ get; set; }
        ///<summary>
        /// 起始页，缺省为1
        ///</summary>
        public   int? Index{ get; set; }
        ///<summary>
        /// 实例所属的地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}