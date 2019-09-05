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
 * Resource-Tag-APIs
 * 资源标签接口
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

using JDCloudSDK.Resourcetag.Model;

namespace  JDCloudSDK.Resourcetag.Apis
{

    /// <summary>
    ///  资源标签绑定。&lt;br/&gt;
        ///         /// 注意cdn资源绑定标签时url中regionId必须指定为cn-all。
        ///         /// 
    /// </summary>
    public class TagResourcesResult : JdcloudResult
    {
        ///<summary>
        /// 资源标签绑定结果详情
        ///</summary>
        public   TagResourcesResVo Data{ get; set; }
    }
}