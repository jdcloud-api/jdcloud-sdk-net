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


namespace JDCloudSDK.Pipeline.Model
{

    /// <summary>
    ///  pipelineStage
    /// </summary>
    public class PipelineStage
    {

        ///<summary>
        /// 阶段(stage)的UUID
        ///</summary>
        public string Uuid{ get; set; }
        ///<summary>
        /// 阶段(stage)的名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 阶段(stage)创建时间
        ///</summary>
        public int? CreatedAt{ get; set; }
        ///<summary>
        /// 阶段(stage)开始时间
        ///</summary>
        public int? StartedAt{ get; set; }
        ///<summary>
        /// 阶段(stage)结束时间
        ///</summary>
        public int? DoneAt{ get; set; }
        ///<summary>
        /// 阶段(stage)当前状态
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 阶段(stage)当前状态说明
        ///</summary>
        public string StatusHuman{ get; set; }
        ///<summary>
        /// 第几个阶段(stage)
        ///</summary>
        public int? Position{ get; set; }
        ///<summary>
        /// Actions
        ///</summary>
        public List<PipelineAction> Actions{ get; set; }
    }
}