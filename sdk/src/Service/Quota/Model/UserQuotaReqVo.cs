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
    ///  userQuotaReqVo
    /// </summary>
    public class UserQuotaReqVo
    {

        ///<summary>
        /// 业务线
        ///</summary>
        public string AppCode{ get; set; }
        ///<summary>
        /// 可用配额
        ///</summary>
        public int? AvailableQuota{ get; set; }
        ///<summary>
        /// CountSql
        ///</summary>
        public bool CountSql{ get; set; }
        ///<summary>
        /// 用户该地域该资源下的配额值
        ///</summary>
        public DateTime? ExpireTime{ get; set; }
        ///<summary>
        /// id
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        /// OrderBy
        ///</summary>
        public string OrderBy{ get; set; }
        ///<summary>
        /// PageNum
        ///</summary>
        public int? PageNum{ get; set; }
        ///<summary>
        /// PageSize
        ///</summary>
        public int? PageSize{ get; set; }
        ///<summary>
        /// PageSizeZero
        ///</summary>
        public bool PageSizeZero{ get; set; }
        ///<summary>
        /// 父层id
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// 用户pin
        ///</summary>
        public string Pin{ get; set; }
        ///<summary>
        /// 产品名称
        ///</summary>
        public string ProductName{ get; set; }
        ///<summary>
        /// Reasonable
        ///</summary>
        public bool Reasonable{ get; set; }
        ///<summary>
        /// 地域
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 区域配额
        ///</summary>
        public long? RegionQuota{ get; set; }
        ///<summary>
        /// 资源产品线
        ///</summary>
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 站点类型
        ///</summary>
        public int? SiteType{ get; set; }
        ///<summary>
        /// 已用配额
        ///</summary>
        public int? UsedQuota{ get; set; }
        ///<summary>
        /// 用户该地域该资源下的配额值
        ///</summary>
        public long? UserQuota{ get; set; }
        ///<summary>
        /// 扩展字段，json格式字符串
        ///</summary>
        public string ExtraInfo{ get; set; }
    }
}
