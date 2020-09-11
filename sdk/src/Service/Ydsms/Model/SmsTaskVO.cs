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


namespace JDCloudSDK.Ydsms.Model
{

    /// <summary>
    ///  smsTaskVO
    /// </summary>
    public class SmsTaskVO
    {

        ///<summary>
        /// 应用id
        ///</summary>
        public string AppId{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 用户pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// 发送手机号
        ///</summary>
        public string SendNumberUrl{ get; set; }
        ///<summary>
        /// 发送时间
        ///</summary>
        public string SendTime{ get; set; }
        ///<summary>
        /// 签名id
        ///</summary>
        public string SignId{ get; set; }
        ///<summary>
        /// 状态 0 未执行 1 以执行
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 任务id
        ///</summary>
        public string TaskId{ get; set; }
        ///<summary>
        /// 任务名称
        ///</summary>
        public string TaskName{ get; set; }
        ///<summary>
        /// 任务类型 1 通道短信  2 官方短信
        ///</summary>
        public int? TaskType{ get; set; }
        ///<summary>
        /// 模板id
        ///</summary>
        public string TemplateId{ get; set; }
    }
}
