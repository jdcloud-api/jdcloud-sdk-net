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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Iam.Model
{

    /// <summary>
    ///  createSubUserInfo
    /// </summary>
    public class CreateSubUserInfo
    {

        ///<summary>
        /// 子用户名，支持4~20位的字母，数字以及-和_，以字母开头
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 描述，0~256个字符
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 按照密码策略设置，默认8~20位，至少包含一个小写字母、大写字母和数字
        ///Required:true
        ///</summary>
        [Required]
        public string Password{ get; set; }
        ///<summary>
        /// 手机号码，区号-手机号
        ///Required:true
        ///</summary>
        [Required]
        public string Phone{ get; set; }
        ///<summary>
        /// 邮箱
        ///Required:true
        ///</summary>
        [Required]
        public string Email{ get; set; }
        ///<summary>
        /// 是否创建accessKey，默认false
        ///</summary>
        public bool CreateAk{ get; set; }
        ///<summary>
        /// 子用户首次登录是否需要重置密码，默认false
        ///</summary>
        public bool NeedResetPassword{ get; set; }
        ///<summary>
        /// 子用户是否支持控制台登录，默认true
        ///</summary>
        public bool ConsoleLogin{ get; set; }
        ///<summary>
        /// 是否自动生成密码，默认false
        ///</summary>
        public bool AutoGeneratePassword{ get; set; }
    }
}
