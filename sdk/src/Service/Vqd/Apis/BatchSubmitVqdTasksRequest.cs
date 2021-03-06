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
 * Vqd Task
 * 视频质检任务相关接口
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

using JDCloudSDK.Vqd.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Vqd.Apis
{

    /// <summary>
    ///  批量提交视频质检任务，一次同时最多提交50个输入媒体
    /// </summary>
    public class BatchSubmitVqdTasksRequest : JdcloudRequest
    {
        ///<summary>
        /// 媒体列表
        ///Required:true
        ///</summary>
        [Required]
        public List<VqdMediaObject> MediaList{ get; set; }

        ///<summary>
        /// 检测模板ID
        ///Required:true
        ///</summary>
        [Required]
        public   string TemplateId{ get; set; }
    }
}