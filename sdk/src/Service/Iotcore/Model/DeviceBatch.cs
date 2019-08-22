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


namespace JDCloudSDK.Iotcore.Model
{

    /// <summary>
    ///  deviceBatch
    /// </summary>
    public class DeviceBatch
    {

        ///<summary>
        /// 批次Id
        ///</summary>
        public string BatchId{ get; set; }
        ///<summary>
        /// 批次编号
        ///</summary>
        public string BatchNumber{ get; set; }
        ///<summary>
        /// 批次大小
        ///</summary>
        public int? BatchSize{ get; set; }
        ///<summary>
        /// 产品名称
        ///</summary>
        public string ProductName{ get; set; }
        ///<summary>
        /// 添加方式
        ///</summary>
        public int? AutoGenerated{ get; set; }
        ///<summary>
        /// 下载链接
        ///</summary>
        public string RegisterResultUrl{ get; set; }
        ///<summary>
        /// 生成时间
        ///</summary>
        public long? CreatedTime{ get; set; }
    }
}
