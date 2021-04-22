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


namespace JDCloudSDK.Jdccs.Model
{

    /// <summary>
    ///  报警规则
    /// </summary>
    public class DescribeAlarm
    {

        ///<summary>
        /// 规则实例ID
        ///</summary>
        public string AlarmId{ get; set; }
        ///<summary>
        /// 规则名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 机房英文标识
        ///</summary>
        public string Idc{ get; set; }
        ///<summary>
        /// 机房名称
        ///</summary>
        public string IdcName{ get; set; }
        ///<summary>
        /// 资源类型 bandwidth:带宽
        ///</summary>
        public string ResourceType{ get; set; }
        ///<summary>
        /// 资源ID
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// 资源名称
        ///</summary>
        public string ResourceName{ get; set; }
        ///<summary>
        /// 监控项英文标识
        ///</summary>
        public string Metric{ get; set; }
        ///<summary>
        /// 监控项名称
        ///</summary>
        public string MetricName{ get; set; }
        ///<summary>
        /// 统计周期（单位：分钟）
        ///</summary>
        public int? Period{ get; set; }
        ///<summary>
        /// 统计方法：平均值&#x3D;avg、最大值&#x3D;max、最小值&#x3D;min
        ///</summary>
        public string StatisticMethod{ get; set; }
        ///<summary>
        /// 计算方式 &gt;&#x3D;、&gt;、&lt;、&lt;&#x3D;、&#x3D;、！&#x3D;
        ///</summary>
        public string Operator{ get; set; }
        ///<summary>
        /// 阈值
        ///</summary>
        public double? Threshold{ get; set; }
        ///<summary>
        /// 连续多少次后报警
        ///</summary>
        public int? Times{ get; set; }
        ///<summary>
        /// 通知周期 单位：小时
        ///</summary>
        public int? NoticePeriod{ get; set; }
        ///<summary>
        /// 规则状态 disabled:禁用 enabled:启用
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 交换机信息
        ///</summary>
        public List<Switchboard> Switchboard{ get; set; }
        ///<summary>
        /// 通知对象用户ID,若多个用逗号分隔
        ///</summary>
        public string UserId{ get; set; }
        ///<summary>
        /// 通知对象组ID
        ///</summary>
        public string GroupId{ get; set; }
    }
}
