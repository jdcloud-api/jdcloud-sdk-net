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


namespace JDCloudSDK.Cloudsign.Model
{

    /// <summary>
    ///  templateInfo
    /// </summary>
    public class TemplateInfo
    {

        ///<summary>
        /// 合同模板ID
        ///</summary>
        public string TemplateId{ get; set; }
        ///<summary>
        /// 合同模板名称
        ///</summary>
        public string TemplateName{ get; set; }
        ///<summary>
        /// 合同模板标题
        ///</summary>
        public string TemplateTitle{ get; set; }
        ///<summary>
        /// 合同模板文件名称
        ///</summary>
        public string TemplateFileName{ get; set; }
        ///<summary>
        /// 合同模板文件（base64）
        ///</summary>
        public string TemplateContent{ get; set; }
        ///<summary>
        /// 合同模板文件摘要
        ///</summary>
        public string TemplateDigest{ get; set; }
        ///<summary>
        /// 合同模板文件类型 pdf,word,pdf-auto
        ///</summary>
        public string TemplateType{ get; set; }
        ///<summary>
        /// 填充信息
        ///</summary>
        public List<PaddingInfo> PaddingInfo{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
    }
}
