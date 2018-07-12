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
 * 弹性公网ip
 * 弹性公网ip相关接口
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
using JDCloudSDK.Vpc.Model;

namespace  JDCloudSDK.Vpc.Apis
{

    /// <summary>
    ///  创建一个或者多个弹性Ip
    /// </summary>
    public class CreateElasticIpsRequest : JdcloudRequest
    {
        ///<summary>
        /// 购买弹性ip数量；取值范围：[1,100]
        ///Required:true
        ///</summary>
        [Required]
        public   int MaxCount{ get; set; }
        ///<summary>
        /// 指定弹性ip地址进行创建，当申请创建多个弹性ip时，必须为空
        ///</summary>
        public   string ElasticIpAddress{ get; set; }
        ///<summary>
        /// 弹性ip规格
        ///Required:true
        ///</summary>
        [Required]
        public   ElasticIpSpec ElasticIpSpec{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}