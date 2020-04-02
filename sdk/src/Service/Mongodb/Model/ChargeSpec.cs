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
 * 实例管理
 * API related to MONGODB instances
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Mongodb.Model
{

    /// <summary>
    ///  chargeSpec
    /// </summary>
    public class ChargeSpec
    {

        ///<summary>
        /// 计费模式，取值为：prepaid_by_duration，postpaid_by_usage或postpaid_by_duration，prepaid_by_duration表示预付费，postpaid_by_usage表示按用量后付费，postpaid_by_duration表示按配置后付费，默认为postpaid_by_duration.请参阅具体产品线帮助文档确认该产品线支持的计费类型
        ///</summary>
        public string ChargeMode{ get; set; }
        ///<summary>
        /// 预付费计费单位，预付费必填，当chargeMode为prepaid_by_duration时有效，取值为：month、year，默认为month
        ///</summary>
        public string ChargeUnit{ get; set; }
        ///<summary>
        /// 预付费计费时长，预付费必填，当chargeMode取值为prepaid_by_duration时有效。当chargeUnit为month时取值为：1~9，当chargeUnit为year时取值为：1、2、3
        ///</summary>
        public int? ChargeDuration{ get; set; }
        ///<summary>
        /// True&#x3D;：OPEN——开通自动续费、False&#x3D;CLOSE—— 不开通自动续费，默认为CLOSE
        ///</summary>
        public bool AutoRenew{ get; set; }
        ///<summary>
        /// 产品线统一活动凭证JSON字符串，需要BASE64编码，目前要求编码前格式为 {&quot;activity&quot;:{&quot;activityType&quot;:必填字段, &quot;activityIdentifier&quot;:必填字段}}
        ///</summary>
        public string BuyScenario{ get; set; }
    }
}
