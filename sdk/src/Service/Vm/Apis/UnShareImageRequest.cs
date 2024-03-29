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
 * 镜像
 * 关于主机镜像操作的相关接口
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
        ///         /// 取消共享私有镜像。
        ///         /// 
        ///         /// 详细操作说明请参考帮助文档：[取消共享私有镜像](https://docs.jdcloud.com/cn/virtual-machines/cancel-share-image)
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 只允许操作用户的私有镜像。
        ///         /// - 原被共享用户将无法再使用该镜像创建云主机实例，同时使用该镜像创建的云主机实例也无法重置为原始系统状态。
        ///         /// 
    /// </summary>
    public class UnShareImageRequest : JdcloudRequest
    {
        ///<summary>
        /// 需要取消的京东云帐户列表。
        ///</summary>
        public List<string> Pins{ get; set; }

        ///<summary>
        /// 地域ID。
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 镜像ID。
        ///Required:true
        ///</summary>
        [Required]
        public   string ImageId{ get; set; }
    }
}