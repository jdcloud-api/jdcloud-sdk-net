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
    ///  bandwidth
    /// </summary>
    public class Bandwidth
    {

        ///<summary>
        /// The total number of bytes served within the time frame
        ///</summary>
        public double? All{ get; set; }
        ///<summary>
        /// All_beautified
        ///</summary>
        public string All_beautified{ get; set; }
        ///<summary>
        /// The number of bytes that were cached (and served) by scdn
        ///</summary>
        public double? Cached{ get; set; }
        ///<summary>
        /// Cached_beautified
        ///</summary>
        public string Cached_beautified{ get; set; }
        ///<summary>
        /// CachedPercentage
        ///</summary>
        public string CachedPercentage{ get; set; }
    }
}
