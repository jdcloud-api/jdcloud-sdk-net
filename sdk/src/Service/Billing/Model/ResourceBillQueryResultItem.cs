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
    ///  resourceBillQueryResultItem
    /// </summary>
    public class ResourceBillQueryResultItem
    {

        ///<summary>
        /// 账单id
        ///</summary>
        public double? BillId{ get; set; }
        ///<summary>
        /// 用户pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// appCode
        ///</summary>
        public string AppCode{ get; set; }
        ///<summary>
        /// serviceCode
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// serviceCodeName
        ///</summary>
        public string ServiceCodeName{ get; set; }
        ///<summary>
        /// 计费类型
        ///</summary>
        public int? BillingType{ get; set; }
        ///<summary>
        /// 计费类型描述
        ///</summary>
        public string BillingTypeName{ get; set; }
        ///<summary>
        /// 资源id
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// 区域
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 区域名称
        ///</summary>
        public string RegionName{ get; set; }
        ///<summary>
        /// 账单开始时间
        ///</summary>
        public string BillStartTime{ get; set; }
        ///<summary>
        /// 账单结束时间
        ///</summary>
        public string BillEndTime{ get; set; }
        ///<summary>
        /// 开始时间
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 结束时间
        ///</summary>
        public string EndTime{ get; set; }
        ///<summary>
        /// 总金额
        ///</summary>
        public double? TotalFee{ get; set; }
        ///<summary>
        /// 现金支付金额
        ///</summary>
        public double? CashPayFee{ get; set; }
        ///<summary>
        /// 代金券支付金额
        ///</summary>
        public double? CashCouponPayFee{ get; set; }
        ///<summary>
        /// 余额支付金额
        ///</summary>
        public double? BalancePayFee{ get; set; }
        ///<summary>
        /// 欠费金额
        ///</summary>
        public double? ArrearFee{ get; set; }
        ///<summary>
        /// 原价
        ///</summary>
        public double? BillFee2{ get; set; }
        ///<summary>
        /// 优惠金额
        ///</summary>
        public double? DiscountFee{ get; set; }
        ///<summary>
        /// 时间
        ///</summary>
        public int? TimeSpan{ get; set; }
        ///<summary>
        /// 时间单位
        ///</summary>
        public int? TimeUnit{ get; set; }
        ///<summary>
        /// 1：新购 2：续费 3：配置变更
        ///</summary>
        public string OpTypeName{ get; set; }
        ///<summary>
        /// 时间
        ///</summary>
        public string TimeSpanName{ get; set; }
        ///<summary>
        /// 时间单位名称 1：小时 2：天 3：月 4：年
        ///</summary>
        public string TimeUnitName{ get; set; }
        ///<summary>
        /// 结算日期
        ///</summary>
        public string SettleTime{ get; set; }
        ///<summary>
        /// 1：老计费 2：新计费
        ///</summary>
        public int? SystemType{ get; set; }
        ///<summary>
        /// 资源名称
        ///</summary>
        public string ResourceName{ get; set; }
        ///<summary>
        /// 标签明细
        ///</summary>
        public List<ResourceTagVo> TagDetails{ get; set; }
    }
}
