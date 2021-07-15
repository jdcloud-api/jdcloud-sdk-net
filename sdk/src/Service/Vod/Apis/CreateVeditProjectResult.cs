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
 * Vedit Project Management
 * 视频剪辑工程管理相关接口
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

namespace  JDCloudSDK.Vod.Apis
{

    /// <summary>
    ///  创建视频剪辑工程
    /// </summary>
    public class CreateVeditProjectResult : JdcloudResult
    {
        ///<summary>
        /// 工程ID
        ///</summary>
        public   long? ProjectId{ get; set; }
        ///<summary>
        /// 工程名称
        ///</summary>
        public   string ProjectName{ get; set; }
        ///<summary>
        /// 工程描述
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 时间线信息
        ///</summary>
        public   Timeline Timeline{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public   DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 修改时间
        ///</summary>
        public   DateTime? UpdateTime{ get; set; }
    }
}