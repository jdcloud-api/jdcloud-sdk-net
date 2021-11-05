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
 * 云主机
 * 与主机操作相关的接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  
        ///         /// 获取云主机vnc地址。
        ///         /// 
        ///         /// 详细操作说明请参考帮助文档：[连接实例](https://docs.jdcloud.com/cn/virtual-machines/connect-to-instance)
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 实例仅 &#x60;running&#x60; 状态时才可获取到 &#x60;vnc&#x60; 地址。
        ///         /// - 调用该接口可获取云主机 &#x60;vnc&#x60; 地址，用于远程连接管理云主机。
        ///         /// - &#x60;vnc&#x60; 地址的有效期为1个小时，调用接口获取vnc地址后如果1个小时内没有使用，&#x60;vnc&#x60; 地址将自动失效，再次使用需要重新获取。
        ///         /// - 裸金属实例目前不支持通过 &#x60;vnc&#x60; 登录。
        ///         /// 
    /// </summary>
    public class DescribeInstanceVncUrlResult : JdcloudResult
    {
        ///<summary>
        /// 远程vnc地址。
        ///</summary>
        public   string VncUrl{ get; set; }
    }
}