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
 * 云监控规则相关接口
 * 云监控规则相关接口，提供创建、查询、修改、删除监控规则等功能
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

using JDCloudSDK.Monitor.Model;

namespace  JDCloudSDK.Monitor.Apis
{

    /// <summary>
    ///  查询报警历史
    /// </summary>
    public class DescribeAlarmHistoryResult : JdcloudResult
    {
        ///<summary>
        /// AlarmHistoryList
        ///</summary>
        public List<AlarmHistory> AlarmHistoryList{ get; set; }

        ///<summary>
        /// 页码
        ///</summary>
        public   double? PageNumber{ get; set; }
        ///<summary>
        /// 总页数
        ///</summary>
        public   double? NumberPages{ get; set; }
        ///<summary>
        /// 总记录数
        ///</summary>
        public   double? NumberRecords{ get; set; }
        ///<summary>
        /// 分页大小
        ///</summary>
        public   double? PageSize{ get; set; }
    }
}