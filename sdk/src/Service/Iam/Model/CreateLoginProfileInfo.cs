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


namespace JDCloudSDK.Iam.Model
{

    /// <summary>
    ///  createLoginProfileInfo
    /// </summary>
    public class CreateLoginProfileInfo
    {

        ///<summary>
        /// 子用户登录是否需要重置密码，默认false
        ///</summary>
        public bool PasswordResetRequired{ get; set; }
        ///<summary>
        /// 指定密码，密码必须符合密码强度要求。关于密码强度设置接口，请参考describePasswordPolicy
        ///</summary>
        public string Password{ get; set; }
        ///<summary>
        /// 是否自动生成密码，默认false
        ///</summary>
        public bool AutoGeneratePassword{ get; set; }
        ///<summary>
        /// 指定子用户在下次登录时是否必须绑定虚拟MFA设备
        ///</summary>
        public bool MFABindRequired{ get; set; }
    }
}
