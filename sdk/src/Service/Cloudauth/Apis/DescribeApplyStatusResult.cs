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
 * 服务管理接口
 * 实名认证-服务管理接口
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


namespace  JDCloudSDK.Cloudauth.Apis
{

    /// <summary>
    ///  查询服务开通状态
    /// </summary>
    public class DescribeApplyStatusResult : JdcloudResult
    {
        ///<summary>
        /// 用户pin
        ///</summary>
        public   string Pin{ get; set; }
        ///<summary>
        /// 当前服务状态(0 未开通 1 开通中 2 正常  3 停服 )
        ///</summary>
        public   int? Status{ get; set; }
        ///<summary>
        /// 申请开通服务时间
        ///</summary>
        public   string ApplyTime{ get; set; }
    }
}