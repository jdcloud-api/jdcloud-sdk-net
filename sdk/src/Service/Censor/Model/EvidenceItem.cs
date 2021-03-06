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


namespace JDCloudSDK.Censor.Model
{

    /// <summary>
    ///  evidenceItem
    /// </summary>
    public class EvidenceItem
    {

        ///<summary>
        /// 证据开始相对时间，单位为毫秒，调用方获取后可自行格式化为可视化时间，如：149000 转换为&quot;00:02:29&quot;
        ///</summary>
        public int? BeginTime{ get; set; }
        ///<summary>
        /// 证据结束相对时间，单位为毫秒，调用方获取后可自行格式化为可视化时间，如：149000 转换为&quot;00:02:29&quot;
        ///</summary>
        public int? EndTime{ get; set; }
        ///<summary>
        /// 1：图片，2：视频
        ///</summary>
        public int? Type{ get; set; }
        ///<summary>
        /// 证据信息
        ///</summary>
        public string Url{ get; set; }
        ///<summary>
        /// 审核来源，0：京东人审，1：客户人审，2：京东机审
        ///</summary>
        public int? CensorSource{ get; set; }
        ///<summary>
        /// 证据结果数组
        ///</summary>
        public List<AntispamLabelItem> Labels{ get; set; }
        ///<summary>
        /// 关联信息-命中前截图信息
        ///</summary>
        public List<FrontPicsItem> FrontPics{ get; set; }
        ///<summary>
        /// 关联信息-命中后截图信息
        ///</summary>
        public List<BackPicsItem> BackPics{ get; set; }
    }
}
