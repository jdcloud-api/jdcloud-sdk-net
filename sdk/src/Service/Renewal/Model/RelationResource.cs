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


namespace JDCloudSDK.Renewal.Model
{

    /// <summary>
    ///  relationResource
    /// </summary>
    public class RelationResource
    {

        ///<summary>
        /// 业务线
        ///</summary>
        public string AppCode{ get; set; }
        ///<summary>
        /// 产品线
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 资源ID
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// 资源名称
        ///</summary>
        public string ResourceName{ get; set; }
        ///<summary>
        /// 地域
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 资源计费类型(CONFIG-按配置,FLOW-按用量,MONTHLY-包年包月)，不传显示全部资源
        ///</summary>
        public string BillingType{ get; set; }
        ///<summary>
        /// 资源到期时间
        ///</summary>
        public string ExpireTime{ get; set; }
        ///<summary>
        /// 倒计时
        ///</summary>
        public int? LastTime{ get; set; }
        ///<summary>
        /// 自动续费状态(UNOPENED-未开通,OPENED-已开通)
        ///</summary>
        public string AutoRenewStatus{ get; set; }
        ///<summary>
        /// 扩展字段，包括数据库类型、资源特殊说明等
        ///</summary>
        public string ExtendField{ get; set; }
    }
}
