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


namespace JDCloudSDK.Openjrtc.Model
{

    /// <summary>
    ///  用户房间列表
    /// </summary>
    public class UserRoomInfosObj
    {

        ///<summary>
        /// 当前页码
        ///</summary>
        public int? PageNumber{ get; set; }
        ///<summary>
        /// 每页数量
        ///</summary>
        public int? PageSize{ get; set; }
        ///<summary>
        /// 查询总数
        ///</summary>
        public int? TotalElements{ get; set; }
        ///<summary>
        /// 总页数
        ///</summary>
        public int? TotalPages{ get; set; }
        ///<summary>
        /// 分页内容
        ///</summary>
        public List<UserRoomInfoObj> Content{ get; set; }
    }
}
