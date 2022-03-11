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


namespace JDCloudSDK.Baseanti.Model
{

    /// <summary>
    ///  internalAttackLog
    /// </summary>
    public class InternalAttackLog
    {

        ///<summary>
        /// 公网 IP 地址
        ///</summary>
        public string Ip{ get; set; }
        ///<summary>
        /// 攻击记录 ID
        ///</summary>
        public string AttackLogId{ get; set; }
        ///<summary>
        /// 攻击开始时间, UTC 时间, 格式: yyyy-MM-dd&#39;T&#39;HH:mm:ssZ
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 攻击结束时间, UTC 时间, 格式: yyyy-MM-dd&#39;T&#39;HH:mm:ssZ
        ///</summary>
        public string EndTime{ get; set; }
        ///<summary>
        /// normal: 正常, unregister: 未备案, illegalmail: 非法邮件, clean: 超阈值, blackhole: 黑洞
        ///</summary>
        public List<string> AttackStatus{ get; set; }
    }
}
