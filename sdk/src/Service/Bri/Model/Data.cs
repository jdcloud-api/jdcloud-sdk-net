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


namespace JDCloudSDK.Bri.Model
{

    /// <summary>
    ///  data
    /// </summary>
    public class Data
    {

        ///<summary>
        /// 累计付费用户
        ///</summary>
        public int? PaidUsersNumber{ get; set; }
        ///<summary>
        /// 累计体验用户
        ///</summary>
        public int? FreeUsersNumber{ get; set; }
        ///<summary>
        /// 累计无效用户
        ///</summary>
        public int? InvalidUsersNumber{ get; set; }
        ///<summary>
        /// 资源包总数
        ///</summary>
        public int? TotalResourcePack{ get; set; }
        ///<summary>
        /// 有效资源包
        ///</summary>
        public int? ValidResourcePack{ get; set; }
        ///<summary>
        /// 过期资源包
        ///</summary>
        public int? ExpireResourcePack{ get; set; }
        ///<summary>
        /// 订单总额
        ///</summary>
        public double? TotalOrder{ get; set; }
        ///<summary>
        /// 收入总额
        ///</summary>
        public double? TotalIncome{ get; set; }
    }
}