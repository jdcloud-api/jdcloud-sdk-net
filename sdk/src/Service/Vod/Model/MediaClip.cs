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


namespace JDCloudSDK.Vod.Model
{

    /// <summary>
    ///  视频剪辑素材片段信息
    /// </summary>
    public class MediaClip
    {

        ///<summary>
        /// 素材ID，此处，必须为视频点播媒资的视频ID
        ///</summary>
        public string MediaId{ get; set; }
        ///<summary>
        /// 素材片段在媒资中的入点
        ///</summary>
        public int? MediaIn{ get; set; }
        ///<summary>
        /// 素材片段在媒资中的出点
        ///</summary>
        public int? MediaOut{ get; set; }
        ///<summary>
        /// 素材片段在合成时间线中的入点
        ///</summary>
        public int? TimelineIn{ get; set; }
        ///<summary>
        /// 素材片段在合成时间线中的出点
        ///</summary>
        public int? TimelineOut{ get; set; }
        ///<summary>
        /// Operations
        ///</summary>
        public List<ClipOperation> Operations{ get; set; }
    }
}
