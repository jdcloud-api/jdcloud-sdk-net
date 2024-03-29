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
 * McuTask
 * 混流任务
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

using JDCloudSDK.Openjrtc.Model;

namespace  JDCloudSDK.Openjrtc.Apis
{

    /// <summary>
    ///  下发混流任务
        ///         /// 
    /// </summary>
    public class StartMcuTranscodeRequest : JdcloudRequest
    {
        ///<summary>
        /// 应用ID
        ///</summary>
        public   string AppId{ get; set; }
        ///<summary>
        /// 业务接入方定义的且在JRTC系统内注册过的房间号
        ///</summary>
        public   string UserRoomId{ get; set; }
        ///<summary>
        /// 布局模板-支持参数1
        ///</summary>
        public   int? LayoutTemplate{ get; set; }
        ///<summary>
        /// 主人员userId
        ///</summary>
        public   string MainUserId{ get; set; }
        ///<summary>
        /// 输出类型 1：录制 2：旁路转推
        ///</summary>
        public   int? OutputType{ get; set; }
        ///<summary>
        /// 输出名称
        ///</summary>
        public   string OutputName{ get; set; }
        ///<summary>
        /// 参与混流人员参数
        ///</summary>
        public List<McuUser> McuUserInfos{ get; set; }

        ///<summary>
        /// 输出格式
        ///</summary>
        public   OutputEncode OutputEncode{ get; set; }
    }
}