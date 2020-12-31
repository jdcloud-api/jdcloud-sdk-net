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
 * 验证码服务相关接口
 * 京东云验证码-验证码服务相关接口
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


namespace  JDCloudSDK.Captcha.Apis
{

    /// <summary>
    ///  获取会话id
    /// </summary>
    public class GetSessionIdRequest : JdcloudRequest
    {
        ///<summary>
        /// 应用id
        ///</summary>
        public   long? AppId{ get; set; }
        ///<summary>
        /// 场景id
        ///</summary>
        public   long? SceneId{ get; set; }
        ///<summary>
        /// 密钥，从界面获取
        ///</summary>
        public   string Secret{ get; set; }
        ///<summary>
        /// uuid，ios客户端传openudid, android客户端传androidid
        ///</summary>
        public   string Uuid{ get; set; }
        ///<summary>
        /// 客户端ip
        ///</summary>
        public   string Ip{ get; set; }
        ///<summary>
        /// 客户端userAgent
        ///</summary>
        public   string UserAgent{ get; set; }
        ///<summary>
        /// 指纹，客户端sdk获取
        ///</summary>
        public   string FingerPrint{ get; set; }
        ///<summary>
        /// 客户端类型, android, ios
        ///</summary>
        public   string ClientType{ get; set; }
        ///<summary>
        /// 客户端版本，用户端app版本，可选
        ///</summary>
        public   string ClientVersion{ get; set; }
    }
}