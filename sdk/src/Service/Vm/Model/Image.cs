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
    ///  image
    /// </summary>
    public class Image
    {

        ///<summary>
        /// 镜像ID
        ///</summary>
        public string ImageId{ get; set; }
        ///<summary>
        /// 镜像名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 镜像的操作系统发行版。取值：Ubuntu,CentOS,Windows Server
        ///</summary>
        public string Platform{ get; set; }
        ///<summary>
        /// 镜像的操作系统版本。
        ///</summary>
        public string OsVersion{ get; set; }
        ///<summary>
        /// 镜像架构。取值：i386,x86_64
        ///</summary>
        public string Architecture{ get; set; }
        ///<summary>
        /// 镜像系统盘大小
        ///</summary>
        public int? SystemDiskSizeGB{ get; set; }
        ///<summary>
        /// 镜像来源。取值：jcloud：官方镜像；marketplace：镜像市场镜像；self：用户自己的镜像；shared：其他用户分享的镜像
        ///</summary>
        public string ImageSource{ get; set; }
        ///<summary>
        /// 镜像的操作系统类型。取值：windows,linux
        ///</summary>
        public string OsType{ get; set; }
        ///<summary>
        /// &lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/image_status&quot;&gt;参考镜像状态&lt;/a&gt;
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 镜像文件实际大小
        ///</summary>
        public int? SizeMB{ get; set; }
        ///<summary>
        /// 镜像描述
        ///</summary>
        public string Desc{ get; set; }
        ///<summary>
        /// 该镜像所有者的用户PIN
        ///</summary>
        public string OwnerPin{ get; set; }
        ///<summary>
        /// 镜像的使用权限，取值：all（所有人可用）， specifiedUsers（共享用户可用），ownerOnly（镜像所有者自己可用）
        ///</summary>
        public string LaunchPermission{ get; set; }
        ///<summary>
        /// 镜像系统盘配置
        ///</summary>
        public InstanceDiskAttachment SystemDisk{ get; set; }
        ///<summary>
        /// 镜像数据盘映射信息
        ///</summary>
        public List<InstanceDiskAttachment> DataDisks{ get; set; }
        ///<summary>
        /// 创建云盘系统盘所使用的云硬盘快照ID。系统盘类型为本地盘的镜像，此参数为空。
        ///</summary>
        public string SnapshotId{ get; set; }
        ///<summary>
        /// 镜像支持的系统盘类型。取值：localDisk：本地盘系统盘；cloudDisk：云盘系统盘。
        ///</summary>
        public string RootDeviceType{ get; set; }
        ///<summary>
        /// 镜像复制和转换时的进度，仅显示数值，单位为百分比
        ///</summary>
        public string Progress{ get; set; }
        ///<summary>
        /// 该镜像的上下线状态
        ///</summary>
        public bool Offline{ get; set; }
        ///<summary>
        /// 该镜像所属的产品线标识
        ///</summary>
        public string ServiceCode{ get; set; }
    }
}
