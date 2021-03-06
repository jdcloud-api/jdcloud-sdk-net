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


namespace JDCloudSDK.Es.Model
{

    /// <summary>
    ///  autoSnapshot
    /// </summary>
    public class AutoSnapshot
    {

        ///<summary>
        /// 是否开启自动备份；true为开启，false为不开启
        ///</summary>
        public bool Open{ get; set; }
        ///<summary>
        /// 自动备份时间，0时区的小时数，[0，24）范围内取整
        ///</summary>
        public int? Hour{ get; set; }
    }
}
