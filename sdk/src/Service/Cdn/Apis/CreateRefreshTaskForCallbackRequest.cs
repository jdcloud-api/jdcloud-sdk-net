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
 * CDN刷新预热类接口
 * Openapi For JCLOUD cdn
 *
 * OpenAPI spec version: v1
 * Contact: pid-cdn@jd.com
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Cdn.Model;

namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  创建刷新预热回调任务
    /// </summary>
    public class CreateRefreshTaskForCallbackRequest : JdcloudRequest
    {
        ///<summary>
        /// 刷新预热类型,(url:url刷新,dir:目录刷新,prefetch:预热)
        ///</summary>
        public   string TaskType{ get; set; }
        ///<summary>
        /// UrlItems
        ///</summary>
        public List<UrlItem> UrlItems{ get; set; }

    }
}