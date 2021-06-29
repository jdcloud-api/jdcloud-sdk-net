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
 * Transcode Template Group
 * 转码模板组管理相关接口
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

using JDCloudSDK.Vod.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Vod.Apis
{

    /// <summary>
    ///  修改转码模板组
    /// </summary>
    public class UpdateTranscodeTemplateGroupRequest : JdcloudRequest
    {
        ///<summary>
        /// 转码模板组名称
        ///</summary>
        public   string GroupName{ get; set; }
        ///<summary>
        /// Templates
        ///</summary>
        public List<GroupedTranscodeTemplateData> Templates{ get; set; }

        ///<summary>
        /// 模板组ID
        ///Required:true
        ///</summary>
        [Required]
        public   string GroupId{ get; set; }
    }
}