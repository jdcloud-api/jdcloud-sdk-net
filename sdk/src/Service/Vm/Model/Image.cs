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


namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  云主机镜像详细信息。
    /// </summary>
    public class Image
    {

        ///<summary>
        /// 镜像ID。
        ///</summary>
        public string ImageId{ get; set; }
        ///<summary>
        /// 镜像名称。
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 镜像的操作系统平台名称。
        /// 取值范围：&#x60;Ubuntu、CentOS、Windows Server、Other Linux、Other Windows&#x60;。
        /// 
        ///</summary>
        public string Platform{ get; set; }
        ///<summary>
        /// 镜像的操作系统版本。
        ///</summary>
        public string OsVersion{ get; set; }
        ///<summary>
        /// 镜像架构。取值范围：&#x60;x86_64、i386&#x60;。
        ///</summary>
        public string Architecture{ get; set; }
        ///<summary>
        /// 镜像系统盘大小。
        ///</summary>
        public int? SystemDiskSizeGB{ get; set; }
        ///<summary>
        /// 镜像来源，取值范围：
        /// &#x60;public&#x60;：官方镜像。
        /// &#x60;thirdparty&#x60;：镜像市场镜像。
        /// &#x60;private&#x60;：用户自己的私有镜像。
        /// &#x60;shared&#x60;：其他用户分享的镜像。
        /// &#x60;community&#x60;：社区镜像。
        /// 
        ///</summary>
        public string ImageSource{ get; set; }
        ///<summary>
        /// 镜像的操作系统类型。取值范围：&#x60;windows、linux&#x60;。
        ///</summary>
        public string OsType{ get; set; }
        ///<summary>
        /// 镜像状态。参考 [镜像状态](https://docs.jdcloud.com/virtual-machines/api/image_status)。
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 镜像的创建时间。
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 镜像文件的实际大小。
        ///</summary>
        public int? SizeMB{ get; set; }
        ///<summary>
        /// 镜像描述。
        ///</summary>
        public string Desc{ get; set; }
        ///<summary>
        /// 该镜像拥有者的用户PIN。
        ///</summary>
        public string OwnerPin{ get; set; }
        ///<summary>
        /// 镜像的使用权限。取值范围：
        /// &#x60;all&#x60;：没有限制，所有人均可以使用。
        /// &#x60;specifiedUsers&#x60;：只有共享用户可以使用。
        /// &#x60;ownerOnly&#x60;：镜像拥有者自己可以使用。
        /// 
        ///</summary>
        public string LaunchPermission{ get; set; }
        ///<summary>
        /// 镜像系统盘配置。
        ///</summary>
        public InstanceDiskAttachment SystemDisk{ get; set; }
        ///<summary>
        /// 镜像数据盘配置列表。
        ///</summary>
        public List<InstanceDiskAttachment> DataDisks{ get; set; }
        ///<summary>
        /// 创建云盘系统盘所使用的快照ID。系统盘类型为本地盘的镜像，此参数为空。
        ///</summary>
        public string SnapshotId{ get; set; }
        ///<summary>
        /// 镜像支持的系统盘类型。取值范围：
        /// &#x60;localDisk&#x60;：本地盘系统盘。
        /// &#x60;cloudDisk&#x60;：云盘系统盘。
        /// 
        ///</summary>
        public string RootDeviceType{ get; set; }
        ///<summary>
        /// 镜像复制和转换时的进度，仅显示数值，单位为百分比。
        ///</summary>
        public string Progress{ get; set; }
        ///<summary>
        /// 镜像的上下线状态。&#x60;offline&#x3D;true&#x60; 的镜像不再允许创建云主机。
        ///</summary>
        public bool Offline{ get; set; }
        ///<summary>
        /// 已废弃。
        ///</summary>
        public string ServiceCode{ get; set; }
    }
}
