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
    ///  集群升级计划
    /// </summary>
    public class UpgradePlan
    {

        ///<summary>
        /// 升级方式 auto, manual
        ///</summary>
        public string Mode{ get; set; }
        ///<summary>
        /// 升级范围 cluster, master, nodegroup
        ///</summary>
        public string Scope{ get; set; }
        ///<summary>
        /// 升级计划状态 waiting, upgrading
        ///</summary>
        public string State{ get; set; }
        ///<summary>
        /// master 期望版本
        ///</summary>
        public string MasterExpectedVersion{ get; set; }
        ///<summary>
        /// node 期望版本
        ///</summary>
        public string NodeExpectedVersion{ get; set; }
        ///<summary>
        /// 升级启动时间
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 持续时长
        ///</summary>
        public int? Duration{ get; set; }
    }
}
