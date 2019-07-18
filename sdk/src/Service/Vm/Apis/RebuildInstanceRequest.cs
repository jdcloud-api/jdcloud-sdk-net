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

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  云主机使用指定镜像重置云主机系统&lt;br&gt;
        ///         /// 云主机的状态必须为&lt;b&gt;stopped&lt;/b&gt;状态。&lt;br&gt;
        ///         /// 若当前云主机的系统盘类型为local类型，那么更换的镜像必须为localDisk类型的镜像；同理若当前云主机的系统盘为cloud类型，那么更换的镜像必须为cloudDisk类型的镜像。可查询&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/describeimages&quot;&gt;DescribeImages&lt;/a&gt;接口获得指定地域的镜像信息。&lt;br&gt;
        ///         /// 若不指定镜像ID，默认使用当前主机的原镜像重置系统。&lt;br&gt;
        ///         /// 指定的镜像必须能够支持当前主机的实例规格(instanceType)，否则会返回错误。可查询&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/describeimageconstraints&quot;&gt;DescribeImageConstraints&lt;/a&gt;接口获得指定镜像支持的系统盘类型信息。
        ///         /// 
    /// </summary>
    public class RebuildInstanceRequest : JdcloudRequest
    {
        ///<summary>
        /// 云主机密码，&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/general_parameters&quot;&gt;参考公共参数规范&lt;/a&gt;。
        ///Required:true
        ///</summary>
        [Required]
        public   string Password{ get; set; }
        ///<summary>
        /// 镜像ID。可查询&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/describeimages&quot;&gt;DescribeImages&lt;/a&gt;接口获得指定地域的镜像信息。
        ///</summary>
        public   string ImageId{ get; set; }
        ///<summary>
        /// 密钥对名称；当前只支持一个。仅Linux系统支持指定。
        ///</summary>
        public List<string> KeyNames{ get; set; }

        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 云主机ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}