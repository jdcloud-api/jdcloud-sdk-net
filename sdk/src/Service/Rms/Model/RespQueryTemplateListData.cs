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


namespace JDCloudSDK.Rms.Model
{

    /// <summary>
    ///  respQueryTemplateListData
    /// </summary>
    public class RespQueryTemplateListData
    {

        ///<summary>
        /// 短信ID
        ///</summary>
        public string TemplateId{ get; set; }
        ///<summary>
        /// 短信标题
        ///</summary>
        public string Title{ get; set; }
        ///<summary>
        /// 审核状态 0: 审核中 1: 通过 2: 未通过 4:待提交
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 审核未通过原因
        ///</summary>
        public string Reason{ get; set; }
        ///<summary>
        /// 短信创建时间 yyyy-MM-dd HH:mm:ss
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 短信内容大小
        ///</summary>
        public string ContentSize{ get; set; }
        ///<summary>
        /// 资质Id
        ///</summary>
        public string AptitudesId{ get; set; }
        ///<summary>
        /// 短信描述
        ///</summary>
        public string Description{ get; set; }
    }
}
