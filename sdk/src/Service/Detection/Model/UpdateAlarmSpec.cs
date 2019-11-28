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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Detection.Model
{

    /// <summary>
    ///  updateAlarmSpec
    /// </summary>
    public class UpdateAlarmSpec
    {

        ///<summary>
        /// 弹性伸缩组Id。注：仅ag\asg产品线内部使用
        ///</summary>
        public string AutoScalingPolicyId{ get; set; }
        ///<summary>
        /// 告警通知联系人
        ///</summary>
        public List<BaseContact> BaseContact{ get; set; }
        ///<summary>
        /// 资源维度，可用的维度请使用 describeProductsForAlarm接口查询
        ///</summary>
        public string Dimension{ get; set; }
        ///<summary>
        /// 是否启用, 1表示启用规则，0表示禁用规则，默认为1
        ///</summary>
        public long? Enabled{ get; set; }
        ///<summary>
        /// 通知策略
        ///</summary>
        public List<NoticeOption> NoticeOption{ get; set; }
        ///<summary>
        /// 资源类型, 可用的资源类型列表请使用 describeProductsForAlarm接口查询。
        ///Required:true
        ///</summary>
        [Required]
        public string Product{ get; set; }
        ///<summary>
        /// ResourceOption
        ///Required:true
        ///</summary>
        [Required]
        public ResourceOption ResourceOption{ get; set; }
        ///<summary>
        /// 规则名称，规则名称，最大长度42个字符，只允许中英文、数字、&#39;&#39;-&#39;&#39;和&quot;_&quot;
        ///Required:true
        ///</summary>
        [Required]
        public string RuleName{ get; set; }
        ///<summary>
        /// RuleOption
        ///Required:true
        ///</summary>
        [Required]
        public RuleOption RuleOption{ get; set; }
        ///<summary>
        /// 规则类型, 默认为resourceMonitor
        ///</summary>
        public string RuleType{ get; set; }
        ///<summary>
        /// 资源维度，指定监控数据实例的维度标签,如resourceId&#x3D;id。(请确认资源的监控数据带有该标签，否则规则会报数据不足)
        ///</summary>
        public Dictionary<String,string> Tags{ get; set; }
        ///<summary>
        /// WebHookOption
        ///</summary>
        public WebHookOption WebHookOption{ get; set; }
    }
}
