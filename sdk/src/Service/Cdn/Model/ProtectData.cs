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


namespace JDCloudSDK.Cdn.Model
{

    /// <summary>
    ///  protectData
    /// </summary>
    public class ProtectData
    {

        ///<summary>
        /// 防护后流量序
        ///</summary>
        public float? PostProtect{ get; set; }
        ///<summary>
        /// 防护前流量序
        ///</summary>
        public float? PreProtect{ get; set; }
        ///<summary>
        /// 时间戳,到秒
        ///</summary>
        public long? TimeStamp{ get; set; }
        ///<summary>
        /// UTC时间
        ///</summary>
        public string TimeUtc{ get; set; }
    }
}
