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
    ///  activityLog
    /// </summary>
    public class ActivityLog
    {

        ///<summary>
        /// Timestamp
        ///</summary>
        public string Timestamp{ get; set; }
        ///<summary>
        /// FirewallAction
        ///</summary>
        public string FirewallAction{ get; set; }
        ///<summary>
        /// Country
        ///</summary>
        public string Country{ get; set; }
        ///<summary>
        /// Ip
        ///</summary>
        public string Ip{ get; set; }
        ///<summary>
        /// Host
        ///</summary>
        public string Host{ get; set; }
        ///<summary>
        /// HttpMethod
        ///</summary>
        public string HttpMethod{ get; set; }
        ///<summary>
        /// HttpProtocol
        ///</summary>
        public string HttpProtocol{ get; set; }
        ///<summary>
        /// RequestUri
        ///</summary>
        public string RequestUri{ get; set; }
        ///<summary>
        /// FirewallSource
        ///</summary>
        public string FirewallSource{ get; set; }
        ///<summary>
        /// UserAgent
        ///</summary>
        public string UserAgent{ get; set; }
        ///<summary>
        /// RuleId
        ///</summary>
        public string RuleId{ get; set; }
    }
}
