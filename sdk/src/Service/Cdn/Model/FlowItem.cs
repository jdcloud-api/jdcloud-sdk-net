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


namespace JDCloudSDK.Cdn.Model
{

    /// <summary>
    ///  flowItem
    /// </summary>
    public class FlowItem
    {

        ///<summary>
        /// 时间点，2020-12-08 00:00
        ///</summary>
        public string Time{ get; set; }
        ///<summary>
        /// 目录流量(Byte)
        ///</summary>
        public double? Flow{ get; set; }
        ///<summary>
        /// 目录
        ///</summary>
        public string Dir{ get; set; }
        ///<summary>
        /// 目录访问次数
        ///</summary>
        public long? Pv{ get; set; }
    }
}
