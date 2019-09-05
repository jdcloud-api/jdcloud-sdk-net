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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Resourcetag.Model
{

    /// <summary>
    ///  resourcesMap
    /// </summary>
    public class ResourcesMap
    {

        ///<summary>
        /// 产品线名称列表
        /// 标签系统支持的产品线名称如下
        /// - vm               disk        sqlserver  es          mongodb               ip
        /// - memcached        redis       drds       rds         database              db_ro
        /// - percona          percona_ro  mariadb    mariadb_ro  pg                    cdn
        /// - nativecontainer  pod         zfs        jqs         kubernetesNodegroup   jcq
        /// 
        ///Required:true
        ///</summary>
        [Required]
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 资源id列表
        ///Required:true
        ///</summary>
        [Required]
        public List<string> ResourceId{ get; set; }
    }
}
