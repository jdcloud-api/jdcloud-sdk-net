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


namespace JDCloudSDK.Antipro.Model
{

    /// <summary>
    ///  operationRecord
    /// </summary>
    public class OperationRecord
    {

        ///<summary>
        /// 操作时间
        ///</summary>
        public string Time{ get; set; }
        ///<summary>
        /// 防护包名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 操作类型:  1：套餐变更, 2：防护规则变更, 3：防护对象变更, 4：IP 地址变更, 5：防护包名称变更
        ///</summary>
        public int? Action{ get; set; }
        ///<summary>
        /// 操作详情
        ///</summary>
        public string Info{ get; set; }
        ///<summary>
        /// 操作人
        ///</summary>
        public string Operator{ get; set; }
    }
}
