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
    ///  删除一个私有镜像，只允许操作您的个人私有镜像。&lt;br&gt;
        ///         /// 若镜像已共享给其他用户，需先取消共享才可删除。
        ///         /// 
    /// </summary>
    public class DeleteImageRequest : JdcloudRequest
    {
        ///<summary>
        /// 删除镜像是否删除关联的快照，默认为false；如果指定为true, 将会删除镜像关联的快照。
        ///</summary>
        public   bool DeleteSnapshot{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 镜像ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ImageId{ get; set; }
    }
}