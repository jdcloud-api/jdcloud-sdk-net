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


namespace JDCloudSDK.Jdfusion.Model
{

    /// <summary>
    ///  dataDiskAttachment
    /// </summary>
    public class DataDiskAttachment
    {

        ///<summary>
        /// 是否随云主机一起删除,true：自动；false：非自动
        ///</summary>
        public bool AutoDelete{ get; set; }
        ///<summary>
        /// DataDisk
        ///</summary>
        public DataDiskInfo DataDisk{ get; set; }
        ///<summary>
        /// 数据盘逻辑挂载点
        ///</summary>
        public string DeviceName{ get; set; }
        ///<summary>
        /// 磁盘分类,取值为本地盘(local)或者数据盘(cloud)
        ///</summary>
        public string DiskCategory{ get; set; }
    }
}