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
 * 信用评分接口
 * API Related to Get Credit Score of Resource
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Bri.Model
{

    /// <summary>
    ///  creditResult
    /// </summary>
    public class CreditResult
    {

        ///<summary>
        /// 是否成功，没成功会在failMsg附上错误信息
        ///</summary>
        public bool Success{ get; set; }
        ///<summary>
        /// 错误描述信息
        ///</summary>
        public string FailMsg{ get; set; }
        ///<summary>
        /// 对应请求的dataId
        ///</summary>
        public string DataId{ get; set; }
        ///<summary>
        /// 是否命中黑白名单，black-在黑名单中 white-在白名单中 none-不在任何名单中
        ///</summary>
        public string InBWList{ get; set; }
        ///<summary>
        /// 对应请求的内容
        ///</summary>
        public string Content{ get; set; }
        ///<summary>
        /// 数据类型，ip-IP，phone-手机，addr-地址，card-身份，pin-账户，eid-设备，signup-注册，login-登录，marketing-营销
        ///</summary>
        public string ResourceType{ get; set; }
        ///<summary>
        /// 评分数据
        ///</summary>
        public CreditScoreDetail ScoreDetail{ get; set; }
    }
}
