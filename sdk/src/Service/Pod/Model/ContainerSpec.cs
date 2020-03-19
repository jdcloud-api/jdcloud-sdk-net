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

namespace JDCloudSDK.Pod.Model
{

    /// <summary>
    ///  容器规格
    /// </summary>
    public class ContainerSpec
    {

        ///<summary>
        /// 容器名称，符合DNS-1123 label规范，在一个Pod内不可重复、不支持修改
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 容器执行命令，如果不指定默认是docker镜像的ENTRYPOINT。总长度256个字符。
        ///</summary>
        public List<string> Command{ get; set; }
        ///<summary>
        /// 容器执行命令的参数，如果不指定默认是docker镜像的CMD。总长度2048个字符。
        ///</summary>
        public List<string> Args{ get; set; }
        ///<summary>
        /// 容器执行的环境变量；如果和镜像中的环境变量Key相同，会覆盖镜像中的值。数组范围：[0-100]
        ///</summary>
        public List<EnvSpec> Env{ get; set; }
        ///<summary>
        /// 镜像名称 &lt;/br&gt;
        /// 容器镜像名字。 nginx:latest。长度范围：[1-639]
        /// 1. Docker Hub官方镜像通过类似nginx, mysql/mysql-server的名字指定 &lt;/br&gt; 
        /// 2. repository长度最大256个字符，tag最大128个字符，registry最大255个字符 &lt;/br&gt; 
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public string Image{ get; set; }
        ///<summary>
        /// 镜像仓库认证信息。如果目前不传，默认选择dockerHub镜像
        ///</summary>
        public string Secret{ get; set; }
        ///<summary>
        /// 容器是否分配tty。默认不分配
        ///</summary>
        public bool Tty{ get; set; }
        ///<summary>
        /// 容器的工作目录。如果不指定，默认是根目录（/）；必须是绝对路径；长度范围：[0-1024]
        ///</summary>
        public string WorkingDir{ get; set; }
        ///<summary>
        /// 容器存活探针配置
        ///</summary>
        public ProbeSpec LivenessProbe{ get; set; }
        ///<summary>
        /// 容器服务就绪探针配置
        ///</summary>
        public ProbeSpec ReadinessProbe{ get; set; }
        ///<summary>
        /// 容器计算资源配置
        ///</summary>
        public ResourceRequestsSpec Resources{ get; set; }
        ///<summary>
        /// 容器计算资源配置
        ///Required:true
        ///</summary>
        [Required]
        public CloudDiskSpec SystemDisk{ get; set; }
        ///<summary>
        /// 云盘挂载信息
        ///</summary>
        public List<VolumeMountSpec> VolumeMounts{ get; set; }
    }
}
