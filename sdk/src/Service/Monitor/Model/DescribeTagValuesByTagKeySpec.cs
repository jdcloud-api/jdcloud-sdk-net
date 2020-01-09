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


namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  describeTagValuesByTagKeySpec
    /// </summary>
    public class DescribeTagValuesByTagKeySpec
    {

        ///<summary>
        /// 要搜索的dimensionValue前缀
        ///</summary>
        public string DimensionValue{ get; set; }
        ///<summary>
        /// 监控指标数据的维度信息,根据tags来筛选指标数据不同的维度
        ///</summary>
        public List<TagFilter> Tags{ get; set; }
    }
}