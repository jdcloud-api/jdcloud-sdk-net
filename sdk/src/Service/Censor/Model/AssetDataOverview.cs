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
    ///  assetDataOverview
    /// </summary>
    public class AssetDataOverview
    {

        ///<summary>
        /// 图片检测总数
        ///</summary>
        public long? ImageCount{ get; set; }
        ///<summary>
        /// 图片违规总数
        ///</summary>
        public long? ImageBlockCount{ get; set; }
        ///<summary>
        /// 图片疑似违规总数
        ///</summary>
        public long? ImageReviewCount{ get; set; }
        ///<summary>
        /// 文本总数
        ///</summary>
        public long? TextCount{ get; set; }
        ///<summary>
        /// 文本违规总数
        ///</summary>
        public long? TextBlockCount{ get; set; }
        ///<summary>
        /// 文本疑似违规总数
        ///</summary>
        public long? TextReviewCount{ get; set; }
    }
}
