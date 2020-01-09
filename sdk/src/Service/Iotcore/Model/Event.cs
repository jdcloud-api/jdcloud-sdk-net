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


namespace JDCloudSDK.Iotcore.Model
{

    /// <summary>
    ///  event
    /// </summary>
    public class Event
    {

        ///<summary>
        /// 事件名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 事件ID
        ///</summary>
        public string EventId{ get; set; }
        ///<summary>
        /// 事件类型
        ///</summary>
        public string EventType{ get; set; }
        ///<summary>
        /// 输出参数,object的key为参数名称，value为参数值
        ///</summary>
        public object Output{ get; set; }
        ///<summary>
        /// 产生时间
        ///</summary>
        public long? CreatedTime{ get; set; }
    }
}