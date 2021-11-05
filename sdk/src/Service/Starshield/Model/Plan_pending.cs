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


namespace JDCloudSDK.Starshield.Model
{

    /// <summary>
    ///  plan_pending
    /// </summary>
    public class Plan_pending
    {

        ///<summary>
        /// Id
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// Name
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// Price
        ///</summary>
        public double? Price{ get; set; }
        ///<summary>
        /// Currency
        ///</summary>
        public string Currency{ get; set; }
        ///<summary>
        /// Frequency
        ///</summary>
        public string Frequency{ get; set; }
        ///<summary>
        /// Legacy_id
        ///</summary>
        public string Legacy_id{ get; set; }
        ///<summary>
        /// Is_subscribed
        ///</summary>
        public bool Is_subscribed{ get; set; }
        ///<summary>
        /// Can_subscribe
        ///</summary>
        public bool Can_subscribe{ get; set; }
    }
}