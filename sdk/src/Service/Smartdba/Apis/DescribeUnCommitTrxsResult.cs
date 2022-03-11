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
 * Sessions
 * 会话统计、实时会话、事务锁、非事务锁、未提交事务等接口
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Smartdba.Model;

namespace  JDCloudSDK.Smartdba.Apis
{

    /// <summary>
    ///  获取未提交事务信息
    /// </summary>
    public class DescribeUnCommitTrxsResult : JdcloudResult
    {
        ///<summary>
        /// 总数
        ///</summary>
        public   int? TotalCount{ get; set; }
        ///<summary>
        /// 未提交事务列表
        ///</summary>
        public List<UnCommitTrx> Data{ get; set; }

    }
}