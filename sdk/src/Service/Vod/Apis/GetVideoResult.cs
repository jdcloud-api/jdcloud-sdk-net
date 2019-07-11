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
 * Video
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
using JDCloudSDK.Core.Service;

using JDCloudSDK.Vod.Model;

namespace  JDCloudSDK.Vod.Apis
{

    /// <summary>
    ///  查询单个视频信息
    /// </summary>
    public class GetVideoResult : JdcloudResult
    {
        ///<summary>
        /// 视频ID
        ///</summary>
        public   string Id{ get; set; }
        ///<summary>
        /// 视频名称
        ///</summary>
        public   string Name{ get; set; }
        ///<summary>
        /// 视频描述
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 封面图地址
        ///</summary>
        public   string CoverUrl{ get; set; }
        ///<summary>
        /// 视频状态
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// 文件大小，单位字节
        ///</summary>
        public   long? FileSize{ get; set; }
        ///<summary>
        /// 文件校验和
        ///</summary>
        public   string Checksum{ get; set; }
        ///<summary>
        /// 视频时长
        ///</summary>
        public   long? Duration{ get; set; }
        ///<summary>
        /// 标签
        ///</summary>
        public List<string> Tags{ get; set; }

        ///<summary>
        /// 分类ID
        ///</summary>
        public   long? CategoryId{ get; set; }
        ///<summary>
        /// 分类名称
        ///</summary>
        public   string CategoryName{ get; set; }
        ///<summary>
        /// Snapshots
        ///</summary>
        public List<Snapshot> Snapshots{ get; set; }

        ///<summary>
        /// 创建时间
        ///</summary>
        public   DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 修改时间
        ///</summary>
        public   DateTime? UpdateTime{ get; set; }
    }
}