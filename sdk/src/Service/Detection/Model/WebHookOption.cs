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


namespace JDCloudSDK.Detection.Model
{

    /// <summary>
    ///  webHookOption
    /// </summary>
    public class WebHookOption
    {

        ///<summary>
        /// 回调content 注：仅webHookUrl和webHookProtocol均不为空时，才会创建webHook
        ///</summary>
        public string WebHookContent{ get; set; }
        ///<summary>
        /// webHook协议
        ///</summary>
        public string WebHookProtocol{ get; set; }
        ///<summary>
        /// 回调secret，用户请求签名，防伪造
        ///</summary>
        public string WebHookSecret{ get; set; }
        ///<summary>
        /// 回调url
        ///</summary>
        public string WebHookUrl{ get; set; }
    }
}
