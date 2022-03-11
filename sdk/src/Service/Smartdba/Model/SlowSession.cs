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


namespace JDCloudSDK.Smartdba.Model
{

    /// <summary>
    ///  slowSession
    /// </summary>
    public class SlowSession
    {

        ///<summary>
        /// 会话源端信息(用户名@源端ip)
        ///</summary>
        public string User{ get; set; }
        ///<summary>
        /// 库
        ///</summary>
        public string Db{ get; set; }
        ///<summary>
        /// 会话id列表
        ///</summary>
        public string ThreadIdList{ get; set; }
        ///<summary>
        /// 会话总数
        ///</summary>
        public int? TotalCount{ get; set; }
    }
}
