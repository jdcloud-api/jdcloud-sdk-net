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
 * Metric APIs
 * 日志服务日志监控任务相关的管理控制接口
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

using JDCloudSDK.Logs.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Logs.Apis
{

    /// <summary>
    ///  日志测试，根据用户输入的日志筛选条件以及监控指标设置进行模拟监控统计
    /// </summary>
    public class TestMetricTaskRequest : JdcloudRequest
    {
        ///<summary>
        /// 聚合函数,支持 count sum max min avg; 配置方式(SettingType) 为 空或visual 时，必填；
        ///</summary>
        public   string Aggregate{ get; set; }
        ///<summary>
        /// 测试内容
        ///Required:true
        ///</summary>
        [Required]
        public List<string> Content{ get; set; }

        ///<summary>
        /// 查询字段,支持 英文字母 数字 下划线 中划线 点（中文日志原文和各产品线的key）; 配置方式(SettingType) 为 空或visual 时，必填；
        ///</summary>
        public   string DataField{ get; set; }
        ///<summary>
        /// 过滤语法，可以为空
        ///</summary>
        public   string FilterContent{ get; set; }
        ///<summary>
        /// 是否打开过滤; 配置方式(SettingType) 为 空或visual 时，必填；
        ///</summary>
        public   string FilterOpen{ get; set; }
        ///<summary>
        /// 过滤类型，只能是fulltext和 advance; 配置方式(SettingType) 为 空或visual 时，必填；
        ///</summary>
        public   string FilterType{ get; set; }
        ///<summary>
        /// 监控项 , 支持大小写英文字母 下划线 数字 点，且不超过255byte（不支持中划线）; 配置方式(SettingType) 为 空或visual 时，必填；
        ///</summary>
        public   string Metric{ get; set; }
        ///<summary>
        /// 配置方式: 可选参数；枚举值 visual，sql；分别代表可视化配置及sql配置方式，传空表示可视化配置；
        ///</summary>
        public   string SettingType{ get; set; }
        ///<summary>
        /// SqlSpec
        ///</summary>
        public   MetricTaskSqlSpec SqlSpec{ get; set; }
        ///<summary>
        /// 地域 Id
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
        ///<summary>
        /// 日志集 UID
        ///Required:true
        ///</summary>
        [Required]
        public   string LogsetUID{ get; set; }
        ///<summary>
        /// 日志主题 UID
        ///Required:true
        ///</summary>
        [Required]
        public   string LogtopicUID{ get; set; }
    }
}