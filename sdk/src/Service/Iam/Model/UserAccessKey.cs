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


namespace JDCloudSDK.Iam.Model
{

    /// <summary>
    ///  userAccessKey
    /// </summary>
    public class UserAccessKey
    {

        ///<summary>
        /// accessKey
        ///</summary>
        public string AccessKey{ get; set; }
        ///<summary>
        /// accessKeySecret
        ///</summary>
        public string AccessKeySecret{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 禁用/启用状态[0-禁用,1-启用]
        ///</summary>
        public int? State{ get; set; }
        ///<summary>
        /// 删除/有效状态[0-删除,1-有效]
        ///</summary>
        public int? Yn{ get; set; }
    }
}
