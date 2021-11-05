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


namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  oneClickAlarm
    /// </summary>
    public class OneClickAlarm
    {

        ///<summary>
        /// 一键报警规则ID
        ///</summary>
        public string AlarmId{ get; set; }
        ///<summary>
        /// 一键告警规则配置
        /// in: body
        ///</summary>
        public List<OneClickAlarmOption> AlarmOptions{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 是否开启, 1表示打开，0表示关闭
        ///</summary>
        public long? Enabled{ get; set; }
        ///<summary>
        /// 是否由系统规则刚刚创建的，0代表是刚刚创建的，1代表由用户操作过的
        ///</summary>
        public long? Indeed{ get; set; }
        ///<summary>
        /// 产品线标识
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 产品线名称
        ///</summary>
        public string ServiceName{ get; set; }
        ///<summary>
        /// 更新时间
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
    }
}