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


namespace JDCloudSDK.Domain.Model
{

    /// <summary>
    ///  addTemplate
    /// </summary>
    public class AddTemplate
    {

        ///<summary>
        /// 联系人姓名(中文),必填,必须含有中文,只允许输入特殊字符(.,、·()()-&quot;&quot;“”/\&#39;),最多可输入64 字符
        ///</summary>
        public string UserNameCh{ get; set; }
        ///<summary>
        /// 联系人姓(英文),必填,必须含有英文,只允许输入特殊字符(.,、·()()-&quot;&quot;“”/\&#39;),最多可输入64 字符
        ///</summary>
        public string UserNameEn1{ get; set; }
        ///<summary>
        /// 联系人名(英文),必填,必须含有英文,只允许输入特殊字符(.,、·()()-&quot;&quot;“”/\&#39;),最多可输入64 字符
        ///</summary>
        public string UserNameEn2{ get; set; }
        ///<summary>
        /// 域名所有者或所有者单位名称(中文),必填,必须含有中文,只允许输入特殊字符(.,、·()()-&quot;&quot;“”/\&#39;),最多可输入64 字符
        ///</summary>
        public string OwnerNameCh{ get; set; }
        ///<summary>
        /// 域名所有者或所有者单位名称(英文),必填,必须含有中文,只允许输入特殊字符(.,、·()()-&quot;&quot;“”/\&#39;),最多可输入64 字符
        ///</summary>
        public string OwnerNameEn{ get; set; }
        ///<summary>
        /// 国家及地区（中文）
        ///</summary>
        public string NationCodeCh{ get; set; }
        ///<summary>
        /// 国家及地区（英文）
        ///</summary>
        public string NationCodeEn{ get; set; }
        ///<summary>
        /// 省份（中文）
        ///</summary>
        public string ProvinceCodeCh{ get; set; }
        ///<summary>
        /// 省份（英文）
        ///</summary>
        public string ProvinceCodeEn{ get; set; }
        ///<summary>
        /// 城市（中文）
        ///</summary>
        public string CityCodeCh{ get; set; }
        ///<summary>
        /// 城市（英文）
        ///</summary>
        public string CityCodeEn{ get; set; }
        ///<summary>
        /// 通信地址（中文）
        ///</summary>
        public string AddressCh{ get; set; }
        ///<summary>
        /// 通信地址（英文）
        ///</summary>
        public string AddressEn{ get; set; }
        ///<summary>
        /// 邮编 6位数字
        ///</summary>
        public string ZipCode{ get; set; }
        ///<summary>
        /// 联系电话，国家区号-地区区号(或手机号码前3位)-电话号码（或手机号码后8位) 例:86-138-12345678
        ///</summary>
        public string Phone{ get; set; }
        ///<summary>
        /// 传真，国家区号-地区区号(或手机号码前3位)-电话号码（或手机号码后8位) 例:86-138-12345678
        ///</summary>
        public string Fax{ get; set; }
        ///<summary>
        /// 邮件
        ///</summary>
        public string Email{ get; set; }
        ///<summary>
        /// 所有者类型  1个人 2企业
        ///</summary>
        public int? OwnerType{ get; set; }
    }
}
