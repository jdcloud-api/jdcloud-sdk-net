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


namespace JDCloudSDK.Lb.Model
{

    /// <summary>
    ///  updateListenerSpec
    /// </summary>
    public class UpdateListenerSpec
    {

        ///<summary>
        /// 监听器名称,只允许输入中文、数字、大小写字母、英文下划线“_”及中划线“-”，不允许为空且不超过32字符
        ///</summary>
        public string ListenerName{ get; set; }
        ///<summary>
        /// Listener状态, 取值为On或者为Off
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 【alb Https和Tls协议】ssl server证书列表，现只支持一个证书
        ///</summary>
        public List<CertificateSpec> CertificateSpecs{ get; set; }
        ///<summary>
        /// 【alb、nlb】空闲连接超时时间, 范围为[1,86400]。 &lt;br&gt;（Tcp和Tls协议）默认为：1800s &lt;br&gt;（Http和Https协议）默认为：60s &lt;br&gt;【dnlb】不支持该功能
        ///</summary>
        public int? ConnectionIdleTimeSeconds{ get; set; }
        ///<summary>
        /// 默认后端服务Id
        ///</summary>
        public string BackendId{ get; set; }
        ///<summary>
        /// 【alb Https和Http协议】转发规则组Id
        ///</summary>
        public string UrlMapId{ get; set; }
        ///<summary>
        /// 监听器描述,允许输入UTF-8编码下的全部字符，不超过256字符
        ///</summary>
        public string Description{ get; set; }
    }
}
