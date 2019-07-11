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
 * Video Management
 * 视频资源管理相关接口
 *
 * OpenAPI spec version: v1
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
    ///  批量修改视频的条目信息
    /// </summary>
    public class UpdateVideoBulkItem
    {

        ///<summary>
        /// 视频ID
        ///</summary>
        public string VideoId{ get; set; }
        ///<summary>
        /// 视频名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 分类ID
        ///</summary>
        public double? CategoryId{ get; set; }
        ///<summary>
        /// Tags
        ///</summary>
        public List<string> Tags{ get; set; }
        ///<summary>
        /// 封面图地址
        ///</summary>
        public string CoverUrl{ get; set; }
        ///<summary>
        /// 视频描述信息
        ///</summary>
        public string Description{ get; set; }
    }
}
