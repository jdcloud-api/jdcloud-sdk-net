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


namespace JDCloudSDK.Bri.Model
{

    /// <summary>
    ///  creditTask
    /// </summary>
    public class CreditTask
    {

        ///<summary>
        /// 数据Id。需要保证在一次请求中所有的Id不重复
        ///</summary>
        public string DataId{ get; set; }
        ///<summary>
        /// 待检测数据，最长512个字符
        ///</summary>
        public string Content{ get; set; }
        ///<summary>
        /// 数据类型，ip-IP，phone-手机，addr-地址，card-身份，pin-账户，eid-设备，signup-注册，login-登录，marketing-营销
        ///</summary>
        public string ResourceType{ get; set; }
    }
}
