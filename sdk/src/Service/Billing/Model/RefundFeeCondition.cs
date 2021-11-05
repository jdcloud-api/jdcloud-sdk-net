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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Billing.Model
{

    /// <summary>
    ///  refundFeeCondition
    /// </summary>
    public class RefundFeeCondition
    {

        ///<summary>
        /// 退款类型,退资源：REFUND_RESOURCE;退续费：REFUND_RENEW
        ///Required:true
        ///</summary>
        [Required]
        public string RefundType{ get; set; }
        ///<summary>
        /// 退款时间(格式：yyyy-MM-dd HH:mm:ss)
        ///</summary>
        public string RefundTime{ get; set; }
        ///<summary>
        /// 退款资源列表
        ///Required:true
        ///</summary>
        [Required]
        public List<RefundResource> RefundResources{ get; set; }
    }
}