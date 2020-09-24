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


namespace JDCloudSDK.Vod.Model
{

    /// <summary>
    ///  转码作业子任务
    /// </summary>
    public class TransTask
    {

        ///<summary>
        /// 任务ID
        ///</summary>
        public long? TaskId{ get; set; }
        ///<summary>
        /// 转码模板ID
        ///</summary>
        public long? TemplateId{ get; set; }
        ///<summary>
        /// 封装格式
        ///</summary>
        public string Format{ get; set; }
        ///<summary>
        /// 清晰度
        ///</summary>
        public string Definition{ get; set; }
        ///<summary>
        /// 任务状态。
        /// submitted - 已提交
        /// processing - 处理中
        /// succeeded - 处理成功
        /// failed - 处理失败
        /// 
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 处理进度
        ///</summary>
        public int? Progress{ get; set; }
        ///<summary>
        /// 错误码，只有处理失败时，才有此字段
        ///</summary>
        public string ErrorCode{ get; set; }
        ///<summary>
        /// 错误消息，只有处理失败时，才有此字段
        ///</summary>
        public string ErrorMessage{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 完成时间
        ///</summary>
        public DateTime? CompleteTime{ get; set; }
    }
}
