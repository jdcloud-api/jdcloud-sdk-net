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
    ///  serviceInfoB
    /// </summary>
    public class ServiceInfoB
    {

        ///<summary>
        /// DataMapping
        ///</summary>
        public DataMappingB DataMapping{ get; set; }
        ///<summary>
        /// Filters
        ///</summary>
        public object Filters{ get; set; }
        ///<summary>
        /// Ipv4Regions
        ///</summary>
        public List<LvInfoB> Ipv4Regions{ get; set; }
        ///<summary>
        /// Ipv6Regions
        ///</summary>
        public List<LvInfoB> Ipv6Regions{ get; set; }
        ///<summary>
        /// ListApi
        ///</summary>
        public ListAPIB ListApi{ get; set; }
        ///<summary>
        /// Products
        ///</summary>
        public List<ProductB> Products{ get; set; }
        ///<summary>
        /// Search
        ///</summary>
        public List<SearchB> Search{ get; set; }
        ///<summary>
        /// ServiceCode
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 中英文适配
        ///</summary>
        public string ServiceName{ get; set; }
        ///<summary>
        /// ServiceNameCn
        ///</summary>
        public string ServiceNameCn{ get; set; }
        ///<summary>
        /// ServiceNameEn
        ///</summary>
        public string ServiceNameEn{ get; set; }
        ///<summary>
        /// Status
        ///</summary>
        public List<StatusB> Status{ get; set; }
        ///<summary>
        /// TableColumns
        ///</summary>
        public List<TableColumnB> TableColumns{ get; set; }
    }
}