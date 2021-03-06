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
    ///  recordDescDetail
    /// </summary>
    public class RecordDescDetail
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
        /// 证书名称
        ///</summary>
        public string CertName{ get; set; }
        ///<summary>
        /// 证书品牌
        ///</summary>
        public string Brand{ get; set; }
        ///<summary>
        /// 证书类型
        ///</summary>
        public string CertType{ get; set; }
        ///<summary>
        /// 域名的个数
        ///</summary>
        public int? DomainCount{ get; set; }
        ///<summary>
        /// 泛域名的个数
        ///</summary>
        public int? WildcardDomainCount{ get; set; }
        ///<summary>
        /// 证书年限
        ///</summary>
        public int? CertValidity{ get; set; }
        ///<summary>
        /// 证书绑定域名
        ///</summary>
        public string CommonName{ get; set; }
        ///<summary>
        /// 证书状态,1:未支付,2:待补全信息,3:待下单,4:待域名验证,5:已完成,6:审核不通过,7:已取消
        ///</summary>
        public int? State{ get; set; }
        ///<summary>
        /// 分销商返回的信息，代表订单被取消的原因
        ///</summary>
        public string CanceledReason{ get; set; }
        ///<summary>
        /// RecordValidate
        ///</summary>
        public RecordValidate RecordValidate{ get; set; }
        ///<summary>
        /// 公司名称
        ///</summary>
        public string CorpName{ get; set; }
        ///<summary>
        /// 公司地址
        ///</summary>
        public string CorpAddr{ get; set; }
        ///<summary>
        /// 备用域名
        ///</summary>
        public List<string> DnsNames{ get; set; }
        ///<summary>
        /// 联系人邮箱
        ///</summary>
        public string Email{ get; set; }
        ///<summary>
        /// 自动DNS验证结果信息
        ///</summary>
        public string ErrorMessage{ get; set; }
    }
}
