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


namespace JDCloudSDK.Portal.Model
{

    /// <summary>
    ///  product
    /// </summary>
    public class Product
    {

        ///<summary>
        /// 主键id
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// url
        ///</summary>
        public string Url{ get; set; }
        ///<summary>
        /// 父导航id
        ///</summary>
        public int? ParentNavigationId{ get; set; }
        ///<summary>
        /// 导航id
        ///</summary>
        public int? NavigationId{ get; set; }
        ///<summary>
        /// 修改时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 修改时间
        ///</summary>
        public DateTime? UpdateTime{ get; set; }
        ///<summary>
        /// 语言：中文cn；英文en
        ///</summary>
        public string Lang{ get; set; }
        ///<summary>
        /// 产品数据
        ///</summary>
        public List<ProductTxt> TxtVoList{ get; set; }
    }
}