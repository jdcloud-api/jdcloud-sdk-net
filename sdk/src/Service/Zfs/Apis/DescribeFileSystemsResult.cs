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
 * File-System
 * 文件系统相关接口。
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

using JDCloudSDK.Zfs.Model;

namespace  JDCloudSDK.Zfs.Apis
{

    /// <summary>
    ///  -   查询文件系统列表。
        ///         /// -   filters多个过滤条件之间是逻辑与(AND)，每个条件内部的多个取值是逻辑或(OR)
        ///         /// 
    /// </summary>
    public class DescribeFileSystemsResult : JdcloudResult
    {
        ///<summary>
        /// 文件系统信息列表
        ///</summary>
        public List<FileSystem> FileSystems{ get; set; }

        ///<summary>
        /// 查询的文件系统数目
        ///</summary>
        public   int? TotalCount{ get; set; }
    }
}