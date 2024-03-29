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

namespace JDCloudSDK.Openjrtc.Model
{

    /// <summary>
    ///  filter
    /// </summary>
    public class Filter
    {

        ///<summary>
        /// 过滤器属性名
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 过滤器操作符,默认值为 eq
        /// enum:
        ///   - eq
        /// 
        ///</summary>
        public string Operator{ get; set; }
        ///<summary>
        /// 过滤器属性值
        ///Required:true
        ///</summary>
        [Required]
        public List<string> Values{ get; set; }
    }
}
