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


namespace JDCloudSDK.Captcha.Model
{

    /// <summary>
    ///  verifyDataResp
    /// </summary>
    public class VerifyDataResp
    {

        ///<summary>
        /// 代号，0000:验证成功，0001:验证失败，0002:内部错误
        ///</summary>
        public string Code{ get; set; }
        ///<summary>
        /// 会话id，验证失败后返回
        ///</summary>
        public string SessionId{ get; set; }
    }
}
