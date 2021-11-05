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
 * Instance-Template
 * 与实例模板相关的接口
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
        ///         /// 创建实例模板。
        ///         /// 
        ///         /// 实例模板是创建云主机实例的配置信息模板，包括镜像、实例规格、系统盘及数据盘类型和容量、私有网络及子网配置、安全组及登录信息等。实例模板可用于创建实例及用于配置高可用组，创建高可用组时必须指定实例模板。您每次创建实例时无需重新指定实例模板已包括的参数，缩短您的部署时间。
        ///         /// 
        ///         /// 请注意：实例模板一经创建后其属性将不能编辑。
        ///         /// 
        ///         /// 详细操作说明请参考帮助文档：[创建实例模板](https://docs.jdcloud.com/cn/virtual-machines/create-instance-template)
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 创建实例模板的限制基本与创建云主机一致，可参考 [创建云主机](https://docs.jdcloud.com/cn/virtual-machines/create-instance-template)。
        ///         /// - 实例模板中包含创建云主机的大部分配置参数，可以避免每次创建云主机时的重复性配置参数的工作。
        ///         /// - 使用实例模板创建云主机时，如果再次指定了某些参数，并且与实例模板中的参数相冲突，那么新指定的参数会替换模板中的参数，以新指定的参数为准。
        ///         /// - 使用实例模板创建云主机时，如果再次指定了镜像ID，并且与模板中的镜像ID不一致，那么模板中的 &#x60;systemDisk&#x60; 和 &#x60;dataDisks&#x60; 配置会失效，以新指定的镜像为准。
        ///         /// - 如果使用高可用组(Ag)创建云主机，那么Ag所关联的模板中的参数都不可以被调整，只能以模板为准。
        ///         /// 
    /// </summary>
    public class CreateInstanceTemplateRequest : JdcloudRequest
    {
        ///<summary>
        /// 实例模板配置信息。
        ///Required:true
        ///</summary>
        [Required]
        public   InstanceTemplateSpec InstanceTemplateData{ get; set; }
        ///<summary>
        /// 实例模板的名称，参考 [公共参数规范](https://docs.jdcloud.com/virtual-machines/api/general_parameters)。
        ///Required:true
        ///</summary>
        [Required]
        public   string Name{ get; set; }
        ///<summary>
        /// 实例模板的描述，参考 [公共参数规范](https://docs.jdcloud.com/virtual-machines/api/general_parameters)。
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 地域ID。
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}