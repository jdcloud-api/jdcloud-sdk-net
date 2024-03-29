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

using JDCloudSDK.Vm.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  
        ///         /// 为云主机制作私有镜像。
        ///         /// 
        ///         /// 详细操作说明请参考帮助文档：[基于实例创建私有镜像](https://docs.jdcloud.com/cn/virtual-machines/create-private-image)
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 云主机实例没有正在进行中的任务时才可制作镜像。
        ///         /// - 本地系统盘的实例，仅支持关机（已停止）状态下制作私有镜像。
        ///         /// - 云盘系统盘的实例，支持开机(运行中)/关机（已停止）状态下制作私有镜像。
        ///         /// - 调用接口后，需要等待镜像状态变为 &#x60;ready&#x60; 后，才能正常使用镜像。
        ///         /// - 若当前实例系统盘为本地盘，则创建完成后的私有镜像为本地盘系统盘镜像；若当前实例系统盘为云硬盘，则创建完成后的私有镜像为云硬盘系统盘镜像。您可通过镜像类型转换 [convertImage](https://docs.jdcloud.com/Image/api/convertimage) 将本地盘系统盘镜像转换为云硬盘系统盘镜像后使用。
        ///         /// - 默认情况下，制作的镜像中包括数据盘中的云硬盘（制作快照），但是不包含本地数据盘。
        ///         /// - 如果需要变更打包镜像中的一些数据盘、或排除一些数据盘不需要制作快照，可通过 &#x60;dataDisks&#x60; 中的参数进行控制。
        ///         /// 
    /// </summary>
    public class CreateImageRequest : JdcloudRequest
    {
        ///<summary>
        /// 镜像名称，长度为2\~32个字符，只允许中文、数字、大小写字母、英文下划线（\_）、连字符（-）及点（.）。
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string Name{ get; set; }
        ///<summary>
        /// 镜像描述。256字符以内。
        /// 
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 数据盘列表。
        /// 在不指定该参数的情况下，制作镜像的过程中会将该实例中的所有云盘数据盘制作快照，并与系统盘一起，制作成打包镜像。
        /// 如果不希望将实例中的某个云盘数据盘制作快照，可使用 &#x60;noDevice&#x60; 的方式排除，例如：&#x60;deviceName&#x3D;vdb&#x60;、&#x60;noDevice&#x3D;true&#x60; 就不会将 &#x60;vdb&#x60; 制作快照。
        /// 如果希望在打包镜像中插入一块新盘，该盘不在实例中，可通过指定新的 &#x60;deviceName&#x60; 的方式实现，例如：&#x60;deviceName&#x3D;vdx&#x60; 将会在打包镜像中插入一块盘符为 &#x60;vdx&#x60; 的新盘，支持新盘使用或不使用快照都可以。
        /// 如果使用 &#x60;deviceName&#x60; 指定了与实例中相同的盘符，那么实例中对应的云盘数据盘也不会制作快照，并使用新指定的参数进行替换。
        /// 
        ///</summary>
        public List<InstanceDiskAttachmentSpec> DataDisks{ get; set; }

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