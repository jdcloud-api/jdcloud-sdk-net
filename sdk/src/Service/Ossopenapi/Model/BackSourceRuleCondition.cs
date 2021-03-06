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
 * back source configuration openapi
 * back source configuration openapi
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Ossopenapi.Model
{

    /// <summary>
    ///  backSourceRuleCondition
    /// </summary>
    public class BackSourceRuleCondition
    {

        ///<summary>
        /// 当前缀为指定的前缀时开启回源
        ///</summary>
        public string KeyPrefixEquals{ get; set; }
        ///<summary>
        /// 当http错误码为指定错误码时开启回源
        ///</summary>
        public int? HttpErrorCodeReturnedEquals{ get; set; }
    }
}
