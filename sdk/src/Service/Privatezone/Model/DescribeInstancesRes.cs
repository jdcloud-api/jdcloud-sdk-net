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


namespace JDCloudSDK.Privatezone.Model
{

    /// <summary>
    ///  describeInstancesRes
    /// </summary>
    public class DescribeInstancesRes
    {

        ///<summary>
        /// 实例ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public string InstanceName{ get; set; }
        ///<summary>
        /// 套餐类型
        ///</summary>
        public string PackType{ get; set; }
        ///<summary>
        /// zone数量
        ///</summary>
        public int? ZoneNum{ get; set; }
        ///<summary>
        /// 绑定vpc数量
        ///</summary>
        public int? BindVpcNum{ get; set; }
        ///<summary>
        /// zone级别
        ///</summary>
        public int? ZoneLevel{ get; set; }
        ///<summary>
        /// 解析记录数量
        ///</summary>
        public int? RrNum{ get; set; }
        ///<summary>
        /// 域名等级
        ///</summary>
        public int? DomainLevel{ get; set; }
        ///<summary>
        /// 导出解析记录权限
        ///</summary>
        public bool RrAuthorExport{ get; set; }
        ///<summary>
        /// 购买时长
        ///</summary>
        public int? Duration{ get; set; }
        ///<summary>
        /// 时长单位（YEAR-&gt;年）
        ///</summary>
        public string DurationUnit{ get; set; }
        ///<summary>
        /// 到期时间, UTC时间格式，例如2017-11-10T23:00:00Z
        ///</summary>
        public string ExpireTime{ get; set; }
        ///<summary>
        /// 计费状态（NORMAL-&gt;正常 EXPIRE-&gt;到期 DELETED-&gt;已删除）
        ///</summary>
        public string ChargeStutas{ get; set; }
        ///<summary>
        /// 已使用zone数量
        ///</summary>
        public int? UsedZoneNum{ get; set; }
    }
}
