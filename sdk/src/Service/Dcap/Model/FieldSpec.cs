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

namespace JDCloudSDK.Dcap.Model
{

    /// <summary>
    ///  fieldSpec
    /// </summary>
    public class FieldSpec
    {

        ///<summary>
        /// 字段名称
        ///Required:true
        ///</summary>
        [Required]
        public string FieldName{ get; set; }
        ///<summary>
        /// 加密字段
        ///Required:true
        ///</summary>
        [Required]
        public string EncryptField{ get; set; }
        ///<summary>
        /// 索引字段
        ///Required:true
        ///</summary>
        [Required]
        public string IndexField{ get; set; }
        ///<summary>
        /// 是否保留明文字段,true:保留明文字段
        ///Required:true
        ///</summary>
        [Required]
        public bool KeepPlainText{ get; set; }
    }
}
