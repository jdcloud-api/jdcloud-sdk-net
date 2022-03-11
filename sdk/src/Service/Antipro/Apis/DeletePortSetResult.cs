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
 * Instance APIs
 * Anti DDoS Protection Package Instance APIs
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

namespace  JDCloudSDK.Antipro.Apis
{

    /// <summary>
    ///  删除实例的端口库. 支持批量操作, 批量操作时 ipSetId 传多个, 以 &#39;,&#39; 分隔. IP 黑白名单规则被引用时不允许删除
    /// </summary>
    public class DeletePortSetResult : JdcloudResult
    {
        ///<summary>
        /// Data
        ///</summary>
        public   JDCloudSDK.Common.Model.BatchResultDetail Data{ get; set; }
    }
}