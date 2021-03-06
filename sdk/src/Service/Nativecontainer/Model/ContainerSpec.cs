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
using JDCloudSDK.Charge.Model;

namespace JDCloudSDK.Nativecontainer.Model
{

    /// <summary>
    ///  容器规格
    /// </summary>
    public class ContainerSpec
    {

        ///<summary>
        /// 实例类型；参考[文档](https://www.jdcloud.com/help/detail/1992/isCatalog/1)
        ///Required:true
        ///</summary>
        [Required]
        public string InstanceType{ get; set; }
        ///<summary>
        /// 容器所属可用区
        ///Required:true
        ///</summary>
        [Required]
        public string Az{ get; set; }
        ///<summary>
        /// 容器名称，不可为空，只支持中文、数字、大小写字母、英文下划线“_”及中划线“-”，且不能超过32字符
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 域名和IP映射的信息；&lt;/br&gt; 最大10个alias
        ///</summary>
        public List<HostAliasSpec> HostAliases{ get; set; }
        ///<summary>
        /// 主机名，规范请参考说明文档；默认容器ID
        ///</summary>
        public string Hostname{ get; set; }
        ///<summary>
        /// 容器执行命令，如果不指定默认是docker镜像的ENTRYPOINT
        ///</summary>
        public List<string> Command{ get; set; }
        ///<summary>
        /// 容器执行命令的参数，如果不指定默认是docker镜像的CMD
        ///</summary>
        public List<string> Args{ get; set; }
        ///<summary>
        /// 容器执行的环境变量；如果和镜像中的环境变量Key相同，会覆盖镜像中的值；&lt;/br&gt; 最大100对
        ///</summary>
        public List<EnvVar> Envs{ get; set; }
        ///<summary>
        /// 镜像名称 &lt;/br&gt; 1. Docker Hub官方镜像通过类似nginx, mysql/mysql-server的名字指定 &lt;/br&gt; &lt;/br&gt; repository长度最大256个字符，tag最大128个字符，registry最大255个字符
        ///Required:true
        ///</summary>
        [Required]
        public string Image{ get; set; }
        ///<summary>
        /// 镜像仓库认证信息；使用Docker Hub和京东云CR的镜像不需要secret
        ///</summary>
        public string Secret{ get; set; }
        ///<summary>
        /// 容器是否分配tty。默认不分配
        ///</summary>
        public bool Tty{ get; set; }
        ///<summary>
        /// 容器的工作目录。如果不指定，默认是根目录（/）；必须是绝对路径
        ///</summary>
        public string WorkingDir{ get; set; }
        ///<summary>
        /// 根Volume信息
        ///Required:true
        ///</summary>
        [Required]
        public VolumeMountSpec RootVolume{ get; set; }
        ///<summary>
        /// 挂载的数据Volume信息；最多7个
        ///</summary>
        public List<VolumeMountSpec> DataVolumes{ get; set; }
        ///<summary>
        /// 主网卡主IP关联的弹性IP规格
        ///</summary>
        public ElasticIpSpec ElasticIp{ get; set; }
        ///<summary>
        /// 主网卡配置信息
        ///Required:true
        ///</summary>
        [Required]
        public ContainerNetworkInterfaceAttachmentSpec PrimaryNetworkInterface{ get; set; }
        ///<summary>
        /// 容器日志配置信息；默认会在本地分配10MB的存储空间
        ///</summary>
        public LogConfiguration LogConfiguration{ get; set; }
        ///<summary>
        /// 容器描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 计费配置；如不指定，默认计费类型是后付费-按使用时常付费
        ///</summary>
        public ChargeSpec Charge{ get; set; }
        ///<summary>
        /// 用户普通标签集合
        ///</summary>
        public List<Tag> UserTags{ get; set; }
    }
}
