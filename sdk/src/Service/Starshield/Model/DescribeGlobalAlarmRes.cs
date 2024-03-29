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


namespace JDCloudSDK.Starshield.Model
{

    /// <summary>
    ///  describeGlobalAlarmRes
    /// </summary>
    public class DescribeGlobalAlarmRes
    {

        ///<summary>
        /// 告警规则ID
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        /// 告警类型 WEB_ATTACK-&gt;网站攻击 CC_ATTACK-&gt;CC攻击 DDOS_ATTACK-&gt;DDOS攻击 STATUS_CODE_ERROR-&gt;状态码错误
        ///</summary>
        public string AlarmType{ get; set; }
        ///<summary>
        /// 统计周期
        ///</summary>
        public int? StatCycle{ get; set; }
        ///<summary>
        /// 统计周期单位
        ///</summary>
        public string StatCycleUnit{ get; set; }
        ///<summary>
        /// 统计阈值
        ///</summary>
        public long? StatThreshold{ get; set; }
        ///<summary>
        /// 告警次数限制
        ///</summary>
        public int? AlarmTimesLimit{ get; set; }
        ///<summary>
        /// 发送短信开关
        ///</summary>
        public bool SmsEnable{ get; set; }
        ///<summary>
        /// 发送邮件开关
        ///</summary>
        public bool EmailEnable{ get; set; }
        ///<summary>
        /// 发送站内信开关
        ///</summary>
        public bool WebMsEnable{ get; set; }
        ///<summary>
        /// 规则开关
        ///</summary>
        public bool Enable{ get; set; }
        ///<summary>
        /// 告警联系人
        ///</summary>
        public List<long?> ContactUsers{ get; set; }
        ///<summary>
        /// 告警联系组
        ///</summary>
        public List<long?> ContactGroups{ get; set; }
    }
}
