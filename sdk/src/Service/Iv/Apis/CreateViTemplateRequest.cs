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
 * Vi Template
 * 视频审查模板管理相关接口
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

namespace  JDCloudSDK.Iv.Apis
{

    /// <summary>
    ///  创建视频审查模板
    /// </summary>
    public class CreateViTemplateRequest : JdcloudRequest
    {
        ///<summary>
        /// 模板名称。长度不超过128个字符。UTF-8编码。
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public   string TemplateName{ get; set; }
        ///<summary>
        /// 截图间隔
        ///</summary>
        public   int? ShotInterval{ get; set; }
        ///<summary>
        /// 间隔类型：time, percent
        ///</summary>
        public   string ShotIntervalType{ get; set; }
        ///<summary>
        /// 截图格式：png, jpg
        ///</summary>
        public   string ShotFormat{ get; set; }
        ///<summary>
        /// 截图帧类型：any, key
        ///</summary>
        public   string ShotFrameType{ get; set; }
        ///<summary>
        /// 截图宽度
        ///</summary>
        public   int? ShotWidth{ get; set; }
        ///<summary>
        /// 截图高度
        ///</summary>
        public   int? ShotHeight{ get; set; }
        ///<summary>
        /// 截图填充类型：stretch, gauss, black, white
        ///</summary>
        public   string ShotFillType{ get; set; }
        ///<summary>
        /// 审查配置，JSON格式
        ///Required:true
        ///</summary>
        [Required]
        public   string InspectItems{ get; set; }
    }
}