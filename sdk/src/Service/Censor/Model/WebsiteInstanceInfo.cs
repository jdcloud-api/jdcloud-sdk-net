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


namespace JDCloudSDK.Censor.Model
{

    /// <summary>
    ///  websiteInstanceInfo
    /// </summary>
    public class WebsiteInstanceInfo
    {

        ///<summary>
        /// 实例ID
        ///</summary>
        public string WebsiteInstanceId{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public string NickName{ get; set; }
        ///<summary>
        /// 协议，http或https
        ///</summary>
        public string Scheme{ get; set; }
        ///<summary>
        /// 域名，不含协议
        ///</summary>
        public string Host{ get; set; }
        ///<summary>
        /// 全站检测频率，1d-1天，7d-7天
        ///</summary>
        public string HostInterval{ get; set; }
        ///<summary>
        /// 首页检测间隔，eg:1h表示一小时，必须为整小时
        ///</summary>
        public string HomePageInterval{ get; set; }
        ///<summary>
        /// 创建时间，秒级时间戳
        ///</summary>
        public int? CreateAt{ get; set; }
        ///<summary>
        /// 到期时间，秒级时间戳
        ///</summary>
        public int? ExpireAt{ get; set; }
        ///<summary>
        /// 实例状态，0-未绑定，1-正常，2-绑定未验证，3-绑定已验证，4-停止
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 0-不可用，1-可用
        ///</summary>
        public int? Valid{ get; set; }
        ///<summary>
        /// 计费状态，INIT-初始化，START-启用，ARREARAGE_STOP-正常，ARREARAGE_STOP-欠费停服，ARREARAGE_DESTROY-欠费删除，EXPIRE_STOP-过期停服，EXPIRE_DESTROY-过期删除，USER_DESTROY-订单取消，ADMIN_DESTROY-管理员删除
        ///</summary>
        public string ChargeStatus{ get; set; }
        ///<summary>
        /// 首页防篡改设置状态，0-未设置，1-设置
        ///</summary>
        public int? HomePageCacheStatus{ get; set; }
    }
}
