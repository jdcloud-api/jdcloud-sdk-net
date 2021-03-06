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
    ///  rsConfig
    /// </summary>
    public class RsConfig
    {

        ///<summary>
        /// 回源地址
        ///Required:true
        ///</summary>
        [Required]
        public List<string> RsAddr{ get; set; }
        ///<summary>
        /// 回源地址权重，与rsAddr顺序对应
        ///</summary>
        public List<int?> Weight{ get; set; }
        ///<summary>
        /// http回源端口
        ///</summary>
        public List<string> HttpRsPort{ get; set; }
        ///<summary>
        /// https回源端口
        ///</summary>
        public List<string> HttpsRsPort{ get; set; }
        ///<summary>
        /// 回源地址类型，0为ip，1为域名
        ///</summary>
        public int? RsType{ get; set; }
    }
}
