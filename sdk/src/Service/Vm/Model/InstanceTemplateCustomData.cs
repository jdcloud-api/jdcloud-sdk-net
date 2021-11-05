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
    ///  实例模板关联的自定义元数据。
    /// </summary>
    public class InstanceTemplateCustomData
    {

        ///<summary>
        /// 模板ID
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 用户自定义元数据。
        /// 以key-value键值对形式指定，可在实例系统内通过元数据服务查询获取。最多支持40对键值对，且key不超过256字符，value不超过16KB，不区分大小写。
        /// 注意：key不要以连字符(-)结尾，否则此key不生效。
        /// 
        ///</summary>
        public List<Metadata> Metadata{ get; set; }
        ///<summary>
        /// 自定义脚本。
        /// 目前仅支持启动脚本，即 &#x60;launch-script&#x60;，须 &#x60;base64&#x60; 编码且编码前数据长度不能超过16KB。
        /// **linux系统**：支持 &#x60;bash&#x60; 和 &#x60;python&#x60;，编码前须分别以 &#x60;#!/bin/bash&#x60; 和 &#x60;#!/usr/bin/env python&#x60; 作为内容首行。
        /// **Windows系统**：支持 &#x60;bat&#x60; 和 &#x60;powershell&#x60;，编码前须分别以 &#x60;&lt;cmd&gt;&lt;/cmd&gt;和&lt;powershell&gt;&lt;/powershell&gt;&#x60; 作为内容首、尾行。
        ///</summary>
        public List<Userdata> Userdata{ get; set; }
    }
}
