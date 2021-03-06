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


namespace JDCloudSDK.Waf.Model
{

    /// <summary>
    ///  topN
    /// </summary>
    public class TopN
    {

        ///<summary>
        /// Addr_top10
        ///</summary>
        public TopValue Addr_top10{ get; set; }
        ///<summary>
        /// Area_top10
        ///</summary>
        public TopValue Area_top10{ get; set; }
        ///<summary>
        /// Url_top10
        ///</summary>
        public TopValue Url_top10{ get; set; }
        ///<summary>
        /// Ua_top10
        ///</summary>
        public TopValue Ua_top10{ get; set; }
        ///<summary>
        /// Domain_anti_top10
        ///</summary>
        public TopAntiValue Domain_anti_top10{ get; set; }
        ///<summary>
        /// Url_anti_top10
        ///</summary>
        public TopAntiValue Url_anti_top10{ get; set; }
    }
}
