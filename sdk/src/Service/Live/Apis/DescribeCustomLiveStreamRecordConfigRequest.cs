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
 * Live-Video
 * 直播管理API
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

using JDCloudSDK.Common.Model;

namespace  JDCloudSDK.Live.Apis
{

    /// <summary>
    ///  查询直播直播录制配置
        ///         /// - 录制模板配置按照 域名,应用,流 3级配置添加,以最小的粒度配置生效
        ///         /// - 域名、应用、流 依次粒度递减 即: 域名&gt;应用&gt;流
        ///         /// - 该查询旨在查询域名、应用、流最终生效的录制模板配置,并非各级的模板绑定情况
        ///         /// 
    /// </summary>
    public class DescribeCustomLiveStreamRecordConfigRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码
        /// - 取值范围 [1, 100000]
        /// 
        ///</summary>
        public   int? PageNum{ get; set; }
        ///<summary>
        /// 分页大小
        /// - 取值范围 [10, 100]
        /// 
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 录制配置查询过滤条件:
        ///   - name:   publishDomain，必填(推流域名)
        ///   - value:  参数
        ///   - name:   appName，必填(应用名称)
        ///   - value:  参数
        ///   - name:   streamName，非必填(流名称)
        ///   - value:  参数
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

    }
}