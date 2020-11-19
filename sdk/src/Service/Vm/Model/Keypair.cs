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


namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  keypair
    /// </summary>
    public class Keypair
    {

        ///<summary>
        /// 密钥对名称
        ///</summary>
        public string KeyName{ get; set; }
        ///<summary>
        /// 密钥对的指纹，根据 RFC4716 定义的公钥指纹格式，采用 MD5 信息摘要算法。
        ///</summary>
        public string KeyFingerprint{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 绑定了此密钥的所有虚机id
        ///</summary>
        public List<string> InstanceIds{ get; set; }
    }
}
