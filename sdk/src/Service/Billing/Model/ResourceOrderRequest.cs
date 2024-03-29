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
 * Resource Order Management APIs
 * 资源单管理API接口
 *
 * OpenAPI spec version: v1
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
    ///  resourceOrderRequest
    /// </summary>
    public class ResourceOrderRequest
    {

        ///<summary>
        /// 主键id
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 交易单唯一标识
        ///</summary>
        public string TransactionNo{ get; set; }
        ///<summary>
        /// 资源id
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// 计费类型 1:按配置 2:按用量 3:包年包月 4:一次性
        ///</summary>
        public int? BillingType{ get; set; }
        ///<summary>
        /// 时长类型 1:小时 2:天 3:月 4:年
        ///</summary>
        public int? TimeUnit{ get; set; }
        ///<summary>
        /// 时长字段，与timeUnit字段构成具体时长
        ///</summary>
        public int? TimeSpan{ get; set; }
        ///<summary>
        /// 资源状态 1:正常 2:停服 3:删除
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 计费状态 0:停止计费 1:计费中
        ///</summary>
        public int? BillingStatus{ get; set; }
        ///<summary>
        /// 网络类型0:无 1: non-BGP, 2: BGP
        ///</summary>
        public int? NetworkOperator{ get; set; }
        ///<summary>
        /// 用户pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// 应用码
        ///</summary>
        public string AppCode{ get; set; }
        ///<summary>
        /// 服务码
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 站点标识0:中国 1:国际
        ///</summary>
        public int? Site{ get; set; }
        ///<summary>
        /// 资源区域
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 配置信息
        ///</summary>
        public List<Formula> Formula{ get; set; }
        ///<summary>
        /// 否为试用资源 0:非试用 1:试用
        ///</summary>
        public int? IsOnTrial{ get; set; }
        ///<summary>
        /// 开始时间
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 结束时间
        ///</summary>
        public string EndTime{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 支付时间
        ///</summary>
        public string PayTime{ get; set; }
        ///<summary>
        /// formula转换成字符串
        ///</summary>
        public string FormulaStr{ get; set; }
        ///<summary>
        /// billingType兼容交易系统字段
        ///</summary>
        public int? ChargeMode{ get; set; }
        ///<summary>
        /// timeSpan兼容交易系统字段
        ///</summary>
        public int? ChargeDuration{ get; set; }
        ///<summary>
        /// timeUnit兼容交易系统字段
        ///</summary>
        public int? ChargeUnit{ get; set; }
        ///<summary>
        /// 欠费过期状态
        ///</summary>
        public int? AeStatus{ get; set; }
        ///<summary>
        /// 欠费、过期资源释放时间
        ///</summary>
        public string ReleasingTime{ get; set; }
        ///<summary>
        /// 交易单模块sourceId 计费不关心
        ///</summary>
        public string SourceId{ get; set; }
        ///<summary>
        /// 计费开始时间 续费时本次续费周期开始时间
        ///</summary>
        public string BillingStartTime{ get; set; }
        ///<summary>
        /// 最新价格map
        ///</summary>
        public PriceMap PriceMap{ get; set; }
        ///<summary>
        /// 价格快照
        ///</summary>
        public string PriceSnapshot{ get; set; }
        ///<summary>
        /// 订单折扣前总价
        ///</summary>
        public double? Price{ get; set; }
        ///<summary>
        /// 折扣后订单价格
        ///</summary>
        public double? DiscountedPrice{ get; set; }
        ///<summary>
        /// 即将到期天数
        ///</summary>
        public int? ExpiringDays{ get; set; }
        ///<summary>
        /// 计费类型描述 例如:按配置、包年包月
        ///</summary>
        public string BillingCategoryDescription{ get; set; }
        ///<summary>
        /// 计费详情描述 例如:按配置、包年包月（一年）
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// refundNo
        ///</summary>
        public string RefundNo{ get; set; }
        ///<summary>
        /// 计费类型单号
        ///</summary>
        public string BillingTypeName{ get; set; }
        ///<summary>
        /// 促销明细
        ///</summary>
        public string FavorableInfo{ get; set; }
        ///<summary>
        /// 资源名
        ///</summary>
        public string ResourceName{ get; set; }
        ///<summary>
        /// 变配明细（1-升配，2-降配，3-调整配置,4-续费,5-续费升配,6-续费降配,7-配置转包年包月）
        ///</summary>
        public int? ProcessType{ get; set; }
        ///<summary>
        /// 资源申请人
        ///</summary>
        public string Applicant{ get; set; }
        ///<summary>
        /// 计费模式  1.停服停止计费  2.关机停止计费
        ///</summary>
        public int? BillingMode{ get; set; }
        ///<summary>
        /// 启服、停服、停止计费时间
        ///</summary>
        public string OperateTime{ get; set; }
    }
}
