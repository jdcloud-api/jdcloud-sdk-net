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


namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  productB
    /// </summary>
    public class ProductB
    {

        ///<summary>
        /// Attrs
        ///</summary>
        public List<Attrs> Attrs{ get; set; }
        ///<summary>
        /// DetailApi
        ///</summary>
        public DetailAPIB DetailApi{ get; set; }
        ///<summary>
        /// DetailLink
        ///</summary>
        public string DetailLink{ get; set; }
        ///<summary>
        /// EnableSwitchAggregates
        ///</summary>
        public bool EnableSwitchAggregates{ get; set; }
        ///<summary>
        /// ListFilter
        ///</summary>
        public object ListFilter{ get; set; }
        ///<summary>
        /// ProductCode
        ///</summary>
        public string ProductCode{ get; set; }
        ///<summary>
        /// 中英文适配，创建时不需要填写
        ///</summary>
        public string ProductName{ get; set; }
        ///<summary>
        /// ProductNameCn
        ///</summary>
        public string ProductNameCn{ get; set; }
        ///<summary>
        /// ProductNameEn
        ///</summary>
        public string ProductNameEn{ get; set; }
        ///<summary>
        /// SpecialRequirements
        ///</summary>
        public bool SpecialRequirements{ get; set; }
    }
}