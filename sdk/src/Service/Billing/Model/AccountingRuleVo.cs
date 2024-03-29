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


namespace JDCloudSDK.Billing.Model
{

    /// <summary>
    ///  accountingRuleVo
    /// </summary>
    public class AccountingRuleVo
    {

        ///<summary>
        /// id
        ///</summary>
        public double? Id{ get; set; }
        ///<summary>
        /// 站点
        ///</summary>
        public int? Site{ get; set; }
        ///<summary>
        /// 产品线
        ///</summary>
        public string AppCode{ get; set; }
        ///<summary>
        /// 出账对象类型    1：通用   2：用户
        ///</summary>
        public int? TargetType{ get; set; }
        ///<summary>
        /// 产品
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// 出账类型  1：实时出账    2：定期出账
        ///</summary>
        public int? OutAccountType{ get; set; }
        ///<summary>
        /// 出账周期：限制范围 1-28
        ///</summary>
        public int? OutAccountDay{ get; set; }
        ///<summary>
        /// 定期出账  时间表达式
        ///</summary>
        public string TimeCron{ get; set; }
        ///<summary>
        /// 出账对象类型名称
        ///</summary>
        public string TargetTypeName{ get; set; }
        ///<summary>
        /// 产品线名称
        ///</summary>
        public string AppCodeName{ get; set; }
        ///<summary>
        /// 产品名称
        ///</summary>
        public string ServiceCodeName{ get; set; }
        ///<summary>
        /// 出账类型名称
        ///</summary>
        public string OutAccountTypeName{ get; set; }
    }
}
