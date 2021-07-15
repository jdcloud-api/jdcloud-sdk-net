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
 * 图片检测相关接口
 * API related to image scan
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
    ///  oCRResult
    /// </summary>
    public class OCRResult
    {

        ///<summary>
        /// 图片名称(或图片标识)
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 图片高度，单位像素
        ///</summary>
        public int? Height{ get; set; }
        ///<summary>
        /// 图片宽度，单位像素
        ///</summary>
        public int? Width{ get; set; }
        ///<summary>
        /// 本次请求数据标识，可以根据该标识查询数据最新结果
        ///</summary>
        public string TaskId{ get; set; }
        ///<summary>
        /// OCR详细信息
        ///</summary>
        public List<OCRResultDetail> Details{ get; set; }
    }
}
