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


namespace JDCloudSDK.Censor.Model
{

    /// <summary>
    ///  ossCallback
    /// </summary>
    public class OssCallback
    {

        ///<summary>
        /// 回调地址
        ///</summary>
        public string Callback{ get; set; }
        ///<summary>
        /// 增量回调，0-不开启，1-开启
        ///</summary>
        public int? IncrementCall{ get; set; }
        ///<summary>
        /// 存量回调，0-不开启，1-开启
        ///</summary>
        public int? StockCall{ get; set; }
        ///<summary>
        /// 扫描回调，0-不开启，1-开启
        ///</summary>
        public int? ScanCall{ get; set; }
        ///<summary>
        /// 审核回调，0-不开启，1-开启
        ///</summary>
        public int? ReviewCall{ get; set; }
        ///<summary>
        /// 校验seed
        ///</summary>
        public string Seed{ get; set; }
    }
}