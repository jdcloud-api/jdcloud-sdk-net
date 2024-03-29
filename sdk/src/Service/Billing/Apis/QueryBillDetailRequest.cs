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
 * Billing Management APIs
 * 帐单查询API接口
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
    ///  查询账单明细数据
    /// </summary>
    public class QueryBillDetailRequest : JdcloudRequest
    {
        ///<summary>
        /// 账期开始时间,不支持跨月查询。格式:yyyy-MM-dd HH:mm:ss
        ///Required:true
        ///</summary>
        [Required]
        public   string StartTime{ get; set; }
        ///<summary>
        /// 账期结束时间,不支持跨月查询。格式:yyyy-MM-dd HH:mm:ss
        ///Required:true
        ///</summary>
        [Required]
        public   string EndTime{ get; set; }
        ///<summary>
        /// 产品线代码
        ///</summary>
        public   string AppCode{ get; set; }
        ///<summary>
        /// 产品代码
        ///</summary>
        public   string ServiceCode{ get; set; }
        ///<summary>
        /// 计费类型 1、按配置 2、按用量 3、包年包月 4、按次
        ///</summary>
        public   int? BillingType{ get; set; }
        ///<summary>
        /// 资源单id列表,最多支持传入500个
        ///</summary>
        public List<string> ResourceIds{ get; set; }

        ///<summary>
        /// 标签,JSON格式:[{&quot;k1&quot;:&quot;v1&quot;},{&quot;k1&quot;:&quot;v2&quot;},{&quot;k2&quot;:&quot;&quot;}]
        /// 示例:
        /// 选择的标签为, 部门:广告部、部门:物流部、项目
        /// 则传值为:[{&quot;部门&quot;:&quot;广告部&quot;},{&quot;部门&quot;:&quot;物流部&quot;},{&quot;项目&quot;:&quot;&quot;}]
        /// 
        ///</summary>
        public List<Tags> Tags{ get; set; }

        ///<summary>
        /// pageIndex 分页,默认从1开始
        ///</summary>
        public   int? PageIndex{ get; set; }
        ///<summary>
        /// pageSize 每页查询数据条数,最多支持1000条
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}