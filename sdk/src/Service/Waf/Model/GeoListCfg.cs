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


namespace JDCloudSDK.Waf.Model
{

    /// <summary>
    ///  geoListCfg
    /// </summary>
    public class GeoListCfg
    {

        ///<summary>
        /// 序号id
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 规则更新时间，秒级时间戳, 0 表示历史数据无记录
        ///</summary>
        public string UpdateTime{ get; set; }
        ///<summary>
        /// 0-使用中 1-禁用
        ///</summary>
        public int? Disable{ get; set; }
        ///<summary>
        /// geo名称 黑名单支持海外和大陆某个省份或直辖市 白名单支持配置大陆省份/城市
        ///</summary>
        public string Geo{ get; set; }
        ///<summary>
        /// action配置
        ///</summary>
        public AtCfg AtCfg{ get; set; }
    }
}