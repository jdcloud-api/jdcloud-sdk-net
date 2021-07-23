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
    ///  billingRuleVo
    /// </summary>
    public class BillingRuleVo
    {

        ///<summary>
        /// id
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 站点
        ///</summary>
        public int? Site{ get; set; }
        ///<summary>
        /// 业务线编码
        ///</summary>
        public string AppCode{ get; set; }
        ///<summary>
        /// 业务线名称
        ///</summary>
        public string AppCodeName{ get; set; }
        ///<summary>
        /// 产品编码
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 产品编码名称
        ///</summary>
        public string ServiceCodeName{ get; set; }
        ///<summary>
        /// 用户pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// 计费时长类型 - 0:按使用时长；1:按周期时长
        ///</summary>
        public int? Strategy{ get; set; }
        ///<summary>
        /// 计费时长类型名称
        ///</summary>
        public string StrategyName{ get; set; }
        ///<summary>
        /// 计费周期类型 - 0:按小时；1:按天
        ///</summary>
        public int? CycleType{ get; set; }
        ///<summary>
        /// 计费周期类型名称
        ///</summary>
        public string CycleTypeName{ get; set; }
        ///<summary>
        /// 区分大客户 - 1:是；0:否
        ///</summary>
        public int? DosingMode{ get; set; }
        ///<summary>
        /// 大客户统计周期 - 0:按小时计费；1:按天计费
        ///</summary>
        public int? DosingCycle{ get; set; }
        ///<summary>
        /// 计费模式 - 1:删除不计费；2:关机不计费
        ///</summary>
        public int? BillingMode{ get; set; }
        ///<summary>
        /// 最小计费时长 - 必须为大于等于0的整数
        ///</summary>
        public int? TimeSpan{ get; set; }
        ///<summary>
        /// 删除状态 - 0:未删除；1:已删除
        ///</summary>
        public int? IsDeleted{ get; set; }
        ///<summary>
        /// 操作人
        ///</summary>
        public string Operator{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 修改时间
        ///</summary>
        public string UpdateTime{ get; set; }
    }
}
