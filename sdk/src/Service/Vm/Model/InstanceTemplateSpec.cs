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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  instanceTemplateSpec
    /// </summary>
    public class InstanceTemplateSpec
    {

        ///<summary>
        /// 实例规格，可查询&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/2901/isCatalog/1&quot;&gt;DescribeInstanceTypes&lt;/a&gt;接口获得指定地域或可用区的规格信息。
        ///Required:true
        ///</summary>
        [Required]
        public string InstanceType{ get; set; }
        ///<summary>
        /// 镜像ID，可查询&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/2874/isCatalog/1&quot;&gt;DescribeImages&lt;/a&gt;接口获得指定地域的镜像信息。
        ///Required:true
        ///</summary>
        [Required]
        public string ImageId{ get; set; }
        ///<summary>
        /// 密码，&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/3870/isCatalog/1&quot;&gt;参考公共参数规范&lt;/a&gt;。
        ///</summary>
        public string Password{ get; set; }
        ///<summary>
        /// 密钥对名称；当前只支持一个
        ///</summary>
        public List<string> KeyNames{ get; set; }
        ///<summary>
        /// 主网卡主IP关联的弹性IP规格
        ///</summary>
        public InstanceTemplateElasticIpSpec ElasticIp{ get; set; }
        ///<summary>
        /// 主网卡配置信息
        ///Required:true
        ///</summary>
        [Required]
        public InstanceTemplateNetworkInterfaceAttachmentSpec PrimaryNetworkInterface{ get; set; }
        ///<summary>
        /// 系统盘配置信息
        ///Required:true
        ///</summary>
        [Required]
        public InstanceTemplateDiskAttachmentSpec SystemDisk{ get; set; }
        ///<summary>
        /// 数据盘配置信息
        ///</summary>
        public List<InstanceTemplateDiskAttachmentSpec> DataDisks{ get; set; }
    }
}
