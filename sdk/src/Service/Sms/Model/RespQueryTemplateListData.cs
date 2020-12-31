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


namespace JDCloudSDK.Sms.Model
{

    /// <summary>
    ///  respQueryTemplateListData
    /// </summary>
    public class RespQueryTemplateListData
    {

        ///<summary>
        /// 模版ID
        ///</summary>
        public string TemplateId{ get; set; }
        ///<summary>
        /// 模版名称
        ///</summary>
        public string TemplateName{ get; set; }
        ///<summary>
        /// 模版内容
        ///</summary>
        public string Template{ get; set; }
        ///<summary>
        /// 申请说明
        ///</summary>
        public string TemplateDescription{ get; set; }
        ///<summary>
        /// 短信类型: 1 验证码短信， 2 通知短信， 3 推广短信
        ///</summary>
        public string TemplateType{ get; set; }
        ///<summary>
        /// 审核状态: -1 草稿， 0 审核中， 1 审核通过， 2 审核不通过， 3 停用
        ///</summary>
        public string TemplateStatus{ get; set; }
        ///<summary>
        /// 短信创建时间 yyyy-MM-dd HH:mm:ss
        ///</summary>
        public string CreateTime{ get; set; }
    }
}
