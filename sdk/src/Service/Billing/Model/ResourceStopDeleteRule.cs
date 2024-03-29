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
    ///  resourceStopDeleteRule
    /// </summary>
    public class ResourceStopDeleteRule
    {

        ///<summary>
        /// 站点
        ///Required:true
        ///</summary>
        [Required]
        public int Site{ get; set; }
        ///<summary>
        /// 产品线
        ///Required:true
        ///</summary>
        [Required]
        public string AppCode{ get; set; }
        ///<summary>
        /// pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// 规则类型 1：试用规则 2、用户产品规则 3：用户规则 4：产品规则 5：通用规则 6：用户等级产品规则
        ///Required:true
        ///</summary>
        [Required]
        public int RuleType{ get; set; }
        ///<summary>
        /// 产品
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 按配置欠费是否停服  1：欠费需要停服 0：欠费不需要停服
        ///Required:true
        ///</summary>
        [Required]
        public int ArrearStop{ get; set; }
        ///<summary>
        /// 按配置欠费停服延后时长(0：立即停服  n：n几小时后停服)
        ///Required:true
        ///</summary>
        [Required]
        public int ArrearStopDelayHours{ get; set; }
        ///<summary>
        /// 按配置欠费停服是否释放资源  1：需要释放资源 0：不需要释放资源
        ///Required:true
        ///</summary>
        [Required]
        public int ArrearDelete{ get; set; }
        ///<summary>
        /// 按配置欠费停服释放资源延后时长(0：立即释放资源 n：n几小时后释放资源)
        ///Required:true
        ///</summary>
        [Required]
        public int ArrearDeleteDelayHours{ get; set; }
        ///<summary>
        /// 到期是否停服  1：到期需要停服 0：到期不需要停服
        ///Required:true
        ///</summary>
        [Required]
        public int ExpireStop{ get; set; }
        ///<summary>
        /// 到期停服延后时长(0：立即停服  n：n几小时后停服)
        ///Required:true
        ///</summary>
        [Required]
        public int ExpireStopDelayHours{ get; set; }
        ///<summary>
        /// 到期停服是否释放资源  1：需要释放资源 0：不需要释放资源
        ///Required:true
        ///</summary>
        [Required]
        public int ExpireDelete{ get; set; }
        ///<summary>
        /// 到期停服释放资源延后时长(0：立即释放资源  n：n几小时后释放资源)
        ///Required:true
        ///</summary>
        [Required]
        public int ExpireDeleteDelayHours{ get; set; }
        ///<summary>
        /// 按配置欠费释放类型 1：释放资源  2：释放数据
        ///Required:true
        ///</summary>
        [Required]
        public int ArrearDeleteType{ get; set; }
        ///<summary>
        /// 到期释放类型 1：释放资源  2：释放数据
        ///Required:true
        ///</summary>
        [Required]
        public int ExpireDeleteType{ get; set; }
        ///<summary>
        /// 按用量欠费是否停服  1：欠费需要停服 0：欠费不需要停服
        ///Required:true
        ///</summary>
        [Required]
        public int FlowArrearStop{ get; set; }
        ///<summary>
        /// 按用量欠费停服延后时长
        ///Required:true
        ///</summary>
        [Required]
        public int FlowArrearStopDelayHours{ get; set; }
        ///<summary>
        /// 按用量欠费停服是否释放资源  1：需要释放资源 0：不需要释放资源
        ///Required:true
        ///</summary>
        [Required]
        public int FlowArrearDelete{ get; set; }
        ///<summary>
        /// 按用量欠费停服释放资源延后时长
        ///Required:true
        ///</summary>
        [Required]
        public int FlowArrearDeleteDelayHours{ get; set; }
        ///<summary>
        /// 按用量欠费释放类型 1：释放资源  2：释放数据
        ///Required:true
        ///</summary>
        [Required]
        public int FlowArrearDeleteType{ get; set; }
        ///<summary>
        /// 客户级别 1-普通客户 2-VIP客户
        ///</summary>
        public int? ClientType{ get; set; }
    }
}
