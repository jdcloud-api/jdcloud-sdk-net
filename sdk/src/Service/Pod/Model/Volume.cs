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


namespace JDCloudSDK.Pod.Model
{

    /// <summary>
    ///  pod volume 规格
    /// </summary>
    public class Volume
    {

        ///<summary>
        /// volume名字，在一个Pod唯一。
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 提供给Pod的cloud disk.
        ///</summary>
        public JDCloudVolumeSource JdcloudDisk{ get; set; }
    }
}