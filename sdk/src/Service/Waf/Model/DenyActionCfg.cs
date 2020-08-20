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
    ///  denyActionCfg
    /// </summary>
    public class DenyActionCfg
    {

        ///<summary>
        /// 黑名单匹配动作类型 1-4 分别表示forbidden@1 redirect@2 verify@captcha3 verify@jscookie4 5-告警(自定义bot增加)，6-302cookie(自定义bot增加)
        ///Required:true
        ///</summary>
        [Required]
        public int AtOp{ get; set; }
        ///<summary>
        /// 黑名单匹配动作内容 当atOp为3/4时，atVal为空，atOp&#x3D;1时，atVal为自定义页面,atOp&#x3D;2时，atVal为跳转url。
        ///Required:true
        ///</summary>
        [Required]
        public string AtVal{ get; set; }
    }
}
