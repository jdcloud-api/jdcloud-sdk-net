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


namespace JDCloudSDK.Redis.Model
{

    /// <summary>
    ///  任务进度信息
    /// </summary>
    public class TaskProgress
    {

        ///<summary>
        /// 任务类型：resize表示变配，同一时刻只能有一个变配任务
        ///</summary>
        public string TaskType{ get; set; }
        ///<summary>
        /// 任务id
        ///</summary>
        public string TaskId{ get; set; }
        ///<summary>
        /// 任务状态：init表示初始化，running表示运行中，success表示成功，fail表示失败
        ///</summary>
        public string TaskStatus{ get; set; }
        ///<summary>
        /// 任务执行百分比
        ///</summary>
        public int? ProgressPercent{ get; set; }
        ///<summary>
        /// 执行时长（单位：秒）
        ///</summary>
        public int? ElapsedTimeSecond{ get; set; }
        ///<summary>
        /// 启动时间（ISO 8601标准的UTC时间，格式为：YYYY-MM-DDTHH:mm:ssZ）
        ///</summary>
        public DateTime? StartTime{ get; set; }
    }
}
