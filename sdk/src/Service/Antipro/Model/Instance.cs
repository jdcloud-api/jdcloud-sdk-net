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


namespace JDCloudSDK.Antipro.Model
{

    /// <summary>
    ///  instance
    /// </summary>
    public class Instance
    {

        ///<summary>
        /// 防护包实例 Id
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 防护包实例名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 防护包实例地域
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 套餐类型. &lt;br&gt;- 1: 独享 IP&lt;br&gt;- 2: 共享 IP
        ///</summary>
        public int? Type{ get; set; }
        ///<summary>
        /// 可防护 IP 个数
        ///</summary>
        public int? IpCount{ get; set; }
        ///<summary>
        /// 可添加的访问控制规则数量
        ///</summary>
        public int? AclLimit{ get; set; }
        ///<summary>
        /// 保底带宽, 单位 Gbps
        ///</summary>
        public int? BasicBandwidth{ get; set; }
        ///<summary>
        /// 弹性带宽, 单位 Gbps
        ///</summary>
        public int? ElasticBandwidth{ get; set; }
        ///<summary>
        /// 实例过期时间
        ///</summary>
        public string ExpireTime{ get; set; }
        ///<summary>
        /// 实例创建时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 防护对象
        ///</summary>
        public List<ProtectedObject> ProtectedObjects{ get; set; }
        ///<summary>
        /// 是否为试用防护包
        ///</summary>
        public bool OnTrial{ get; set; }
        ///<summary>
        /// 资源 Id
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// Tag信息
        ///</summary>
        public List<Tag> Tags{ get; set; }
    }
}
