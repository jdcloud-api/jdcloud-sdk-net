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
 * 域名操作类接口
 * Openapi For JCLOUD cdn
 *
 * OpenAPI spec version: v1
 * Contact: pid-cdn@jd.com
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  设置域名refer
    /// </summary>
    public class SetReferRequest : JdcloudRequest
    {
        ///<summary>
        /// refer类型，取值：block（黑名单），allow（白名单）默认为block
        ///</summary>
        public   string ReferType{ get; set; }
        ///<summary>
        /// 逗号隔开的域名列表，如果referList传空则为删除，中国境内加速域名至多可配置400条，中国境外/全球加速域名至多可配置50条
        ///</summary>
        public List<string> ReferList{ get; set; }

        ///<summary>
        /// 是否允许空refer访问，默认为“on”
        ///</summary>
        public   string AllowNoReferHeader{ get; set; }
        ///<summary>
        /// 是否允许无ua访问，默认为“on”
        ///</summary>
        public   string AllowNullReferHeader{ get; set; }
        ///<summary>
        /// 用户域名
        ///Required:true
        ///</summary>
        [Required]
        public   string Domain{ get; set; }
    }
}