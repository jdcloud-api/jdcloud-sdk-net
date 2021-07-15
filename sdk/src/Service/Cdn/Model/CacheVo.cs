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


namespace JDCloudSDK.Cdn.Model
{

    /// <summary>
    ///  cacheVo
    /// </summary>
    public class CacheVo
    {

        ///<summary>
        /// 此条配置的权重值, 取值范围为1-10,1最大
        ///</summary>
        public int? Weight{ get; set; }
        ///<summary>
        /// 缓存时间,单位秒
        ///</summary>
        public int? Ttl{ get; set; }
        ///<summary>
        /// 规则内容。其他类型只能以/或者.开头，如/a/b或.jpg
        ///</summary>
        public string Content{ get; set; }
        ///<summary>
        /// 缓存类型
        ///</summary>
        public string CacheType{ get; set; }
        ///<summary>
        /// 缓存配置id
        ///</summary>
        public int? Id{ get; set; }
    }
}
