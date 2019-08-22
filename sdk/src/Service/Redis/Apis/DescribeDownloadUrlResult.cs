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
 * Redis Instance API
 * 缓存Redis实例的创建、删除、修改基本信息、设置密码、变配、列表查询、备份、配置参数接口
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

using JDCloudSDK.Redis.Model;

namespace  JDCloudSDK.Redis.Apis
{

    /// <summary>
    ///  获取缓存Redis实例的备份文件临时下载地址
    /// </summary>
    public class DescribeDownloadUrlResult : JdcloudResult
    {
        ///<summary>
        /// 备份文件下载信息列表
        ///</summary>
        public List<DownloadUrl> DownloadUrls{ get; set; }

    }
}