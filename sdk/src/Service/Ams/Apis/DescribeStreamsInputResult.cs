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
 * 应用管理平台API (仅对授权用户使用)
 * 应用管理平台API
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

using JDCloudSDK.Ams.Model;

namespace  JDCloudSDK.Ams.Apis
{

    /// <summary>
    ///  获取收流基础数据查询
    /// </summary>
    public class DescribeStreamsInputResult : JdcloudResult
    {
        ///<summary>
        /// Input数据集合
        ///</summary>
        public List<StreamInputData> StreamInputDatas{ get; set; }

    }
}