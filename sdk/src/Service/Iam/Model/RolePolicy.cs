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
    ///  rolePolicy
    /// </summary>
    public class RolePolicy
    {

        ///<summary>
        /// 策略名称
        ///</summary>
        public string PolicyName{ get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 策略类型：0-系统策略，1-用户策略
        ///</summary>
        public string Type{ get; set; }
        ///<summary>
        /// 京东云策略资源描述
        ///</summary>
        public string PolicyJrn{ get; set; }
    }
}
