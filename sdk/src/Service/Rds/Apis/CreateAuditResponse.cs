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
 * 审计管理
 * 审计管理相关接口
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


namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  开启SQL Server的数据库审计功能，目前支持实例级的数据库审计。用户可以根据需要开启、关闭审计、自定义审计策略，并下载审计文件。审计文件为原生的SQL Server审计文件，缺省保存6个月。&lt;br&gt;- 仅支持SQL Server
    /// </summary>
    public class CreateAuditResponse : JdcloudResponse<CreateAuditResult>
    {
    }
}