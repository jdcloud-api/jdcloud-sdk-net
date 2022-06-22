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

namespace JDCloudSDK.Logs.Model
{

    /// <summary>
    ///  createParserSpec
    /// </summary>
    public class CreateParserSpec
    {

        ///<summary>
        /// ParserFields
        ///Required:true
        ///</summary>
        [Required]
        public List<ParserField> ParserFields{ get; set; }
        ///<summary>
        /// 解析类型。oneline - 单行，split - 分割， json - json， regexp - regexp
        ///Required:true
        ///</summary>
        [Required]
        public string ParserMode{ get; set; }
        ///<summary>
        /// 解析语法
        ///</summary>
        public string ParserPattern{ get; set; }
        ///<summary>
        /// 日志样例
        ///</summary>
        public string ParserSample{ get; set; }
    }
}