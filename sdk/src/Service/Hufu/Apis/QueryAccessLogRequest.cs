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
 * hufu-log
 * 日志相关接口
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

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Hufu.Apis
{

    /// <summary>
    ///  查询access日志
    /// </summary>
    public class QueryAccessLogRequest : JdcloudRequest
    {
        ///<summary>
        /// 调用者pin
        ///</summary>
        public   string Call_pin{ get; set; }
        ///<summary>
        /// 响应码
        ///</summary>
        public   string Response_status{ get; set; }
        ///<summary>
        /// api名称
        ///</summary>
        public   string Api_name{ get; set; }
        ///<summary>
        /// 调用者accessKey
        ///</summary>
        public   string Access_key{ get; set; }
        ///<summary>
        /// 请求虎符网关的域名
        ///</summary>
        public   string Host{ get; set; }
        ///<summary>
        /// 开始时间，utc格式，例如：2020-05-19T00:00:05+0800
        ///Required:true
        ///</summary>
        [Required]
        public   string StartTime{ get; set; }
        ///<summary>
        /// 结束时间，utc格式，例如：2020-05-19T00:00:05+0800
        ///Required:true
        ///</summary>
        [Required]
        public   string EndTime{ get; set; }
        ///<summary>
        /// 页码
        ///</summary>
        public   long? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小
        ///</summary>
        public   long? PageSize{ get; set; }
    }
}