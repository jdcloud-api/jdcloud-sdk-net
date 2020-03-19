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
 * ES Auth API
 * 查询、设置数据面身份验证信息接口
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
using Newtonsoft.Json;

namespace  JDCloudSDK.Es.Apis
{

    /// <summary>
    ///  连接es前认证校验。
    /// </summary>
    public class CheckAuthRequest : JdcloudRequest
    {
        ///<summary>
        /// ES版本
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceVersion{ get; set; }
        ///<summary>
        /// 实例名称
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceName{ get; set; }
        ///<summary>
        /// 集群地址(TCP)。支持一个或多个
        ///</summary>
        public List<string> InstanceTcpUrl{ get; set; }

        ///<summary>
        /// 索引(index)
        ///Required:true
        ///</summary>
        [Required]
        public   string Index{ get; set; }
        ///<summary>
        /// 索引类型(type)
        ///Required:true
        ///</summary>
        [Required]
        public   string Type{ get; set; }
        ///<summary>
        /// 访问es时的用户名
        ///Required:true
        ///</summary>
        [Required]
        public   string Username{ get; set; }
        ///<summary>
        /// 访问es时的密码
        ///Required:true
        ///</summary>
        [Required]
        public   string Password{ get; set; }
        ///<summary>
        /// regionId
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 实例ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}