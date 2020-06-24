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
using JDCloudSDK.Resourcetag.Model;

namespace JDCloudSDK.Kafka.Model
{

    /// <summary>
    ///  instance
    /// </summary>
    public class Instance
    {

        ///<summary>
        /// 实例ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public string InstanceName{ get; set; }
        ///<summary>
        /// kafka实例版本
        ///</summary>
        public string InstanceVersion{ get; set; }
        ///<summary>
        /// 实例状态，running：运行，error：错误，creating：创建中，changing：变配，stop：停止
        ///</summary>
        public string InstanceStatus{ get; set; }
        ///<summary>
        /// 创建时间，遵循ISO8601标准，使用UTC时间，格式为：YYYY-MM-DDTHH:mm:ssZ
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 所属VPC的ID
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// 所属子网的ID
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// ipVersion，空(代表v4)或者v4&amp;v6
        ///</summary>
        public string IpVersion{ get; set; }
        ///<summary>
        /// azId
        ///</summary>
        public List<string> AzId{ get; set; }
        ///<summary>
        /// 集群规格信息
        ///</summary>
        public List<InstanceClass> InstanceClass{ get; set; }
        ///<summary>
        /// 计费信息
        ///</summary>
        public JDCloudSDK.Charge.Model.Charge Charge{ get; set; }
        ///<summary>
        /// Tag信息
        ///</summary>
        public List<Tag> Tags{ get; set; }
        ///<summary>
        /// 扩展参数
        ///</summary>
        public RespExtension Extension{ get; set; }
    }
}