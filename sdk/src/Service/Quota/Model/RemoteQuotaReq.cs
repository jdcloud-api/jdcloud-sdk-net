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
 * JDCLOUD remote quota API
 * API JDCLOUD remote quota API
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Quota.Model
{

    /// <summary>
    ///  remoteQuotaReq
    /// </summary>
    public class RemoteQuotaReq
    {

        ///<summary>
        /// Id
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        /// 用户pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// 业务线
        ///</summary>
        public string AppCode{ get; set; }
        ///<summary>
        /// 资源类型
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 一级资源serviceCode
        ///</summary>
        public string ParentCode{ get; set; }
        ///<summary>
        /// 所属地域
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 资源id,私有网络
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// 修改后配额
        ///</summary>
        public int? UserQuota{ get; set; }
        ///<summary>
        /// 修改原因
        ///</summary>
        public string Reason{ get; set; }
        ///<summary>
        /// 过期时间
        ///</summary>
        public DateTime? ExpireTime{ get; set; }
        ///<summary>
        /// 修改配额时间
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
        ///<summary>
        /// 扩展字段，json格式字符串
        ///</summary>
        public string ExtraInfo{ get; set; }
    }
}
