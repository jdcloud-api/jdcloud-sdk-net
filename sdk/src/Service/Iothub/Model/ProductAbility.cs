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

namespace JDCloudSDK.Iothub.Model
{

    /// <summary>
    ///  productAbility
    /// </summary>
    public class ProductAbility
    {

        ///<summary>
        /// 功能唯一标识
        ///Required:true
        ///</summary>
        [Required]
        public string AbilityId{ get; set; }
        ///<summary>
        /// 名称
        ///Required:true
        ///</summary>
        [Required]
        public string AbilityName{ get; set; }
        ///<summary>
        /// 类型,0:属性,1:事件,2:服务
        ///Required:true
        ///</summary>
        [Required]
        public int AbilityType{ get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public string AbilityDescription{ get; set; }
        ///<summary>
        /// 读写性,read_only:只读,read_write:读写
        ///</summary>
        public string AccessMode{ get; set; }
        ///<summary>
        /// 数据类型
        ///</summary>
        public string AbilityDataType{ get; set; }
        ///<summary>
        /// 数据定义
        ///</summary>
        public string AbilityDataSpec{ get; set; }
        ///<summary>
        /// 是否为自定义功能,false:否,true:是
        ///Required:true
        ///</summary>
        [Required]
        public bool Customized{ get; set; }
        ///<summary>
        /// 创建时间,时间为东八区(UTC/GMT+08:00)
        ///Required:true
        ///</summary>
        [Required]
        public long CreatedTime{ get; set; }
    }
}
