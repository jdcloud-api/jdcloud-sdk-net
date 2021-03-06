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


namespace JDCloudSDK.Dcap.Model
{

    /// <summary>
    ///  dataSourceTrendItem
    /// </summary>
    public class DataSourceTrendItem
    {

        ///<summary>
        /// 时间戳
        ///</summary>
        public int? TimeStamp{ get; set; }
        ///<summary>
        /// 受保护的数据源数量
        ///</summary>
        public int? ProtectDataSourceCount{ get; set; }
        ///<summary>
        /// 总的数据源数量
        ///</summary>
        public int? TotalDataSourceCount{ get; set; }
    }
}
