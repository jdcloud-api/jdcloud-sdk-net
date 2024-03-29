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
 * Lock-Analyse
 * 死锁诊断和查询相关接口
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


namespace  JDCloudSDK.Smartdba.Apis
{

    /// <summary>
    ///  死锁诊断
    /// </summary>
    public class CreateLockAnalyseResult : JdcloudResult
    {
        ///<summary>
        /// 锁诊断id
        ///</summary>
        public   string AnalyseId{ get; set; }
        ///<summary>
        /// 诊断完成状态：complete\fail
        ///</summary>
        public   string State{ get; set; }
        ///<summary>
        /// 状态说明信息
        ///</summary>
        public   string Message{ get; set; }
    }
}