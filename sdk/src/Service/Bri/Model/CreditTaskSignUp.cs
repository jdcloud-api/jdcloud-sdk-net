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
    ///  creditTaskSignUp
    /// </summary>
    public class CreditTaskSignUp
    {

        ///<summary>
        /// 数据Id。需要保证在一次请求中所有的Id不重复
        ///</summary>
        public string DataId{ get; set; }
        ///<summary>
        /// 待检测数据字符串，最长4096个字符，为可解析字符串json，例如：&quot;{\&quot;phone\&quot;:\&quot;18212341234\&quot;,\&quot;ip\&quot;:\&quot;1.1.1.1\&quot;,\&quot;regEmail\&quot;:\&quot;\&quot;,\&quot;regName\&quot;:\&quot;user1\&quot;,\&quot;regType\&quot;:1,\&quot;channel\&quot;:1,\&quot;timestamp\&quot;:1604588399968,\&quot;elapsedTime\&quot;:\&quot;29\&quot;,\&quot;eid\&quot;:\&quot;7E8XXX\&quot;,\&quot;regResult\&quot;:1}&quot;。数据结构如creditTaskSignUpDetail
        ///</summary>
        public CreditTaskSignUpDetail Content{ get; set; }
        ///<summary>
        /// 数据类型，signup-注册场景
        ///</summary>
        public string ResourceType{ get; set; }
    }
}
