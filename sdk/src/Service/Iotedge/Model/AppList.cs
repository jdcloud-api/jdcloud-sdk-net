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
    ///  appList
    /// </summary>
    public class AppList
    {

        ///<summary>
        /// App业务编号
        ///</summary>
        public string AppId{ get; set; }
        ///<summary>
        /// 云翼编译编号
        ///</summary>
        public string ArkId{ get; set; }
        ///<summary>
        /// APP版本号
        ///</summary>
        public string AppVersion{ get; set; }
        ///<summary>
        /// 发布时间
        ///</summary>
        public string ReleaseTime{ get; set; }
        ///<summary>
        /// APP状态，0-发布成功，1-发布失败，2-审核通过，3-审核不通过，4-上线，5-下线，99-发布中
        ///</summary>
        public string AppStatus{ get; set; }
        ///<summary>
        /// 上线时间
        ///</summary>
        public string OnlineTime{ get; set; }
        ///<summary>
        /// 物模型编号
        ///</summary>
        public string TmId{ get; set; }
        ///<summary>
        /// 物模型名称
        ///</summary>
        public string TmName{ get; set; }
    }
}
