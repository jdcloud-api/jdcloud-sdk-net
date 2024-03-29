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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Billing.Model
{

    /// <summary>
    ///  资源操作记录
    /// </summary>
    public class ResourceOperateRecordReq
    {

        ///<summary>
        /// 站点
        ///Required:true
        ///</summary>
        [Required]
        public int Site{ get; set; }
        ///<summary>
        /// 产品线
        ///Required:true
        ///</summary>
        [Required]
        public string AppCode{ get; set; }
        ///<summary>
        /// 产品编码
        ///Required:true
        ///</summary>
        [Required]
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 资源ID
        ///Required:true
        ///</summary>
        [Required]
        public string ResourceId{ get; set; }
        ///<summary>
        /// 操作行为 (1:启动 2：关闭 3：变配 4：删除)
        ///Required:true
        ///</summary>
        [Required]
        public int OpType{ get; set; }
        ///<summary>
        /// 资源配置信息
        ///Required:true
        ///</summary>
        [Required]
        public List<Formula> Formula{ get; set; }
        ///<summary>
        /// 操作时间(格式为：yyyy-MM-dd HH:mm:ss)
        ///Required:true
        ///</summary>
        [Required]
        public string OpTime{ get; set; }
        ///<summary>
        /// 地域
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 用户
        ///Required:true
        ///</summary>
        [Required]
        public string Pin{ get; set; }
        ///<summary>
        /// 释放标识，不传默认释放（1：释放 0：不释放）
        ///</summary>
        public int? Release{ get; set; }
    }
}
