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
 * Domain
 * Domain API
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Waf.Model;

namespace  JDCloudSDK.Waf.Apis
{

    /// <summary>
    ///  获取域名防护配置
    /// </summary>
    public class GetDomainAntiConfigResult : JdcloudResult
    {
        ///<summary>
        /// 域名
        ///</summary>
        public   string Domain{ get; set; }
        ///<summary>
        /// waf状态 1表示关闭waf
        ///</summary>
        public   int? DisableWaf{ get; set; }
        ///<summary>
        /// 网站waf防护配置
        ///</summary>
        public   AclConf AclConf{ get; set; }
        ///<summary>
        /// 网站防爬虫防护配置
        ///</summary>
        public   EnableConf AntispiderConf{ get; set; }
        ///<summary>
        /// 网站cc防护配置
        ///</summary>
        public   CcConf CcConf{ get; set; }
        ///<summary>
        /// 网站黑名单防护配置
        ///</summary>
        public   DenyConf DenyConf{ get; set; }
        ///<summary>
        /// 网站智能语义引擎防护配置
        ///</summary>
        public   IntSemConf IntSemConf{ get; set; }
        ///<summary>
        /// 网站恶意ip防护配置
        ///</summary>
        public   IpbanConf IpbanConf{ get; set; }
        ///<summary>
        /// 网站限速规则防护配置
        ///</summary>
        public   RatelimitConf RatelimitConf{ get; set; }
        ///<summary>
        /// 网站威胁情报防护配置
        ///</summary>
        public   EnableConf ThreatinfoConf{ get; set; }
        ///<summary>
        /// 网站自定义页面配置
        ///</summary>
        public   UserDefPageConf UserDefPageConf{ get; set; }
        ///<summary>
        /// 网站waf防护配置
        ///</summary>
        public   WafConf WafConf{ get; set; }
        ///<summary>
        /// 网站web自定义规则防护配置
        ///</summary>
        public   WebUserdefConf WebUserdefConf{ get; set; }
        ///<summary>
        /// 网站防篡改防护配置
        ///</summary>
        public   EnableConf WebcacheConf{ get; set; }
        ///<summary>
        /// 网站白名单防护配置
        ///</summary>
        public   SkipConf SkipConf{ get; set; }
        ///<summary>
        /// 网站请求头管理防护配置
        ///</summary>
        public   FilterHeaderConf FilterHeaderConf{ get; set; }
        ///<summary>
        /// 网站敏感信息防护配置
        ///</summary>
        public   FilterSenseConf FilterSenseConf{ get; set; }
        ///<summary>
        /// 状态码修改配置
        ///</summary>
        public   StatusConf StatusConf{ get; set; }
        ///<summary>
        /// 网站uri重写规则配置
        ///</summary>
        public   UriRewriteConf UriRewriteConf{ get; set; }
        ///<summary>
        /// proxy缓存配置
        ///</summary>
        public   EnableConf ProxycacheConf{ get; set; }
        ///<summary>
        /// risk配置
        ///</summary>
        public   EnableConf RiskConf{ get; set; }
    }
}