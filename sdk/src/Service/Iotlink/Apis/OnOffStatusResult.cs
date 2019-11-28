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
 * Iotlink-Related-API
 * 物联网卡服务相关API
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

using JDCloudSDK.Iotlink.Model;

namespace  JDCloudSDK.Iotlink.Apis
{

    /// <summary>
    ///  根据物联网卡iccid查询该卡的开关机状态信息
    /// </summary>
    public class OnOffStatusResult : JdcloudResult
    {
        ///<summary>
        /// 请求状态(0:成功;1:失败)
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// 消息描述
        ///</summary>
        public   string Message{ get; set; }
        ///<summary>
        /// 指定物联网卡的开关机状态信息
        ///</summary>
        public   OnOffStatusResp Result{ get; set; }
    }
}