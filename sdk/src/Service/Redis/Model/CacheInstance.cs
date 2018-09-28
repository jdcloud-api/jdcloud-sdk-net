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

using JDCloudSDK.Charge.Model;

namespace JDCloudSDK.Redis.Model
{

    /// <summary>
    ///  cacheInstance
    /// </summary>
    public class CacheInstance
    {

        ///<summary>
        /// 实例ID
        ///</summary>
        public string CacheInstanceId{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public string CacheInstanceName{ get; set; }
        ///<summary>
        /// 实例规格代码，参见&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/411/isCatalog/1&quot;&gt;实例规格代码&lt;/a&gt;
        ///</summary>
        public string CacheInstanceClass{ get; set; }
        ///<summary>
        /// 容量，单位MB
        ///</summary>
        public int? CacheInstanceMemoryMB{ get; set; }
        ///<summary>
        /// 实例状态，running：运行，error：错误，creating：创建中，changing：变配中，deleting：删除中
        ///</summary>
        public string CacheInstanceStatus{ get; set; }
        ///<summary>
        /// 实例描述
        ///</summary>
        public string CacheInstanceDescription{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// az信息
        ///</summary>
        public AzId AzId{ get; set; }
        ///<summary>
        /// 所属VPC的ID
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 所属子网的ID
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 访问域名
        ///</summary>
        public string ConnectionDomain{ get; set; }
        ///<summary>
        /// 端口
        ///</summary>
        public int? Port{ get; set; }
        ///<summary>
        /// 计费信息
        ///</summary>
        public JDCloudSDK.Charge.Model.Charge Charge{ get; set; }
        ///<summary>
        /// 实例版本
        ///</summary>
        public string InstanceVersion{ get; set; }
        ///<summary>
        /// 是否免密
        ///</summary>
        public bool Auth{ get; set; }
    }
}
