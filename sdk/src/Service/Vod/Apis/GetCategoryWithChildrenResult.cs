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
 * Category
 * 分类管理相关接口
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
    ///  查询分类及其子分类，若指定的分类ID为0，则返回一个根分类及其子分类（即一级分类）.
    /// </summary>
    public class GetCategoryWithChildrenResult : JdcloudResult
    {
        ///<summary>
        /// 分类ID
        ///</summary>
        public   long? Id{ get; set; }
        ///<summary>
        /// 分类名称
        ///</summary>
        public   string Name{ get; set; }
        ///<summary>
        /// 分类级别
        ///</summary>
        public   int? Level{ get; set; }
        ///<summary>
        /// 分类描述
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 下级分类
        ///</summary>
        public List<SubCategory> Children{ get; set; }

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