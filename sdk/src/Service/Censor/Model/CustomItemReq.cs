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

namespace JDCloudSDK.Censor.Model
{

    /// <summary>
    ///  customItemReq
    /// </summary>
    public class CustomItemReq
    {

        ///<summary>
        /// 总条数
        ///Required:true
        ///</summary>
        [Required]
        public int TotalCount{ get; set; }
        ///<summary>
        /// Content
        ///Required:true
        ///</summary>
        [Required]
        public List<string> Content{ get; set; }
        ///<summary>
        /// 文件类型，text-文本，image-图片，audio-音频，video-视频
        ///Required:true
        ///</summary>
        [Required]
        public string ResourceType{ get; set; }
        ///<summary>
        /// 敏感库id
        ///Required:true
        ///</summary>
        [Required]
        public string LibId{ get; set; }
    }
}
