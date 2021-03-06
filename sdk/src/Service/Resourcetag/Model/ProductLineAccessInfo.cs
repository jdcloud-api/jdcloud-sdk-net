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


namespace JDCloudSDK.Resourcetag.Model
{

    /// <summary>
    ///  productLineAccessInfo
    /// </summary>
    public class ProductLineAccessInfo
    {

        ///<summary>
        /// 产品线代号名称
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 产品线英文名称, 提供给标签控制台展示
        ///</summary>
        public string FeName{ get; set; }
        ///<summary>
        /// 产品线中文名称, 提供给标签控制台展示
        ///</summary>
        public string FeNameCn{ get; set; }
        ///<summary>
        /// 产品线是否标准接入标签系统
        ///</summary>
        public bool StandardAccess{ get; set; }
        ///<summary>
        /// 是否区分地域
        ///</summary>
        public bool DistinguishRegion{ get; set; }
    }
}
