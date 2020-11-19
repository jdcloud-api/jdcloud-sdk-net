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
using JDCloudSDK.Vpc.Model;
using JDCloudSDK.Charge.Model;
using JDCloudSDK.Disk.Model;

namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  instanceSpec
    /// </summary>
    public class InstanceSpec
    {

        ///<summary>
        /// 高可用组Id。指定了此参数后，只能通过高可用组关联的实例模板创建虚机，并且实例模板中的参数不可覆盖替换。实例模板以外的参数还可以指定。
        ///</summary>
        public string AgId{ get; set; }
        ///<summary>
        /// 实例模板id，如果没有使用高可用组，那么对于实例模板中没有的信息，需要使用创建虚机的参数进行补充，或者选择覆盖启动模板中的参数。
        ///</summary>
        public string InstanceTemplateId{ get; set; }
        ///<summary>
        /// 云主机所属的可用区。
        ///</summary>
        public string Az{ get; set; }
        ///<summary>
        /// 实例规格。可查询&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/describeinstancetypes&quot;&gt;DescribeInstanceTypes&lt;/a&gt;接口获得指定地域或可用区的规格信息。
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// 镜像ID。可查询&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/describeimages&quot;&gt;DescribeImages&lt;/a&gt;接口获得指定地域的镜像信息。
        ///</summary>
        public string ImageId{ get; set; }
        ///<summary>
        /// 云主机名称，不为空且只允许中文、数字、大小写字母、英文下划线（_）、连字符（-）及点（.），不能以（.）作为首尾，长度为2~128个字符。
        /// 批量创建多台云主机时，可在name中非首位位置以[start_number]格式来设置有序name。start_number为起始序号，取值范围[0,9999]。例如：name设置为“instance-[000]-ops”，则第一台主机name为“instance-000-ops”，第二台主机name为“instance-001-ops”。再如：name设置为“instance-[0]-ops”，则第一台主机name为“instance-0-ops”，第二台主机name为“instance-1-ops”。
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 云主机hostname，若不指定hostname，则hostname默认使用云主机名称name，但是会以RFC 952和RFC 1123命名规范做一定转义。
        /// Windows Server系统：长度为2-15个字符，允许大小写字母、数字或连字符（-）。不能以连字符（-）开头或结尾，不能连续使用连字符（-），也不能全部使用数字。不支持点号（.）。
        /// Linux系统：长度为2-64个字符，允许支持多个点号，点之间为一段，每段允许使用大小写字母、数字或连字符（-），但不能连续使用点号（.）或连字符（-），不能以点号（.）或连字符（-）开头或结尾。
        /// 批量创建多台云主机时，可在hostname中非首位位置以[start_number]格式来设置有序hostname。start_number为起始序号，取值范围[0,9999]。例如：hostname设置为“instance-[000]-ops”，则第一台主机hostname为“instance-000-ops”，第二台主机hostname为“instance-001-ops”。再如：hostname设置为“instance-[0]-ops”，则第一台主机hostname为“instance-0-ops”，第二台主机hostname为“instance-1-ops”。批量创建时若不指定起始序号，则会默认追加从1开始的数字，例如批量创建两台虚拟机，且指定hostname是test，则hostname默认是test1，test2。
        /// 
        ///</summary>
        public string Hostname{ get; set; }
        ///<summary>
        /// 密码，&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/general_parameters&quot;&gt;参考公共参数规范&lt;/a&gt;。
        ///</summary>
        public string Password{ get; set; }
        ///<summary>
        /// 密钥对名称，当前只支持传入一个。
        ///</summary>
        public List<string> KeyNames{ get; set; }
        ///<summary>
        /// 主网卡主IP关联的弹性IP规格
        ///</summary>
        public ElasticIpSpec ElasticIp{ get; set; }
        ///<summary>
        /// 主网卡配置信息
        ///</summary>
        public InstanceNetworkInterfaceAttachmentSpec PrimaryNetworkInterface{ get; set; }
        ///<summary>
        /// 系统盘配置信息
        ///</summary>
        public InstanceDiskAttachmentSpec SystemDisk{ get; set; }
        ///<summary>
        /// 数据盘配置信息，本地盘(local类型)做系统盘的云主机可挂载8块数据盘，云硬盘(cloud类型)做系统盘的云主机可挂载7块数据盘。
        ///</summary>
        public List<InstanceDiskAttachmentSpec> DataDisks{ get; set; }
        ///<summary>
        /// 计费配置
        /// 云主机不支持按用量方式计费，默认为按配置计费。
        /// 打包创建数据盘的情况下，数据盘的计费方式只能与云主机保持一致。
        /// 打包创建弹性公网IP的情况下，若公网IP的计费方式没有指定为按用量计费，那么公网IP计费方式只能与云主机保持一致。
        /// 
        ///</summary>
        public ChargeSpec Charge{ get; set; }
        ///<summary>
        /// 用户自定义元数据信息，key-value键值对总数量不超过40对，其中有效键值对数量不超过20，无效键值对数量不超过20对。不区分大小写。
        /// 注意：key不要以连字符(-)结尾，否则此key不生效。
        /// 
        ///</summary>
        public List<Metadata> Metadata{ get; set; }
        ///<summary>
        /// 元数据信息，目前只支持传入一个key为&quot;launch-script&quot;，表示首次启动脚本。value为base64格式，编码前数据不能大于16KB。
        /// launch-script：linux系统支持bash和python，编码前须分别以 #!/bin/bash 和 #!/usr/bin/env python 作为内容首行;
        /// launch-script：windows系统支持bat和powershell，编码前须分别以 &lt;cmd&gt;&lt;/cmd&gt; 和 &lt;powershell&gt;&lt;/powershell&gt; 作为内容首、尾行。
        /// 
        ///</summary>
        public List<Userdata> Userdata{ get; set; }
        ///<summary>
        /// 主机描述，&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/general_parameters&quot;&gt;参考公共参数规范&lt;/a&gt;。
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 不使用模板中的密码。
        /// 仅当不使用Ag，并且使用了模板，并且password参数为空时，此参数(值为true)生效。
        /// 若使用模板创建虚机时，又指定了password参数时，此参数无效，以新指定的为准。
        /// 
        ///</summary>
        public bool NoPassword{ get; set; }
        ///<summary>
        /// 不使用模板中的密钥。
        /// 仅当不使用Ag，并且使用了模板，并且keynames参数为空时，此参数(值为true)生效。
        /// 若使用模板创建虚机时，又指定了keynames参数时，此参数无效，以新指定的为准。
        /// 
        ///</summary>
        public bool NoKeyNames{ get; set; }
        ///<summary>
        /// 不使用模板中的弹性公网IP。
        /// 仅当不使用Ag，并且使用了模板，并且elasticIp参数为空时，此参数(值为true)生效。
        /// 若使用模板创建虚机时，又指定了elasticIp参数时，此参数无效，以新指定的为准。
        /// 
        ///</summary>
        public bool NoElasticIp{ get; set; }
        ///<summary>
        /// 用户普通标签集合
        ///</summary>
        public List<Tag> UserTags{ get; set; }
        ///<summary>
        /// 关机模式，只支持云盘做系统盘的按配置计费云主机。keepCharging：关机后继续计费；stopCharging：关机后停止计费。
        ///</summary>
        public string ChargeOnStopped{ get; set; }
        ///<summary>
        /// 自动镜像策略ID。
        ///</summary>
        public string AutoImagePolicyId{ get; set; }
        ///<summary>
        /// 当存在密钥时，是否同时使用密码登录，&quot;yes&quot;为使用，&quot;no&quot;为不使用，&quot;&quot;默认为&quot;yes&quot;
        ///</summary>
        public string PasswordAuth{ get; set; }
        ///<summary>
        /// 继承镜像中的登录验证方式，&quot;yes&quot;为使用，&quot;no&quot;为不使用，&quot;&quot;默认为&quot;no&quot;
        ///</summary>
        public string ImageInherit{ get; set; }
    }
}
