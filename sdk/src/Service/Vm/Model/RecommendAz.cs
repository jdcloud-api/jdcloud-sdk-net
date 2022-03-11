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


namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  推荐数据信息。
    /// </summary>
    public class RecommendAz
    {

        ///<summary>
        /// 云主机所在可用区。
        ///</summary>
        public string Az{ get; set; }
        ///<summary>
        /// 实例规格族。
        ///</summary>
        public string Family{ get; set; }
        ///<summary>
        /// 地域信息
        ///</summary>
        public string Region{ get; set; }
    }
}
