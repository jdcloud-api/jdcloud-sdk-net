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
    ///  videoResultV2
    /// </summary>
    public class VideoResultV2
    {

        ///<summary>
        /// 视频处理状态码，定义为：0：检测成功，110：请求重复，120：参数错误，130：解析错误，140：数据类型错误，160：视频大小超限（&gt;5G）
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 音视频数据请求标识，可以根据该标识查询视频数据最新结果
        ///</summary>
        public string TaskId{ get; set; }
        ///<summary>
        /// 产品提交视频点播信息时带的 callback 字段数据，用于标识视频，产品根据业务情况自行设计
        ///</summary>
        public string Callback{ get; set; }
        ///<summary>
        /// 审核来源，0：京东人审，1：客户人审，2：京东机审
        ///</summary>
        public int? CensorSource{ get; set; }
        ///<summary>
        /// 人工审核完成时间，毫秒单位时间戳(13位)
        ///</summary>
        public double? CensorTime{ get; set; }
        ///<summary>
        /// 视频级别信息，分为0:正常，1：不确定，2：确定，其中不确定的建议人工复审
        ///</summary>
        public int? Level{ get; set; }
        ///<summary>
        /// 证据信息数组，如果数组为空，则表示该视频为正常视频
        ///</summary>
        public List<EvidenceItem> Evidences{ get; set; }
    }
}
