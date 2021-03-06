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


namespace JDCloudSDK.Kubernetes.Model
{

    /// <summary>
    ///  集群自动伸缩参数：&lt;br&gt;
        /// 
    /// </summary>
    public class CAConfig
    {

        ///<summary>
        /// 是否启用了自动伸缩
        /// 
        ///</summary>
        public bool Enable{ get; set; }
        ///<summary>
        /// 自动扩容最大工作节点数
        ///</summary>
        public int? MaxNode{ get; set; }
        ///<summary>
        /// 自动扩容最小工作节点数
        ///</summary>
        public int? MinNode{ get; set; }
    }
}
