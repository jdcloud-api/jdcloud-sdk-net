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
 * 私有网络
 * 私有网络相关接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Vpc.Apis
{

    /// <summary>
    ///  修改私有网络接口
    /// </summary>
    public class ModifyVpcRequest : JdcloudRequest
    {
        ///<summary>
        /// 私有网络名称,只允许输入中文、数字、大小写字母、英文下划线“_”及中划线“-”，不允许为空且不超过32字符。
        ///</summary>
        public   string VpcName{ get; set; }
        ///<summary>
        /// vpc描述，允许输入UTF-8编码下的全部字符，不超过256字符。
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// Vpc ID
        ///Required:true
        ///</summary>
        [Required]
        public   string VpcId{ get; set; }
    }
}