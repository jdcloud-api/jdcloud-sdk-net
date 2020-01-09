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


namespace JDCloudSDK.Kubernetes.Model
{

    /// <summary>
    ///  NodeGroup 的系统盘配置
        /// - 云盘的相关参数仅限category为cloud时生效
        /// - 磁盘分类，系统盘支持local或cloud
        /// - 磁盘大小
        ///   - local：不能指定大小
        ///   - cloud：取值范围: 40-500GB，步长 10，默认为100GB
        /// - ssd.io1 云盘iops
        ///   - 步长 10
        ///   - 范围 [200，min(32000，size×50)]
        ///   - 默认值 size×30
        /// 
    /// </summary>
    public class DiskSpec
    {

        ///<summary>
        /// 磁盘类型，取值为cloud、local，默认为cloud
        ///</summary>
        public string SystemDiskCategory{ get; set; }
        ///<summary>
        /// 云盘系统盘的大小 单位(GB)
        ///</summary>
        public int? SystemDiskSize{ get; set; }
        ///<summary>
        /// 云盘系统盘的类型，支持 hdd.std1,ssd.gp1,ssd.io1
        ///</summary>
        public string SystemDiskType{ get; set; }
        ///<summary>
        /// 云盘 iops，仅限 ssd.io1 类型云盘有效
        ///</summary>
        public int? SystemDiskIops{ get; set; }
    }
}