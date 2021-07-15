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
    ///  qualityResultDetail
    /// </summary>
    public class QualityResultDetail
    {

        ///<summary>
        /// 图片基本信息
        ///</summary>
        public List<MetaInfoItem> MetaInfo{ get; set; }
        ///<summary>
        /// 美观度分数，0-1，分数越高美观度越高，建议0.5分以上可认为美观度较好，0.3分以下可认为美观度较差，具体视业务场景而定
        ///</summary>
        public float? AestheticsRate{ get; set; }
        ///<summary>
        /// 清晰度分数，0-1，分数越高清晰度越高，建议0.5分以上可认为清晰度较好，0.3分以下可认为清晰度较差，具体视业务场景而定
        ///</summary>
        public float? SharpnessRate{ get; set; }
        ///<summary>
        /// 图片边框信息
        ///</summary>
        public List<BoarderInfoItem> BoarderInfo{ get; set; }
        ///<summary>
        /// 图片边框信息
        ///</summary>
        public List<BackgroundInfoItem> BackgroundInfo{ get; set; }
    }
}
