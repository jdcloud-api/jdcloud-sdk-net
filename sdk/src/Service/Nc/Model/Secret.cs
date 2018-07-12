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


namespace JDCloudSDK.Nc.Model
{

    /// <summary>
    ///  机密数据
    /// </summary>
    public class Secret
    {

        ///<summary>
        /// 机密数据名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 私密数据的类型，目前仅支持如下类型：docker-registry：用来和docker registry认证的类型
        ///</summary>
        public string Type{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreatedAt{ get; set; }
        ///<summary>
        /// 机密的数据
        ///</summary>
        public DockerRegistryData Data{ get; set; }
    }
}
