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
 * 报表类接口
 * 京东云内容安全-OpenAPI报表类接口
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

using JDCloudSDK.Censor.Model;

namespace  JDCloudSDK.Censor.Apis
{

    /// <summary>
    ///  获取数据趋势图
    /// </summary>
    public class DescribeDataTrendResult : JdcloudResult
    {
        ///<summary>
        /// 时间戳，毫秒
        ///</summary>
        public List<int?> TimeScope{ get; set; }

        ///<summary>
        /// Total
        ///</summary>
        public List<double?> Total{ get; set; }

        ///<summary>
        /// 正常内容
        ///</summary>
        public List<double?> Pass{ get; set; }

        ///<summary>
        /// 违规内容量
        ///</summary>
        public List<double?> Block{ get; set; }

        ///<summary>
        /// 疑似
        ///</summary>
        public List<double?> Review{ get; set; }

        ///<summary>
        /// 音频识别详情
        ///</summary>
        public   AudioDetailList AudioDetail{ get; set; }
        ///<summary>
        /// 视频识别详情
        ///</summary>
        public   VideoDetailList VideoDetail{ get; set; }
    }
}