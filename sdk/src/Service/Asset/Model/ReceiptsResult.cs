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
 * JDCLOUD asset API
 * API JDCLOUD asset API
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Asset.Model
{

    /// <summary>
    ///  receiptsResult
    /// </summary>
    public class ReceiptsResult
    {

        ///<summary>
        /// CreateTime
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// Fee
        ///</summary>
        public double? Fee{ get; set; }
        ///<summary>
        /// Pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// Status
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// Trade_no
        ///</summary>
        public string Trade_no{ get; set; }
        ///<summary>
        /// Trade_type
        ///</summary>
        public int? Trade_type{ get; set; }
        ///<summary>
        /// UpdateTime
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
        ///<summary>
        /// UsableFee
        ///</summary>
        public double? UsableFee{ get; set; }
    }
}
