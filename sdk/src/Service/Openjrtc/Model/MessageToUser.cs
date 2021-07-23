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
    ///  自定义消息体
    /// </summary>
    public class MessageToUser
    {

        ///<summary>
        /// 事件名称
        ///</summary>
        public string EventName{ get; set; }
        ///<summary>
        /// 自定义信令消息
        ///</summary>
        public string Message{ get; set; }
        ///<summary>
        /// peerId
        ///</summary>
        public long? PeerId{ get; set; }
    }
}
