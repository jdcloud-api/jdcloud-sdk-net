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
    ///  dataVO
    /// </summary>
    public class DataVO
    {

        ///<summary>
        /// 系统流水号
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 实例名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 子网编号
        ///</summary>
        public string SubNetId{ get; set; }
        ///<summary>
        /// 子网名称
        ///</summary>
        public string SubNetName{ get; set; }
        ///<summary>
        /// VPC编号
        ///</summary>
        public string VpcId{ get; set; }
        ///<summary>
        /// VPC名称
        ///</summary>
        public string VpcName{ get; set; }
        ///<summary>
        /// 可用区名称
        ///</summary>
        public string AzName{ get; set; }
        ///<summary>
        /// 公网域名
        ///</summary>
        public string PubDomain{ get; set; }
        ///<summary>
        /// 内网域名
        ///</summary>
        public string PriDomain{ get; set; }
        ///<summary>
        /// IoT Hub实例状态[10~100为创建中,0或1-运行中,2-欠费停服,3-待删除]
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public int? CreateTime{ get; set; }
        ///<summary>
        /// 实例到期时间
        ///</summary>
        public int? EndTime{ get; set; }
        ///<summary>
        /// 最大在线设备数
        ///</summary>
        public int? MaxDevices{ get; set; }
        ///<summary>
        /// 最大消息条数
        ///</summary>
        public int? MaxMessage{ get; set; }
        ///<summary>
        /// 实例编号
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        /// 实例类型[0-独享，1-共享]
        ///</summary>
        public string InstanceType{ get; set; }
        ///<summary>
        /// Edge是否开通，0-未开通，1-已开通
        ///</summary>
        public string EdgeStatus{ get; set; }
        ///<summary>
        /// Edge开通时间
        ///</summary>
        public string EdgeOpenTime{ get; set; }
    }
}
