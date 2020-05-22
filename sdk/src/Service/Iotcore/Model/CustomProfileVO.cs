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
    ///  自定义档案信息
    /// </summary>
    public class CustomProfileVO
    {

        ///<summary>
        /// 档案code
        ///Required:true
        ///</summary>
        [Required]
        public string ProfileCode{ get; set; }
        ///<summary>
        /// 当前特征描述
        ///</summary>
        public string ProfileDesc{ get; set; }
        ///<summary>
        /// 档案name
        ///Required:true
        ///</summary>
        [Required]
        public string ProfileName{ get; set; }
        ///<summary>
        /// 档案值
        ///</summary>
        public string ProfileValue{ get; set; }
    }
}
