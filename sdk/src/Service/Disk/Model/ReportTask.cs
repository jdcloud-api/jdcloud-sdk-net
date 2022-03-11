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


namespace JDCloudSDK.Disk.Model
{

    /// <summary>
    ///  reportTask
    /// </summary>
    public class ReportTask
    {

        ///<summary>
        /// 任务ID
        ///</summary>
        public string TaskId{ get; set; }
        ///<summary>
        /// 文件名
        ///</summary>
        public string Filename{ get; set; }
        ///<summary>
        /// 状态。0：执行中；3：完成；4：失败
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreatedAt{ get; set; }
        ///<summary>
        /// 下载链接
        ///</summary>
        public string DownloadUrl{ get; set; }
    }
}
