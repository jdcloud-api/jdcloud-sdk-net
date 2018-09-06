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


namespace JDCloudSDK.Jmr.Model
{

    /// <summary>
    ///  jmrTaskViewModel
    /// </summary>
    public class JmrTaskViewModel
    {

        ///<summary>
        /// Id
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 作业Id
        ///</summary>
        public string TaskId{ get; set; }
        ///<summary>
        /// 作业名称
        ///</summary>
        public string TaskName{ get; set; }
        ///<summary>
        /// 作业类型
        ///</summary>
        public string TaskType{ get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 开始时间
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 结束时间
        ///</summary>
        public string EndTime{ get; set; }
        ///<summary>
        /// 持续时间
        ///</summary>
        public string Duration{ get; set; }
        ///<summary>
        /// 用户名
        ///</summary>
        public string Userpin{ get; set; }
        ///<summary>
        /// 数据中心，即regionId
        ///</summary>
        public string DataCenter{ get; set; }
        ///<summary>
        /// JobId
        ///</summary>
        public string JobId{ get; set; }
        ///<summary>
        /// PlanId
        ///</summary>
        public string PlanId{ get; set; }
        ///<summary>
        /// 工作流Id
        ///</summary>
        public string WorkflowId{ get; set; }
        ///<summary>
        /// 工作流实例Id
        ///</summary>
        public string WorkflowInstanceId{ get; set; }
    }
}