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


namespace JDCloudSDK.Redis.Model
{

    /// <summary>
    ///  clusterInfo对象
    /// </summary>
    public class ClusterInfo
    {

        ///<summary>
        /// 代理列表
        ///</summary>
        public List<Proxy> Proxies{ get; set; }
        ///<summary>
        /// 分片列表
        ///</summary>
        public List<Shard> Shards{ get; set; }
        ///<summary>
        /// redis列表
        ///</summary>
        public List<JDCloudSDK.Redis.Model.Redis> Redis{ get; set; }
    }
}
