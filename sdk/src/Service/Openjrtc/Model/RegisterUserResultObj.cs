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
    ///  registerUserResultObj
    /// </summary>
    public class RegisterUserResultObj
    {

        ///<summary>
        /// 应用ID
        ///</summary>
        public string AppId{ get; set; }
        ///<summary>
        /// 业务接入方的用户ID
        ///</summary>
        public string UserId{ get; set; }
        ///<summary>
        /// jrtc系统用户ID
        ///</summary>
        public long? PeerId{ get; set; }
    }
}
