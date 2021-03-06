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
 * Monitoring Rules APIs
 * 云监控规则相关接口，提供创建、查询、修改、删除监控规则等功能
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Monitor.Model;

namespace  JDCloudSDK.Monitor.Apis
{

    /// <summary>
    ///  查询规则列表
    /// </summary>
    public class DescribeAlarmsRequest : JdcloudRequest
    {
        ///<summary>
        /// 当前所在页，默认为1
        ///</summary>
        public   long? PageNumber{ get; set; }
        ///<summary>
        /// 页面大小，默认为20；取值范围[1, 100]
        ///</summary>
        public   long? PageSize{ get; set; }
        ///<summary>
        /// 数据所有者，1云监控控制台; 2云鼎。默认为1
        ///</summary>
        public   long? DataOwner{ get; set; }
        ///<summary>
        /// 产品线标识，同一个产品线下可能存在多个product，如(redis下有redis2.8cluster、redis4.0)
        ///</summary>
        public   string ServiceCode{ get; set; }
        ///<summary>
        /// 产品标识，如redis下分多个产品(redis2.8cluster、redis4.0)。同时指定serviceCode与product时，product优先生效
        ///</summary>
        public   string Product{ get; set; }
        ///<summary>
        /// 产品下的维度标识，指定dimension时必须指定product
        ///</summary>
        public   string Dimension{ get; set; }
        ///<summary>
        /// 规则名称
        ///</summary>
        public   string RuleName{ get; set; }
        ///<summary>
        /// 规则类型, 1表示资源监控，6表示站点监控,7表示可用性监控
        ///</summary>
        public   long? RuleType{ get; set; }
        ///<summary>
        /// 规则状态：1为启用，0为禁用
        ///</summary>
        public   long? Enabled{ get; set; }
        ///<summary>
        /// 资源的规则状态  2：报警、4：数据不足
        ///</summary>
        public   long? RuleStatus{ get; set; }
        ///<summary>
        /// 服务码或资源Id列表
        /// products - 产品product，精确匹配，支持多个
        /// resourceIds - 资源Id，精确匹配，支持多个（必须指定serviceCode、product或dimension，否则该参数不生效）
        /// alarmIds - 规则id，精确匹配，支持多个
        ///</summary>
        public List<Filter> Filters{ get; set; }

    }
}