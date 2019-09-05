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
    ///  获取图片上传地址和凭证请求
    /// </summary>
    public class CreateImageUploadTaskRequestObject
    {

        ///<summary>
        /// HTTP 请求方法，取值范围：GET、POST、PUT、DELETE、HEAD、PATCH，默认值为 PUT
        ///</summary>
        public string HttpMethod{ get; set; }
        ///<summary>
        /// 文件名称
        ///</summary>
        public string FileName{ get; set; }
        ///<summary>
        /// 文件大小
        ///</summary>
        public long? FileSize{ get; set; }
    }
}
