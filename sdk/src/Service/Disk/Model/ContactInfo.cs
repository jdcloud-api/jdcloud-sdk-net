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


namespace JDCloudSDK.Disk.Model
{

    /// <summary>
    ///  联系人信息。请求参数中，sms和email中至少一个为 &#x60;发送&#x60;
    /// </summary>
    public class ContactInfo
    {

        ///<summary>
        /// 是否发送短信。0:不发送 1:发送
        ///</summary>
        public int? Sms{ get; set; }
        ///<summary>
        /// 是否发送短信。0:不发送 1:发送
        ///</summary>
        public int? Email{ get; set; }
        ///<summary>
        /// 联系人id
        ///</summary>
        public List<int?> PersonIds{ get; set; }
        ///<summary>
        /// 联系组id
        ///</summary>
        public List<int?> GroupIds{ get; set; }
    }
}
