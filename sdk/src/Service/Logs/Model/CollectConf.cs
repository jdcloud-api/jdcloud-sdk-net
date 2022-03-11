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


namespace JDCloudSDK.Logs.Model
{

    /// <summary>
    ///  collectConf
    /// </summary>
    public class CollectConf
    {

        ///<summary>
        /// collectTemplateUID
        ///</summary>
        public string CollectTemplateUID{ get; set; }
        ///<summary>
        /// 采集文件名称，支持通配
        ///</summary>
        public string File{ get; set; }
        ///<summary>
        /// filters 过滤器V1：多个词之间为or的关系
        ///</summary>
        public List<string> Filters{ get; set; }
        ///<summary>
        /// logsetUID 日志集UID
        ///</summary>
        public string LogsetUID{ get; set; }
        ///<summary>
        /// logtopicUID 日志主题UID
        ///</summary>
        public string LogtopicUID{ get; set; }
        ///<summary>
        /// 采集文件路径，支持通配
        ///</summary>
        public string Path{ get; set; }
    }
}
