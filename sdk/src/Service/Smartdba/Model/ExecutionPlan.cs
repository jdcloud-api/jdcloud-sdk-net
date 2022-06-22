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


namespace JDCloudSDK.Smartdba.Model
{

    /// <summary>
    ///  executionPlan
    /// </summary>
    public class ExecutionPlan
    {

        ///<summary>
        /// sql执行顺序id
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// select语句类型
        ///</summary>
        public string SelectType{ get; set; }
        ///<summary>
        /// 表名
        ///</summary>
        public string Table{ get; set; }
        ///<summary>
        /// 匹配的分区
        ///</summary>
        public string Partitions{ get; set; }
        ///<summary>
        /// 访问行的类型
        ///</summary>
        public string AccessType{ get; set; }
        ///<summary>
        /// 可能选用的索引
        ///</summary>
        public string PossibleKeys{ get; set; }
        ///<summary>
        /// 确切使用到的索引
        ///</summary>
        public string Key{ get; set; }
        ///<summary>
        /// 表示索引中使用的字节数
        ///</summary>
        public string KeyLen{ get; set; }
        ///<summary>
        /// 哪个字段或常数与 key 一起被使用
        ///</summary>
        public string Ref{ get; set; }
        ///<summary>
        /// 一共扫描了多少行. 是一个估计值
        ///</summary>
        public string Rows{ get; set; }
        ///<summary>
        /// 此查询条件所过滤的数据的百分比
        ///</summary>
        public string Filtered{ get; set; }
        ///<summary>
        /// 额外的信息
        ///</summary>
        public string Extra{ get; set; }
    }
}