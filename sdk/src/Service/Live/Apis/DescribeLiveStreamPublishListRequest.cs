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

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Live.Apis
{

    /// <summary>
    ///  查看推流历史记录
    /// </summary>
    public class DescribeLiveStreamPublishListRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码&lt;br&gt;
        /// - 取值范围[1, 100000]
        /// 
        ///</summary>
        public   int? PageNum{ get; set; }
        ///<summary>
        /// 分页大小&lt;br&gt;
        /// - 取值范围[10, 100]
        /// 
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 应用名称
        ///</summary>
        public   string AppName{ get; set; }
        ///<summary>
        /// 流名称
        ///</summary>
        public   string StreamName{ get; set; }
        ///<summary>
        /// 推流起始时间&lt;br&gt;
        /// - UTC时间
        ///   格式:yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        ///   示例:2018-10-21T10:00:00Z
        /// - 最大支持最近30天内的流历史查询
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string StartTime{ get; set; }
        ///<summary>
        /// 推流结束时间&lt;br&gt;
        /// - UTC时间
        ///   格式:yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        ///   示例:2018-10-21T10:00:00Z
        /// - 最大支持最近30天内的流历史查询
        /// - 结束时间为空默认为当前时间
        /// 
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 推流域名
        ///Required:true
        ///</summary>
        [Required]
        public   string PublishDomain{ get; set; }
    }
}