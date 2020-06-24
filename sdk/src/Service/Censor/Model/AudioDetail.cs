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
    ///  audioDetail
    /// </summary>
    public class AudioDetail
    {

        ///<summary>
        /// 总时长
        ///</summary>
        public int? Audio_time{ get; set; }
        ///<summary>
        /// 疑似时长
        ///</summary>
        public int? Audio_review_time{ get; set; }
        ///<summary>
        /// 违规时长
        ///</summary>
        public int? Audio_block_time{ get; set; }
        ///<summary>
        /// 正常时长
        ///</summary>
        public int? Audio_pass_time{ get; set; }
        ///<summary>
        /// 涉黄违规时长
        ///</summary>
        public int? Porn_block_time{ get; set; }
        ///<summary>
        /// 涉政违规时长
        ///</summary>
        public int? Politics_block_time{ get; set; }
        ///<summary>
        /// 涉恐违规时长
        ///</summary>
        public int? Terrorism_block_time{ get; set; }
    }
}