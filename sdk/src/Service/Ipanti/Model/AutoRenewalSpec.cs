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

namespace JDCloudSDK.Ipanti.Model
{

    /// <summary>
    ///  autoRenewalSpec
    /// </summary>
    public class AutoRenewalSpec
    {

        ///<summary>
        /// 是否开通自动续费, true: 开通自动续费, false: 不开通自动续费
        ///Required:true
        ///</summary>
        [Required]
        public bool AutoRenewalEnable{ get; set; }
        ///<summary>
        /// 购买时长, 开通自动续费时必传. &lt;br&gt;- timeUnit 为 3 时, 可取值 1-9&lt;br&gt;- timeUnit 为 4 时, 可取值 1-3
        ///</summary>
        public int? TimeSpan{ get; set; }
        ///<summary>
        /// 自动续费时长类型, 开通自动续费时必传. &lt;br&gt;- 3: 月&lt;br&gt;- 4: 年
        ///</summary>
        public int? TimeUnit{ get; set; }
    }
}