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


namespace JDCloudSDK.Kubernetes.Model
{

    /// <summary>
    ///  集群子网配置
    /// </summary>
    public class ClusterNetworkSubnet
    {

        ///<summary>
        /// 子网 ID
        ///</summary>
        public string SubnetId{ get; set; }
        ///<summary>
        /// 子网类型，可取值为：pod_subnet/lb_subnet/node_subnet
        ///</summary>
        public string SubnetType{ get; set; }
        ///<summary>
        /// 子网是否启用，仅pod子网可用。
        ///</summary>
        public bool Enabled{ get; set; }
    }
}
