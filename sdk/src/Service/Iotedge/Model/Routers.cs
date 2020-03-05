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


namespace JDCloudSDK.Iotedge.Model
{

    /// <summary>
    ///  routers
    /// </summary>
    public class Routers
    {

        ///<summary>
        /// router编号
        ///</summary>
        public string RouterId{ get; set; }
        ///<summary>
        /// router名称
        ///</summary>
        public string RouterName{ get; set; }
        ///<summary>
        /// router描述
        ///</summary>
        public string RouterDesc{ get; set; }
        ///<summary>
        /// router状态
        ///</summary>
        public string RouterStatus{ get; set; }
        ///<summary>
        /// router配置更新状态, SUCCESS-更新成功，UPDATEING-更新中,FAILTURE-更新失败
        ///</summary>
        public string RouterUpdateStatus{ get; set; }
        ///<summary>
        /// router创建时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// router数据源名称
        ///</summary>
        public string SourceName{ get; set; }
        ///<summary>
        /// router数据目标名称
        ///</summary>
        public string TargetName{ get; set; }
    }
}