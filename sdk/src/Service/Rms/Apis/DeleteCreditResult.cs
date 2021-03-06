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
 * Message-Credit-APIs
 * 富媒体资质创建、修改、删除、查询相关接口
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Rms.Model;

namespace  JDCloudSDK.Rms.Apis
{

    /// <summary>
    ///  删除富媒体短信资质接口
    /// </summary>
    public class DeleteCreditResult : JdcloudResult
    {
        ///<summary>
        /// 资质ID
        ///</summary>
        public   RespCreditData Data{ get; set; }
        ///<summary>
        /// 请求状态
        ///</summary>
        public   bool Status{ get; set; }
        ///<summary>
        /// 错误码
        ///</summary>
        public   string Code{ get; set; }
        ///<summary>
        /// 错误消息
        ///</summary>
        public   string Message{ get; set; }
    }
}