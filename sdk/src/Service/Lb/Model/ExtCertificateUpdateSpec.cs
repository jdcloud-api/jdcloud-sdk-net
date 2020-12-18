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

namespace JDCloudSDK.Lb.Model
{

    /// <summary>
    ///  extCertificateUpdateSpec
    /// </summary>
    public class ExtCertificateUpdateSpec
    {

        ///<summary>
        /// 证书绑定Id
        ///Required:true
        ///</summary>
        [Required]
        public string CertificateBindId{ get; set; }
        ///<summary>
        /// 证书Id
        ///</summary>
        public string CertificateId{ get; set; }
        ///<summary>
        /// 域名,支持输入精确域名和通配符域名：1、仅支持输入大小写字母、数字、英文中划线“-”和点“.”，最少包括一个点&quot;.&quot;，不能以点&quot;.&quot;和中划线&quot;-&quot;开头或结尾，中划线&quot;-&quot;前后不能为点&quot;.&quot;，不区分大小写，且不能超过110字符；2、通配符匹配支持包括一个星&quot;\*&quot;，输入格式为\*.XXX,不支持仅输入一个星“\*”。监听器创建时绑定的默认证书不允许修改域名。
        ///</summary>
        public string Domain{ get; set; }
    }
}