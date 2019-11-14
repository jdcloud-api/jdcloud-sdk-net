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

namespace JDCloudSDK.Edcps.Model
{

    /// <summary>
    ///  subnetSpec
    /// </summary>
    public class SubnetSpec
    {

        ///<summary>
        /// 可用区, 如 cn-east-tz1a
        ///Required:true
        ///</summary>
        [Required]
        public string Az{ get; set; }
        ///<summary>
        /// 私有网络ID
        ///Required:true
        ///</summary>
        [Required]
        public string VpcId{ get; set; }
        ///<summary>
        /// 子网的网络范围
        ///Required:true
        ///</summary>
        [Required]
        public string Cidr{ get; set; }
        ///<summary>
        /// 子网的次要cidr
        ///</summary>
        public string SecondaryCidr{ get; set; }
        ///<summary>
        /// 子网的次要cidr名称
        ///</summary>
        public string SecondaryCidrName{ get; set; }
        ///<summary>
        /// 名称
        ///Required:true
        ///</summary>
        [Required]
        public string Name{ get; set; }
        ///<summary>
        /// 描述
        ///Required:true
        ///</summary>
        [Required]
        public string Description{ get; set; }
    }
}
