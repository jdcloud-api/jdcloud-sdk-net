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


namespace JDCloudSDK.Cdn.Model
{

    /// <summary>
    ///  serviceNoticeItem
    /// </summary>
    public class ServiceNoticeItem
    {

        ///<summary>
        /// 服务配置id
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        /// 通知类型,取值[reportForm],reportForm:报表.
        ///</summary>
        public string NoticeType{ get; set; }
        ///<summary>
        /// 通知方式,取值[mail],mail:邮件.
        ///</summary>
        public string NoticeWay{ get; set; }
        ///<summary>
        /// 通知接收人,多个用逗号隔开.
        ///</summary>
        public string NoticeTo{ get; set; }
        ///<summary>
        /// 通知抄送人,多个用逗号隔开.
        ///</summary>
        public string NoticeCC{ get; set; }
        ///<summary>
        /// 通知正文.
        ///</summary>
        public string NoticeContent{ get; set; }
        ///<summary>
        /// 通知周期,取值[daily,weekly,monthly].
        ///</summary>
        public List<string> NoticePeriod{ get; set; }
        ///<summary>
        /// 通知状态，取值[init,start,stop]
        ///</summary>
        public string NoticeStatus{ get; set; }
    }
}
