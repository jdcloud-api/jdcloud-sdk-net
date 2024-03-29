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
 * Storage-Analysis
 * 总空间使用情况、空间趋势、索引情况等接口
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


namespace  JDCloudSDK.Smartdba.Apis
{

    /// <summary>
    ///  获取空间信息
    /// </summary>
    public class DescribeStoragesResult : JdcloudResult
    {
        ///<summary>
        /// 总空间(单位：G)
        ///</summary>
        public   string TotalDiskSize{ get; set; }
        ///<summary>
        /// 已用空间(单位：G)
        ///</summary>
        public   string UsedDiskSize{ get; set; }
        ///<summary>
        /// 最近一周增长量(单位：G)
        ///</summary>
        public   string TotalIncreaseSize{ get; set; }
        ///<summary>
        /// 最近一周平均增长率
        ///</summary>
        public   string AverageIncrease{ get; set; }
        ///<summary>
        /// 剩余空间(单位：G)
        ///</summary>
        public   string FreeDiskSize{ get; set; }
        ///<summary>
        /// 预计剩余可用天数
        ///</summary>
        public   string PredictAvailableDays{ get; set; }
    }
}