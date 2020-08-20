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

namespace JDCloudSDK.Lb.Model
{

    /// <summary>
    ///  targetUpdateSpec
    /// </summary>
    public class TargetUpdateSpec
    {

        ///<summary>
        /// Target Id
        ///Required:true
        ///</summary>
        [Required]
        public string TargetId{ get; set; }
        ///<summary>
        /// Target提供服务的端口，取值范围：0-65535，其中0表示与backend的端口相同 &lt;br&gt;【dnlb】使用限制：dnlb同一TargetGroup下，同一实例/ip仅允许一个端口提供服务
        ///</summary>
        public int? Port{ get; set; }
        ///<summary>
        /// Target的权重，取值范围：0-100。0表示不参与流量转发
        ///</summary>
        public int? Weight{ get; set; }
    }
}
