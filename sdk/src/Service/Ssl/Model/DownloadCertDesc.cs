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
    ///  downloadCertDesc
    /// </summary>
    public class DownloadCertDesc
    {

        ///<summary>
        /// 证书Id
        ///</summary>
        public string CertId{ get; set; }
        ///<summary>
        /// 证书名称
        ///</summary>
        public string CertName{ get; set; }
        ///<summary>
        /// 私钥
        ///</summary>
        public string KeyFile{ get; set; }
        ///<summary>
        /// 证书
        ///</summary>
        public string CertFile{ get; set; }
        ///<summary>
        /// 对私钥文件使用sha256算法计算的摘要信息
        ///</summary>
        public string Digest{ get; set; }
        ///<summary>
        /// 中间证书
        ///</summary>
        public string CaCertFile{ get; set; }
        ///<summary>
        /// 证书应用服务器类型
        ///</summary>
        public string ServerType{ get; set; }
        ///<summary>
        /// 证书加密密码
        ///</summary>
        public string CertEncryptePassword{ get; set; }
        ///<summary>
        /// 域名
        ///</summary>
        public string CommonName{ get; set; }
    }
}
