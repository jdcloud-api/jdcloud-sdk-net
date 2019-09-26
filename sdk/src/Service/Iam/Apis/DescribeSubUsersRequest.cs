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
 * SubUser Management
 * SubUser Management API
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


namespace  JDCloudSDK.Iam.Apis
{

    /// <summary>
    ///  查询子用户列表
    /// </summary>
    public class DescribeSubUsersRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码，默认1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小，默认50，取值范围[10, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 关键字
        ///</summary>
        public   string Keyword{ get; set; }
        ///<summary>
        /// 排序规则：0-创建时间顺序排序，1-创建时间倒序排序
        ///</summary>
        public   int? Sort{ get; set; }
    }
}