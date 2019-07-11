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
 * 启动模板
 * 与启动模板相关的接口
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

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  创建一个指定参数的启动模板，启动模板中包含创建云主机时的大部分配置参数，避免每次创建云主机时的重复性工作。&lt;br&gt;
        ///         /// 如果是使用启动模板创建云主机，如果指定了某些参数与模板中的参数相冲突，那么新指定的参数会替换模板中的参数。&lt;br&gt;
        ///         /// 如果是使用启动模板创建云主机，如果指定了镜像ID与模板中的镜像ID不一致，那么模板中的dataDisks参数会失效。&lt;br&gt;
        ///         /// 如果使用高可用组(Ag)创建云主机，那么Ag所关联的模板中的参数都不可以被调整，只能以模板为准。
        ///         /// 
    /// </summary>
    public class CreateInstanceTemplateRequest : JdcloudRequest
    {
        ///<summary>
        /// 启动模板的数据
        ///Required:true
        ///</summary>
        [Required]
        public   InstanceTemplateSpec InstanceTemplateData{ get; set; }
        ///<summary>
        /// 启动模板的名称，&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/general_parameters&quot;&gt;参考公共参数规范&lt;/a&gt;。
        ///Required:true
        ///</summary>
        [Required]
        public   string Name{ get; set; }
        ///<summary>
        /// 启动模板的描述，&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/general_parameters&quot;&gt;参考公共参数规范&lt;/a&gt;。
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}