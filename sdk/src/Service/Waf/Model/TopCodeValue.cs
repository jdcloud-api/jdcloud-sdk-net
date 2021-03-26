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
    ///  topCodeValue
    /// </summary>
    public class TopCodeValue
    {

        ///<summary>
        /// 排名
        ///</summary>
        public int? Rank{ get; set; }
        ///<summary>
        /// 具体值
        ///</summary>
        public string Src{ get; set; }
        ///<summary>
        /// 统计值
        ///</summary>
        public int? Pv{ get; set; }
        ///<summary>
        /// Status_code
        ///</summary>
        public List<KVPair> Status_code{ get; set; }
    }
}
