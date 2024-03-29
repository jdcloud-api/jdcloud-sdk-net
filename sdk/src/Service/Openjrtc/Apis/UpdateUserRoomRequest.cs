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
 * UserRoom
 * 用户房间号管理
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

namespace  JDCloudSDK.Openjrtc.Apis
{

    /// <summary>
    ///  修改房间
        ///         /// 
    /// </summary>
    public class UpdateUserRoomRequest : JdcloudRequest
    {
        ///<summary>
        /// 用户房间号
        ///</summary>
        public   string UserRoomId{ get; set; }
        ///<summary>
        /// 房间名称
        ///</summary>
        public   string RoomName{ get; set; }
        ///<summary>
        /// 房间类型 1-小房间；2-大房间
        ///</summary>
        public   int? RoomType{ get; set; }
        ///<summary>
        /// 应用ID
        ///Required:true
        ///</summary>
        [Required]
        public   string AppId{ get; set; }
    }
}