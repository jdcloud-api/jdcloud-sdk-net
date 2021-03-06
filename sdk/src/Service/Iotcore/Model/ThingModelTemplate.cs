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


namespace JDCloudSDK.Iotcore.Model
{

    /// <summary>
    ///  thingModelTemplate
    /// </summary>
    public class ThingModelTemplate
    {

        ///<summary>
        /// 物模型模板ID
        ///</summary>
        public string ThingModelTemplateId{ get; set; }
        ///<summary>
        /// 模型模板名称
        ///</summary>
        public string ThingModelTemplateName{ get; set; }
        ///<summary>
        /// 产品分类名称数组，索引0为一级产品分类名称
        ///</summary>
        public List<string> ProductCategoryNames{ get; set; }
        ///<summary>
        /// 产品分类ID数组，索引0为一级产品分类ID
        ///</summary>
        public List<string> ProductCategoryIds{ get; set; }
        ///<summary>
        /// 更新时间，时间为东八区（UTC/GMT+08:00）
        ///</summary>
        public long? UpdatedTime{ get; set; }
        ///<summary>
        /// 操作人
        ///</summary>
        public string UserPin{ get; set; }
        ///<summary>
        /// 物模型文件在oss上的存储路径
        ///</summary>
        public string OssPath{ get; set; }
    }
}
