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
    ///  磁盘空间
    /// </summary>
    public class DiskView
    {

        ///<summary>
        /// 总空间
        ///</summary>
        public string TotalSize{ get; set; }
        ///<summary>
        /// 已用空间
        ///</summary>
        public string UsedSize{ get; set; }
        ///<summary>
        /// 日增空间
        ///</summary>
        public string DayIncrease{ get; set; }
        ///<summary>
        /// 空间日增率
        ///</summary>
        public string DayRatio{ get; set; }
        ///<summary>
        /// 扣分说明
        ///</summary>
        public string Message{ get; set; }
    }
}
