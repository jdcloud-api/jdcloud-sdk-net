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
 * ES Dictionary API
 * es自定义词典上传、删除、查询接口
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


namespace  JDCloudSDK.Es.Apis
{

    /// <summary>
    ///  获取es实例已上传的字典文件名
    /// </summary>
    public class DescribeDictsResult : JdcloudResult
    {
        ///<summary>
        /// 主分词文件名
        ///</summary>
        public   string ExtDict{ get; set; }
        ///<summary>
        /// 停用词文件名
        ///</summary>
        public   string ExtStopwords{ get; set; }
        ///<summary>
        /// 字典状态。上传成功为&#39;using&#39;，上传失败不记录
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// 更新时间，遵循ISO8601标准，使用UTC时间，格式为：YYYY-MM-DDTHH:mm:ssZ
        ///</summary>
        public   string UpdateTime{ get; set; }
    }
}