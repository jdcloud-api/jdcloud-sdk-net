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

namespace JDCloudSDK.Renewal.Model
{

    /// <summary>
    ///  queryExpiredResourceParam
    /// </summary>
    public class QueryExpiredResourceParam
    {

        ///<summary>
        /// 地域：不传时获取全部
        ///Required:true
        ///</summary>
        [Required]
        public string Region{ get; set; }
        ///<summary>
        /// 产品线：多个用逗号分隔
        ///Required:true
        ///</summary>
        [Required]
        public string ServiceCodes{ get; set; }
        ///<summary>
        /// 到期类型：大于0-订单还有几天到期; 等于0-订单已经到期; 小于0-全部
        ///Required:true
        ///</summary>
        [Required]
        public int ExpireType{ get; set; }
        ///<summary>
        /// 当前页码
        ///</summary>
        public int? PageIndex{ get; set; }
        ///<summary>
        /// 每页条数
        ///</summary>
        public int? PageSize{ get; set; }
    }
}
