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


namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    ///  instanceTemplateCustomData
    /// </summary>
    public class InstanceTemplateCustomData
    {

        ///<summary>
        /// 模板ID
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 用户自定义元数据信息 key-value对，key、value不区分大小写
        ///</summary>
        public List<Metadata> Metadata{ get; set; }
        ///<summary>
        /// 元数据信息，目前只支持传入一个key为&quot;launch-script&quot;，表示首次启动脚本。value为base64格式
        ///</summary>
        public List<Userdata> Userdata{ get; set; }
    }
}
