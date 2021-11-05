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
 * SSH密钥对
 * 关于SSH密钥对的相关接口
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
        ///         /// 删除密钥。
        ///         /// 
        ///         /// 详细操作说明请参考帮助文档：[删除密钥](https://docs.jdcloud.com/cn/virtual-machines/delete-keypair)
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 密钥删除后，使用该密钥的实例仍可正常使用与之匹配的本地私钥登录，且密钥仍会显示在实例详情中。
        ///         /// - 密钥删除后，与之关联的实例模板将变为不可用，并且与该实例模板关联的高可用组也会变为不可用。
        ///         /// 
    /// </summary>
    public class DeleteKeypairRequest : JdcloudRequest
    {
        ///<summary>
        /// 地域ID。
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 密钥名称。
        ///Required:true
        ///</summary>
        [Required]
        public   string KeyName{ get; set; }
    }
}