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


namespace JDCloudSDK.Disk.Model
{

    /// <summary>
    ///  云硬盘资源列表
    /// </summary>
    public class Data
    {

        ///<summary>
        /// 云硬盘ID
        ///</summary>
        public string ResourceId{ get; set; }
        ///<summary>
        /// 云硬盘名称，只允许输入中文、数字、大小写字母、英文下划线“_”及中划线“-”，不允许为空且不超过32字符。
        ///</summary>
        public string ResourceName{ get; set; }
        ///<summary>
        /// 云硬盘状态，取值为 creating、available、in-use、extending、restoring、deleting、deleted、error_create、error_delete、error_restore、error_extend 之一
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 绑定资源列表
        ///</summary>
        public List<Bind> Bind{ get; set; }
    }
}
