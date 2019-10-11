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


namespace JDCloudSDK.Elite.Model
{

    /// <summary>
    ///  productServiceVo
    /// </summary>
    public class ProductServiceVo
    {

        ///<summary>
        /// 交付单号
        ///</summary>
        public string DeliverNumber{ get; set; }
        ///<summary>
        /// 订单号
        ///</summary>
        public string OrderNumber{ get; set; }
        ///<summary>
        /// 续费订单所关联的新购订单号，该字段只针对续费单有效，新购单该字段为null
        ///</summary>
        public string RefOrderNumber{ get; set; }
        ///<summary>
        /// 订单类型
        ///</summary>
        public int? OrderType{ get; set; }
        ///<summary>
        /// 订单类型名称
        ///</summary>
        public string OrderTypeName{ get; set; }
        ///<summary>
        /// 购买人
        ///</summary>
        public string BuyerPin{ get; set; }
        ///<summary>
        /// 映射编号
        ///</summary>
        public string MappingCode{ get; set; }
        ///<summary>
        /// 是否支持自动交付：0表示不支持，1表示支持
        ///</summary>
        public int? SupportAutoDeliver{ get; set; }
        ///<summary>
        /// 产品ID
        ///</summary>
        public int? ProductId{ get; set; }
        ///<summary>
        /// sku ID
        ///</summary>
        public int? SkuId{ get; set; }
        ///<summary>
        /// sku名称
        ///</summary>
        public string SkuName{ get; set; }
        ///<summary>
        /// 服务code
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 数量
        ///</summary>
        public int? Num{ get; set; }
        ///<summary>
        /// 周期
        ///</summary>
        public int? Period{ get; set; }
        ///<summary>
        /// 周期类型
        ///</summary>
        public int? PeriodType{ get; set; }
        ///<summary>
        /// 周期类型名称
        ///</summary>
        public string PeriodTypeName{ get; set; }
        ///<summary>
        /// 账号数量
        ///</summary>
        public int? AccountNum{ get; set; }
        ///<summary>
        /// 交付状态
        ///</summary>
        public int? DeliverStatus{ get; set; }
        ///<summary>
        /// 交付状态名称
        ///</summary>
        public string DeliverStatusName{ get; set; }
        ///<summary>
        /// 服务生效时间，格式：yyyy-MM-dd HH:mm:ss
        ///</summary>
        public string EffectiveDt{ get; set; }
        ///<summary>
        /// 服务过期时间，格式：yyyy-MM-dd HH:mm:ss
        ///</summary>
        public string FailureDt{ get; set; }
        ///<summary>
        /// 商品属性
        ///</summary>
        public string ExtraInfo{ get; set; }
        ///<summary>
        /// 交付单备注
        ///</summary>
        public string Remark{ get; set; }
        ///<summary>
        /// 订单金额
        ///</summary>
        public string OrderTotalFee{ get; set; }
        ///<summary>
        /// 订单实付金额
        ///</summary>
        public string OrderActualFee{ get; set; }
        ///<summary>
        /// 订单支付时间
        ///</summary>
        public string PaymentDt{ get; set; }
        ///<summary>
        /// 额外计费项信息
        ///</summary>
        public string ExtraChargeInfo{ get; set; }
        ///<summary>
        /// 额外计费详情信息
        ///</summary>
        public List<OrderItemExtraChargeInfo> OrderItemExtraChargeInfos{ get; set; }
    }
}
