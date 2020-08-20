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

namespace JDCloudSDK.Waf.Model
{

    /// <summary>
    ///  getPriceReq
    /// </summary>
    public class GetPriceReq
    {

        ///<summary>
        /// 地域信息
        ///Required:true
        ///</summary>
        [Required]
        public string Region{ get; set; }
        ///<summary>
        /// 购买类型, 1:创建 2:续费 3:升配
        ///Required:true
        ///</summary>
        [Required]
        public int BuyType{ get; set; }
        ///<summary>
        /// 购买时长
        ///Required:true
        ///</summary>
        [Required]
        public int TimeSpan{ get; set; }
        ///<summary>
        /// 时间单位，month, year
        ///Required:true
        ///</summary>
        [Required]
        public string TimeUnit{ get; set; }
        ///<summary>
        /// 实例id，除新建必传
        ///</summary>
        public string WafInstanceId{ get; set; }
        ///<summary>
        /// 套餐类型 1:高级版, 2:企业版 3:旗舰版 4:基础版
        ///Required:true
        ///</summary>
        [Required]
        public int PackageType{ get; set; }
        ///<summary>
        /// 额外的域名扩展包
        ///Required:true
        ///</summary>
        [Required]
        public int ExtraDomainsNum{ get; set; }
        ///<summary>
        /// 额外的qps扩展包,单位为M 该值为50M的倍数
        ///Required:true
        ///</summary>
        [Required]
        public int ExtraBitsLimit{ get; set; }
    }
}
