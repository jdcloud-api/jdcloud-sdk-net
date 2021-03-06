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


namespace JDCloudSDK.Ssl.Model
{

    /// <summary>
    ///  recordListDetail
    /// </summary>
    public class RecordListDetail
    {

        ///<summary>
        /// 证书申购记录Id
        ///</summary>
        public string RecordId{ get; set; }
        ///<summary>
        /// 交易系统订单Id
        ///</summary>
        public string OrderId{ get; set; }
        ///<summary>
        /// 证书绑定域名
        ///</summary>
        public string CommonName{ get; set; }
        ///<summary>
        /// 证书供应商
        ///</summary>
        public string Supplier{ get; set; }
        ///<summary>
        /// 证书品牌
        ///</summary>
        public string Brand{ get; set; }
        ///<summary>
        /// 证书类型
        ///</summary>
        public string CertType{ get; set; }
        ///<summary>
        /// 证书年限
        ///</summary>
        public int? CertValidity{ get; set; }
        ///<summary>
        /// 证书状态,1:未支付,2:待补全信息,3:待下单,4:待域名验证,5:已完成,6:审核不通过,7:已取消
        ///</summary>
        public int? State{ get; set; }
        ///<summary>
        /// 厂商订单ID
        ///</summary>
        public string PartnerOrderId{ get; set; }
        ///<summary>
        /// 购买域名数量
        ///</summary>
        public int? DomainCount{ get; set; }
        ///<summary>
        /// 购买泛域名数量
        ///</summary>
        public int? WildcardDomainCount{ get; set; }
        ///<summary>
        /// 备用域名
        ///</summary>
        public List<string> DnsNames{ get; set; }
        ///<summary>
        /// 证书Id
        ///</summary>
        public string CertId{ get; set; }
    }
}
