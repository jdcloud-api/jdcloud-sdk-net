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


namespace JDCloudSDK.Jdro.Model
{

    /// <summary>
    ///  资源输出参数类型
    /// </summary>
    public class ResourceAttribute
    {

        ///<summary>
        /// 注释
        ///</summary>
        public string Comment{ get; set; }
        ///<summary>
        /// 如果 Type 字段的值为 List 或 Map，则指示列表或映射的类型 (如果它们包含非基元类型)
        ///</summary>
        public string ItemType{ get; set; }
        ///<summary>
        /// 如果 Type 字段的值为 List 或 Map，则指示列表或映射的类型 (如果它们包含基元类型)
        ///</summary>
        public string PrimitiveItemType{ get; set; }
        ///<summary>
        /// 基元类型
        ///</summary>
        public string PrimitiveType{ get; set; }
        ///<summary>
        /// Type
        ///</summary>
        public PropertyItemType Type{ get; set; }
    }
}
