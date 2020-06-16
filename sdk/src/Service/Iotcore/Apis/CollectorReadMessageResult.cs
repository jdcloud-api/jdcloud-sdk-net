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
 * LoongrayElevator
 * 朗锐电梯服务
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Iotcore.Apis
{

    /// <summary>
    ///  获取协议信息
    /// </summary>
    public class CollectorReadMessageResult : JdcloudResult
    {
        ///<summary>
        /// 读取寄存器值，key：寄存器地址 value:寄存器值
        /// 如读取语音播报控制器-输入端子的响应为
        /// {
        ///   &quot;0&quot;:0,
        ///   &quot;1&quot;:0,
        ///   &quot;2&quot;:0,
        ///   &quot;3&quot;:0,
        ///   &quot;4&quot;:0,
        ///   &quot;5&quot;:0,
        ///   &quot;6&quot;:0,
        ///   &quot;7&quot;:0
        /// }
        /// 如读取语音播报控制器-播放信息的响应为
        /// {
        ///   &quot;36&quot;:0,
        ///   &quot;37&quot;:0,
        ///   &quot;38&quot;:0,
        ///   &quot;39&quot;:0,
        ///   &quot;40&quot;:0,
        ///   &quot;41&quot;:0,
        ///   &quot;42&quot;:0,
        ///   &quot;43&quot;:0,
        ///   &quot;44&quot;:1,
        ///   &quot;45&quot;:3,
        ///   &quot;46&quot;:0,
        ///   &quot;47&quot;:0
        /// }
        /// 如读取LR001-516-5B边缘数据采集器-传感器管理的响应为
        /// {
        ///   &quot;40426&quot;:1,
        ///   &quot;40427&quot;:1,
        ///   &quot;40428&quot;:2,
        ///   &quot;40429&quot;:1,
        ///   &quot;40430&quot;:1,
        ///   &quot;40431&quot;:1,
        ///   &quot;40432&quot;:1,
        ///   &quot;40433&quot;:2,
        ///   &quot;40434&quot;:1,
        ///   &quot;40435&quot;:1,
        ///   &quot;40436&quot;:1,
        ///   &quot;40437&quot;:1,
        ///   &quot;40438&quot;:1,
        ///   &quot;40439&quot;:1,
        ///   &quot;40440&quot;:1
        /// }
        /// 如读取LR001-516-5A边缘数据采集器-水质酸碱度(PH)响应为
        /// {
        ///   &quot;40301&quot;: 0,
        ///   &quot;40302&quot;: 225,
        ///   &quot;40304&quot;: 28.071838,
        ///   &quot;40306&quot;: 12.9,
        ///   &quot;40308&quot;: 0,
        ///   &quot;40309&quot;: 37376,
        ///   &quot;40311&quot;: 2000,
        ///   &quot;40313&quot;: -2000,
        ///   &quot;40315&quot;: 60,
        ///   &quot;40317&quot;: 0,
        ///   &quot;40319&quot;: 0,
        ///   &quot;40321&quot;: 0,
        ///   &quot;40323&quot;: 0,
        ///   &quot;40324&quot;: 1,
        ///   &quot;40325&quot;: 4,
        ///   &quot;40326&quot;: 0,
        ///   &quot;40327&quot;: 256,
        ///   &quot;40329&quot;: -0.1984,
        ///   &quot;40331&quot;: 0,
        ///   &quot;40333&quot;: 1,
        ///   &quot;40335&quot;: 25,
        ///   &quot;40337&quot;: 0,
        ///   &quot;40338&quot;: 0,
        ///   &quot;40339&quot;: 2622
        /// }
        /// 如读取LR001-516-5A水质监测采集器-水质电导率响应为
        /// {
        ///   &quot;40340&quot;: 0,
        ///   &quot;40342&quot;: 0,
        ///   &quot;40344&quot;: 29.816881,
        ///   &quot;40346&quot;: 0,
        ///   &quot;40348&quot;: 0,
        ///   &quot;40350&quot;: 10,
        ///   &quot;40352&quot;: 0.018,
        ///   &quot;40354&quot;: 25,
        ///   &quot;40356&quot;: 0,
        ///   &quot;40358&quot;: 38400,
        ///   &quot;40360&quot;: 2,
        ///   &quot;40362&quot;: 1663480.8,
        ///   &quot;40364&quot;: 1,
        ///   &quot;40366&quot;: 0,
        ///   &quot;40368&quot;: 50,
        ///   &quot;40370&quot;: 20
        /// }
        /// 
        ///</summary>
        public   object ReadData{ get; set; }
    }
}