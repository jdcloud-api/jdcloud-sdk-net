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


namespace JDCloudSDK.Live.Model
{

    /// <summary>
    ///  file
    /// </summary>
    public class File
    {

        ///<summary>
        /// 推流域名
        ///</summary>
        public string PublishDomain{ get; set; }
        ///<summary>
        /// 应用名称
        ///</summary>
        public string AppName{ get; set; }
        ///<summary>
        /// 流名称
        ///</summary>
        public string StreamName{ get; set; }
        ///<summary>
        /// 开始时间
        /// - UTC时间
        ///   格式:yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        ///   示例:2018-10-21T10:00:00Z
        /// 
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 结束时间
        /// - UTC时间
        ///   格式:yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;
        ///   示例:2018-10-21T10:00:00Z
        /// 
        ///</summary>
        public string EndTime{ get; set; }
        ///<summary>
        /// 录制时长
        ///</summary>
        public long? Duration{ get; set; }
        ///<summary>
        /// 视频高
        ///</summary>
        public int? Height{ get; set; }
        ///<summary>
        /// 视频宽
        ///</summary>
        public int? Width{ get; set; }
        ///<summary>
        /// OSSBucket的名称
        ///</summary>
        public string OssBucket{ get; set; }
        ///<summary>
        /// OSSEndpoint域名
        ///</summary>
        public string OssEndpoint{ get; set; }
        ///<summary>
        /// OSSObject
        ///</summary>
        public string OssObject{ get; set; }
    }
}
