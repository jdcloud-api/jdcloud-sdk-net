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
 * Anti DDos Pro Instance APIs
 * Anti DDos Pro Instance APIs
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


namespace  JDCloudSDK.Ipanti.Apis
{

    /// <summary>
    ///  开启实例错误状态码返回页面, 错误状态码返回默认页面或自定义页面
    /// </summary>
    public class EnableInstanceCustomPageResult : JdcloudResult
    {
        ///<summary>
        /// 0: 修改失败, 1: 修改成功
        ///</summary>
        public   int? Code{ get; set; }
        ///<summary>
        /// 修改失败时给出具体原因
        ///</summary>
        public   string Message{ get; set; }
    }
}