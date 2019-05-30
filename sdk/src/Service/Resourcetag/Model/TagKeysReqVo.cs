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
    ///  tagKeysReqVo
    /// </summary>
    public class TagKeysReqVo
    {

        ///<summary>
        /// Pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// Region
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// ServiceCodes
        ///</summary>
        public List<string> ServiceCodes{ get; set; }
        ///<summary>
        /// TagFilters
        ///</summary>
        public List<TagFilter> TagFilters{ get; set; }
    }
}
