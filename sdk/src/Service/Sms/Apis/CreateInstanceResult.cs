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
 * Send-Message-Related-APIs
 * 套餐包相关API
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

using JDCloudSDK.Sms.Model;

namespace  JDCloudSDK.Sms.Apis
{

    /// <summary>
    ///  统一选购，购买套餐包，自动支付。 接口调用需要使用京东云统一鉴权的SDK方式接入，以下文档仅是接口出参、入参描述，并不是最终程序实现逻辑的范例，具体接口实现请查看SDK参考：https://docs.jdcloud.com/cn/text-message/java
    /// </summary>
    public class CreateInstanceResult : JdcloudResult
    {
        ///<summary>
        /// 购买信息
        ///</summary>
        public   CreateInstanceResp Data{ get; set; }
        ///<summary>
        /// 请求状态
        ///</summary>
        public   bool Status{ get; set; }
        ///<summary>
        /// 错误码
        ///</summary>
        public   long? Code{ get; set; }
        ///<summary>
        /// 错误消息
        ///</summary>
        public   string Message{ get; set; }
    }
}