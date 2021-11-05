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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Openjrtc.Model
{

    /// <summary>
    ///  人员列表
    /// </summary>
    public class RoomUserInfoObj
    {

        ///<summary>
        /// appId
        ///</summary>
        public string AppId{ get; set; }
        ///<summary>
        /// 用户定义的房间号
        ///</summary>
        public string UserRoomId{ get; set; }
        ///<summary>
        /// 业务接入方用户体系定义的且在JRTC系统内注册过的userId
        ///</summary>
        public string UserId{ get; set; }
        ///<summary>
        /// 用户房间内昵称
        ///</summary>
        public string NickName{ get; set; }
        ///<summary>
        /// 用户socketIo长连接id
        ///</summary>
        public string ConnectId{ get; set; }
        ///<summary>
        /// 状态 1-在线 2-离线
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string JoinTime{ get; set; }
        ///<summary>
        /// 更新时间
        ///</summary>
        public string UpdateTime{ get; set; }
    }
}