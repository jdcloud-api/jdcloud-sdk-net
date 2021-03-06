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


namespace JDCloudSDK.Pod.Model
{

    /// <summary>
    ///  pod 状态
    /// </summary>
    public class PodStatus
    {

        ///<summary>
        /// pod当前状态
        ///</summary>
        public string Phase{ get; set; }
        ///<summary>
        /// （简要）pod处于当前状态的原因
        ///</summary>
        public string Reason{ get; set; }
        ///<summary>
        /// pod处于当前状态原因的详细信息
        ///</summary>
        public string Message{ get; set; }
        ///<summary>
        /// 分配给pod的IP地址。至少在集群内是可路由的。未分配则为空。
        ///</summary>
        public string PodIP{ get; set; }
        ///<summary>
        /// 目前pod的状态。
        ///</summary>
        public List<PodCondition> Conditions{ get; set; }
        ///<summary>
        /// Pod生命周期开始的时间。
        ///</summary>
        public string StartTime{ get; set; }
    }
}
