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


namespace JDCloudSDK.Billing.Model
{

    /// <summary>
    ///  resourceOrderStatusResultItem
    /// </summary>
    public class ResourceOrderStatusResultItem
    {

        ///<summary>
        /// 资源id
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// 计费类型 1:按配置 2:按用量 3:包年包月 4:一次性
        ///</summary>
        public int? BillingType{ get; set; }
        ///<summary>
        /// 资源状态 1:正常 2:停服 3:删除
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 用户pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// 资源区域
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 操作时间
        ///</summary>
        public string UpdateTime{ get; set; }
    }
}