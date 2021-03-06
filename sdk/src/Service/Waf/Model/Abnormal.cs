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
    ///  abnormal
    /// </summary>
    public class Abnormal
    {

        ///<summary>
        /// NoResp
        ///</summary>
        public ChartItemValue NoResp{ get; set; }
        ///<summary>
        /// S503
        ///</summary>
        public ChartItemValue S503{ get; set; }
        ///<summary>
        /// S404
        ///</summary>
        public ChartItemValue S404{ get; set; }
        ///<summary>
        /// S502
        ///</summary>
        public ChartItemValue S502{ get; set; }
        ///<summary>
        /// S504
        ///</summary>
        public ChartItemValue S504{ get; set; }
        ///<summary>
        /// S5XX
        ///</summary>
        public ChartItemValue S5XX{ get; set; }
    }
}
