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

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  共享镜像，只允许操作您的个人私有镜像，单个镜像最多可共享给20个京东云帐户。&lt;br&gt;
        ///         /// 整机镜像目前不支持共享。
        ///         /// 
    /// </summary>
    public class ShareImageRequest : JdcloudRequest
    {
        ///<summary>
        /// 需要共享的帐户
        ///</summary>
        public List<string> Pins{ get; set; }

        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 镜像ID
        ///Required:true
        ///</summary>
        [Required]
        public   string ImageId{ get; set; }
    }
}