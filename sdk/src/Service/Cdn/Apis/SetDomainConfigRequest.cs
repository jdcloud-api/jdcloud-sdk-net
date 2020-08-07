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
    ///  更新域名配置
    /// </summary>
    public class SetDomainConfigRequest : JdcloudRequest
    {
        ///<summary>
        /// http类型,只能为http或者https
        ///</summary>
        public   string HttpType{ get; set; }
        ///<summary>
        /// 回源类型
        ///</summary>
        public   string BackSourceType{ get; set; }
        ///<summary>
        /// 有三种类型：default、http、https
        ///</summary>
        public   string JumpType{ get; set; }
        ///<summary>
        /// dash鉴权相关配置
        ///</summary>
        public   string JcdnTimeAnti{ get; set; }
        ///<summary>
        /// 回源鉴权相关配置
        ///</summary>
        public   string HdrCtrl{ get; set; }
        ///<summary>
        /// 头条header配置
        ///</summary>
        public   string ToutiaoHeader{ get; set; }
        ///<summary>
        /// 用户域名
        ///Required:true
        ///</summary>
        [Required]
        public   string Domain{ get; set; }
    }
}