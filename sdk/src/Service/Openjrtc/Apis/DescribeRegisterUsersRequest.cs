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
 * RegisterUser
 * 用户管理
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

using JDCloudSDK.Openjrtc.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Openjrtc.Apis
{

    /// <summary>
    ///  查询注册用户列表
        ///         /// 允许通过条件过滤查询，支持的过滤字段如下：
        ///         ///            - startTime[eq] 用户注册时间段开始时间-UTC时间 startTime,endTime同时有值时生效
        ///         ///            - endTime[eq] 用户注册时间段结束时间-UTC时间 startTime,endTime同时有值时生效
        ///         /// 
    /// </summary>
    public class DescribeRegisterUsersRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码；默认值为 1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小；默认值为 10；取值范围 [10, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 传参字段描述:
        ///   startTime[eq]:   用户注册时间段开始时间-UTC时间 startTime,endTime同时有值时生效
        ///   endTime[eq]:     用户注册时间段结束时间-UTC时间 startTime,endTime同时有值时生效
        /// 
        ///</summary>
        public List<Filter> Filters{ get; set; }

        ///<summary>
        /// 应用ID
        ///Required:true
        ///</summary>
        [Required]
        public   string AppId{ get; set; }
    }
}