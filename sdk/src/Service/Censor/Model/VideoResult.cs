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
 * 视频检测相关接口
 * API related to video scan
 *
 * OpenAPI spec version: v1
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
    ///  videoResult
    /// </summary>
    public class VideoResult
    {

        ///<summary>
        /// 错误码，和HTTP的status code一致
        ///</summary>
        public int? Code{ get; set; }
        ///<summary>
        /// 错误描述信息
        ///</summary>
        public string Msg{ get; set; }
        ///<summary>
        /// 对应请求的dataId
        ///</summary>
        public string DataId{ get; set; }
        ///<summary>
        /// 该检测任务的ID
        ///</summary>
        public string TaskId{ get; set; }
        ///<summary>
        /// 对应请求中的url
        ///</summary>
        public string Url{ get; set; }
        ///<summary>
        /// 返回结果。调用成功时（code&#x3D;200），返回结果中包含一个或多个元素。每个元素是个结构体，具体结构描述见VideoResultDetail
        ///</summary>
        public List<VideoResultDetail> Results{ get; set; }
        ///<summary>
        /// 视频语音检测结果。具体结构描述见audioScanResult。
        ///</summary>
        public List<AudioResultDetail> AudioResults{ get; set; }
    }
}
