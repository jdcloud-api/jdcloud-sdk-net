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
 * Firmware
 * 关于固件操作的相关接口
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

using JDCloudSDK.Iotcore.Model;

namespace  JDCloudSDK.Iotcore.Apis
{

    /// <summary>
    ///  查看固件列表接口
    /// </summary>
    public class DescribeFirmwaresResult : JdcloudResult
    {
        ///<summary>
        /// 分页信息
        ///</summary>
        public   PageinfoVO Page{ get; set; }
        ///<summary>
        /// 固件数组
        ///</summary>
        public List<Firmware> Firmwares{ get; set; }

    }
}