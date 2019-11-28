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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Detection.Model
{

    /// <summary>
    ///  updateAlarmResourcesSpec
    /// </summary>
    public class UpdateAlarmResourcesSpec
    {

        ///<summary>
        /// 操作类型,默认为1，说明：1-覆盖  2-追加 3-删除
        ///</summary>
        public long? OperatorType{ get; set; }
        ///<summary>
        /// ResourceOption
        ///Required:true
        ///</summary>
        [Required]
        public ResourceOption ResourceOption{ get; set; }
    }
}
