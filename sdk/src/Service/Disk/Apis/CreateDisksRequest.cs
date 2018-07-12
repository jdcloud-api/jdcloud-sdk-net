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
 * 云硬盘相关接口
 * 云硬盘相关接口，提供批量创建云硬盘，查询云硬盘，删除云硬盘，对云硬盘进行扩容，修改云硬盘信息以及使用快照恢复云硬盘等功能。
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

using JDCloudSDK.Disk.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Disk.Apis
{

    /// <summary>
    ///  创建一块或多块云硬盘
    /// </summary>
    public class CreateDisksRequest : JdcloudRequest
    {
        ///<summary>
        /// 创建云硬盘规格
        ///Required:true
        ///</summary>
        [Required]
        public   DiskSpec DiskSpec{ get; set; }
        ///<summary>
        /// 购买实例数量；取值范围：[1,100]
        ///Required:true
        ///</summary>
        [Required]
        public   int MaxCount{ get; set; }
        ///<summary>
        /// 幂等性校验参数
        ///Required:true
        ///</summary>
        [Required]
        public   string ClientToken{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}