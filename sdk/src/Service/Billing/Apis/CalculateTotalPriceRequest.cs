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
 * Price APIs
 * 价格计算API接口
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

using JDCloudSDK.Billing.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Billing.Apis
{

    /// <summary>
    ///  查询计费价格信息
    /// </summary>
    public class CalculateTotalPriceRequest : JdcloudRequest
    {
        ///<summary>
        /// 操作类型 1:创建 2:续费 3:升配 4:删除
        ///Required:true
        ///</summary>
        [Required]
        public   int Cmd{ get; set; }
        ///<summary>
        /// 计算价格的订单
        ///</summary>
        public List<OrderPriceProtocol> OrderList{ get; set; }

        ///<summary>
        /// 操作时间，遵循ISO8601标准，使用UTC时间，格式为：YYYY-MM-DDTHH:mm:ssZ
        ///</summary>
        public   string OperateTime{ get; set; }
        ///<summary>
        /// 1:折扣（不需要传） 2:免费活动3:付费活动 4:推荐码 5:会员价 [{&quot;promotionType&quot;:1,&quot;activityCode&quot;:123},{&quot;promotionType&quot;:2,&quot;activityCode&quot;:}]
        ///</summary>
        public   string PromotionInfo{ get; set; }
        ///<summary>
        /// 客户端：1.PC端；2.移动端；
        ///</summary>
        public   int? ClientType{ get; set; }
        ///<summary>
        /// 批量购买时数量
        ///Required:true
        ///</summary>
        [Required]
        public   int PackageCount{ get; set; }
        ///<summary>
        /// 临时升配时必传，3-临时升配
        ///</summary>
        public   int? ProcessType{ get; set; }
        ///<summary>
        /// RegionIdValue
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}