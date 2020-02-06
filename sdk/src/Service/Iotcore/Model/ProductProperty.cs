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

namespace JDCloudSDK.Iotcore.Model
{

    /// <summary>
    ///  productProperty
    /// </summary>
    public class ProductProperty
    {

        ///<summary>
        /// 名称, 1~30个字符，仅支持英文字母、数字、下划线“_”及中划线“-”，必须英文字母及数字开头结尾
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 描述, 0-50个字符
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 数据类型，string:字符串，bool:布尔，float:单精度浮点数，double:双精度浮点数，int32:整型，enum:枚举
        ///Required:true
        ///</summary>
        [Required]
        public string DataType{ get; set; }
        ///<summary>
        /// 单位, 0-10个字符
        ///</summary>
        public string Unit{ get; set; }
        ///<summary>
        /// 单位名称, 0-10个字符
        ///</summary>
        public string UnitName{ get; set; }
        ///<summary>
        /// 参数最小值(int32, float, double类型时,必填)
        /// 整型取值范围：-2的31次方 ~2的31次方-1
        /// 单精度浮点取值范围：-2的128次方+1 ~2的128次方-1,最多7位小数
        /// 双精度浮点取值范围：-2的1023次方+1 ~2的1023次方-1,最多14位小数
        /// 
        ///</summary>
        public double? Min{ get; set; }
        ///<summary>
        /// 参数最大值(int32, float, double类型时,必填)
        /// 最大值必须大于最小值
        /// 整型取值范围：-2的31次方 ~2的31次方-1
        /// 单精度浮点取值范围：-2的128次方+1 ~2的128次方-1,最多7位小数
        /// 双精度浮点取值范围：-2的1023次方+1 ~2的1023次方-1,最多14位小数
        /// 
        ///</summary>
        public double? Max{ get; set; }
        ///<summary>
        /// 参数步长(int32, float, double类型时,必填)
        /// 整型取值范围：0 ~2的31次方-1
        /// 单精度浮点取值范围：0 ~2的128次方-1,最多7位小数
        /// 双精度浮点取值范围：0~2的1023次方-1,最多14位小数
        /// 
        ///</summary>
        public double? Step{ get; set; }
        ///<summary>
        /// 参数长度(string类型特有时,必填)
        /// 取值范围:1-256之间的整数)
        /// 
        ///</summary>
        public int? Length{ get; set; }
        ///<summary>
        /// 枚举定义信息(enum、bool类型时,必填)
        /// 布尔值名称：不可为空，支持汉字、英文字母、数字。长度为1-10个字符
        /// 枚举值:为字符型，0~99。至少包括两个枚举值。输入“0”时，仅支持1位。其他数字不支持以0开头
        /// 枚举值名称：不可为空，支持汉字、英文字母、数字。长度为1-10个字符
        /// 枚举类型格式如:{10:&quot;on&quot;,10:&quot;off&quot;}
        /// 布尔类型格式如:{&quot;True&quot;:&quot;12&quot;,&quot;False&quot;:&quot;22&quot;}
        ///</summary>
        public object EnumInfo{ get; set; }
    }
}