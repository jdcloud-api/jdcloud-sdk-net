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
    ///  metaInfoItem
    /// </summary>
    public class MetaInfoItem
    {

        ///<summary>
        /// 图片大小，单位byte
        ///</summary>
        public int? ByteSize{ get; set; }
        ///<summary>
        /// 图片格式
        ///</summary>
        public string Format{ get; set; }
        ///<summary>
        /// 图片高度，单位像素
        ///</summary>
        public int? Height{ get; set; }
        ///<summary>
        /// 图片宽度，单位像素
        ///</summary>
        public int? Width{ get; set; }
    }
}
