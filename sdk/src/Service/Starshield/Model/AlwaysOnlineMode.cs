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
    ///  alwaysOnlineMode
    /// </summary>
    public class AlwaysOnlineMode
    {

        ///<summary>
        /// 域设置的ID
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// on - 开启；off - 关闭
        ///</summary>
        public string Value{ get; set; }
        ///<summary>
        /// 该配置是否可以修改
        ///</summary>
        public bool Editable{ get; set; }
        ///<summary>
        /// 上次修改此设置的时间
        ///</summary>
        public string Modified_on{ get; set; }
    }
}
