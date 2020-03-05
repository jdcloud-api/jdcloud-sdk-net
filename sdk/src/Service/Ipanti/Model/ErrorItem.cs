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
 * IP Sets
 * IP 黑白名单库, 预定义的 IP 黑白名单绑定到转发规则的黑名单或白名单后生效
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Ipanti.Model
{

    /// <summary>
    ///  errorItem
    /// </summary>
    public class ErrorItem
    {

        ///<summary>
        /// 出错资源ID
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 错误码，同标准code
        ///</summary>
        public long? Code{ get; set; }
        ///<summary>
        /// Details
        ///</summary>
        public object Details{ get; set; }
        ///<summary>
        /// Message
        ///</summary>
        public string Message{ get; set; }
        ///<summary>
        /// 具体错误，同标准status
        ///</summary>
        public string Status{ get; set; }
    }
}
