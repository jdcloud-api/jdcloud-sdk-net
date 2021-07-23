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

namespace JDCloudSDK.Captcha.Model
{

    /// <summary>
    ///  verifyData
    /// </summary>
    public class VerifyData
    {

        ///<summary>
        /// 提交后台校验的token，客户端sdk获取
        ///Required:true
        ///</summary>
        [Required]
        public string VerifyToken{ get; set; }
        ///<summary>
        /// 验证码回话id，getsessionid返回
        ///Required:true
        ///</summary>
        [Required]
        public string SessionId{ get; set; }
        ///<summary>
        /// 应用id
        ///Required:true
        ///</summary>
        [Required]
        public int AppId{ get; set; }
        ///<summary>
        /// 场景id
        ///Required:true
        ///</summary>
        [Required]
        public int SceneId{ get; set; }
        ///<summary>
        /// 密钥，从界面获取
        ///</summary>
        public string Secret{ get; set; }
        ///<summary>
        /// 客户端ip
        ///Required:true
        ///</summary>
        [Required]
        public string Ip{ get; set; }
        ///<summary>
        /// 客户端userAgent
        ///Required:true
        ///</summary>
        [Required]
        public string UserAgent{ get; set; }
        ///<summary>
        /// 客户端类型, android, ios, pc, wxapp
        ///</summary>
        public string ClientType{ get; set; }
        ///<summary>
        /// 客户端版本，用户端app版本，可选
        ///</summary>
        public string ClientVersion{ get; set; }
    }
}
