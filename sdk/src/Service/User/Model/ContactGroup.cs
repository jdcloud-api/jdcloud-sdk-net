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


namespace JDCloudSDK.User.Model
{

    /// <summary>
    ///  contactGroup
    /// </summary>
    public class ContactGroup
    {

        ///<summary>
        /// id
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        /// 用户pin(创建人)
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// 组名
        ///</summary>
        public string GroupName{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? Created{ get; set; }
        ///<summary>
        /// 修改时间
        ///</summary>
        public DateTime? Modified{ get; set; }
        ///<summary>
        /// 是否正常：0表示删除，1表示正常
        ///</summary>
        public int? Yn{ get; set; }
    }
}
