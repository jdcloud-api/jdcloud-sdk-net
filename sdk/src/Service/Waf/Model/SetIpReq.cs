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
    ///  setIpReq
    /// </summary>
    public class SetIpReq
    {

        ///<summary>
        /// WAF实例id
        ///Required:true
        ///</summary>
        [Required]
        public string WafInstanceId{ get; set; }
        ///<summary>
        /// 域名
        ///Required:true
        ///</summary>
        [Required]
        public string Domain{ get; set; }
        ///<summary>
        /// 0表示黑名单，1表示白名单
        ///</summary>
        public int? Iswhite{ get; set; }
        ///<summary>
        /// 0默认关闭，1默认打开
        ///</summary>
        public int? IsEnable{ get; set; }
        ///<summary>
        /// ip配置
        ///Required:true
        ///</summary>
        [Required]
        public List<IpCfg> Ips{ get; set; }
    }
}
