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
 * 用户管理接口
 * 用户管理接口
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

using JDCloudSDK.Iam.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Iam.Apis
{

    /// <summary>
    ///  创建子账号
    /// </summary>
    public class CreateSubuserRequest : JdcloudRequest
    {
        ///<summary>
        /// 子账号信息
        ///Required:true
        ///</summary>
        [Required]
        public   CreateSubUserInfo CreateSubUserInfo{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}