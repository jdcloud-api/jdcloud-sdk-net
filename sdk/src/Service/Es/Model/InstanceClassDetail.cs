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


namespace JDCloudSDK.Es.Model
{

    /// <summary>
    ///  instanceClassDetail
    /// </summary>
    public class InstanceClassDetail
    {

        ///<summary>
        /// 规格代码，规格代码详情参见：https://docs.jdcloud.com/cn/jcs-for-elasticsearch/specifications
        ///</summary>
        public string InstanceClassCode{ get; set; }
        ///<summary>
        /// cpu核数
        ///</summary>
        public int? Cpu{ get; set; }
        ///<summary>
        /// 内存单位GB
        ///</summary>
        public int? MemoryGB{ get; set; }
        ///<summary>
        /// 存储大小单位GB
        ///</summary>
        public int? DiskGB{ get; set; }
    }
}