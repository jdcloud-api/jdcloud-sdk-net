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


namespace JDCloudSDK.Censor.Model
{

    /// <summary>
    ///  hitLocationInfos
    /// </summary>
    public class HitLocationInfos
    {

        ///<summary>
        /// 命中详情
        ///</summary>
        public string HitInfo{ get; set; }
        ///<summary>
        /// 位置信息，对应目标矩形左上角横坐标相对坐标
        ///</summary>
        public float? X1{ get; set; }
        ///<summary>
        /// 位置信息，对应目标矩形左上角纵坐标相对坐标
        ///</summary>
        public float? Y1{ get; set; }
        ///<summary>
        /// 位置信息，对应目标矩形右下角横坐标相对坐标
        ///</summary>
        public float? X2{ get; set; }
        ///<summary>
        /// 置信息，对应目标矩形右下角纵坐标相对坐标
        ///</summary>
        public float? Y2{ get; set; }
    }
}