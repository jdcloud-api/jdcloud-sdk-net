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
 * 云鼎短信服务-应用相关接口
 * 云鼎短信服务-应用相关接口
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

namespace  JDCloudSDK.Ydsms.Apis
{

    /// <summary>
    ///  查询应用发送短信总体情况
    /// </summary>
    public class ListSmsSendOverviewUsingGETRequest : JdcloudRequest
    {
        ///<summary>
        /// 套餐包类型，1普通短信 2官方短信，默认为1
        ///</summary>
        public   int? PackageType{ get; set; }
        ///<summary>
        /// 模板id
        ///</summary>
        public   string TemplateId{ get; set; }
        ///<summary>
        /// 结束时间,pattern &#x3D;&quot;yyyy-MM-dd HH:mm:ss&quot;,timezone&#x3D;&quot;GMT+8&quot;
        ///Required:true
        ///</summary>
        [Required]
        public   string EndTime{ get; set; }
        ///<summary>
        /// 开始时间,pattern &#x3D;&quot;yyyy-MM-dd HH:mm:ss&quot;,timezone&#x3D;&quot;GMT+8&quot;
        ///Required:true
        ///</summary>
        [Required]
        public   string StartTime{ get; set; }
        ///<summary>
        /// 应用id，传all查询所有应用的数据总和
        ///Required:true
        ///</summary>
        [Required]
        public   string AppId{ get; set; }
    }
}