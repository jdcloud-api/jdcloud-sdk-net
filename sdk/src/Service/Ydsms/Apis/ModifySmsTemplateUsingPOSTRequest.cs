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
 * 云鼎短信服务-模板相关接口
 * 云鼎短信服务-模板相关接口
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
    ///  编辑短信模板
    /// </summary>
    public class ModifySmsTemplateUsingPOSTRequest : JdcloudRequest
    {
        ///<summary>
        /// 应用id
        ///Required:true
        ///</summary>
        [Required]
        public   string AppId{ get; set; }
        ///<summary>
        /// 申请说明
        ///</summary>
        public   string ApplyExplanation{ get; set; }
        ///<summary>
        /// 模板内容
        ///Required:true
        ///</summary>
        [Required]
        public   string TemplateContent{ get; set; }
        ///<summary>
        /// 模板名称
        ///Required:true
        ///</summary>
        [Required]
        public   string TemplateName{ get; set; }
        ///<summary>
        /// 模板类型:0 验证码短信,1 通知短信,2 推广短信
        ///Required:true
        ///</summary>
        [Required]
        public   int TemplateType{ get; set; }
        ///<summary>
        /// 模板id
        ///Required:true
        ///</summary>
        [Required]
        public   string TemplateId{ get; set; }
    }
}