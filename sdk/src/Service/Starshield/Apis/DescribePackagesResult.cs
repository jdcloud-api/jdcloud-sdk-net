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
 * 套餐包管理模块
 * 套餐包管理模块
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

using JDCloudSDK.Starshield.Model;

namespace  JDCloudSDK.Starshield.Apis
{

    /// <summary>
    ///  套餐包列表查询
    /// </summary>
    public class DescribePackagesResult : JdcloudResult
    {
        ///<summary>
        /// 套餐实例信息列表
        ///</summary>
        public List<DescribePackRes> DataList{ get; set; }

        ///<summary>
        /// 当前页记录数量
        ///</summary>
        public   int? CurrentCount{ get; set; }
        ///<summary>
        /// 总记录数量
        ///</summary>
        public   int? TotalCount{ get; set; }
        ///<summary>
        /// 总页数
        ///</summary>
        public   int? TotalPage{ get; set; }
    }
}