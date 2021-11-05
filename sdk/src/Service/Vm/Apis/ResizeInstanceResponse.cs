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
        ///         /// 变更云主机实例配置。
        ///         /// 
        ///         /// 详细操作说明请参考帮助文档：[调整配置](https://docs.jdcloud.com/cn/virtual-machines/resize-instance)
        ///         /// 
        ///         /// ## 接口说明
        ///         ///   - 云主机的状态必须为 &#x60;stopped&#x60; 状态。
        ///         ///   - 16年创建的云硬盘做系统盘的云主机，实例规格不允许跨代调配。
        ///         ///   - 若当前实例系统盘为本地盘，则不允许跨代调配，例如第一代云主机不允许与第二代云主机互相调配，且不允许调整至第一代存储优化大数据型 &#x60;s.d1&#x60; 及第二代存储优化大数据型 &#x60;s.d2&#x60;。
        ///         ///   - 若当前实例在高可用组内，则不允许调配至除GPU类型外的第一代云主机，受限于高可用组支持的规格情况。
        ///         ///   - 若当前实例已挂载加密云盘，则不允许调配至第一代云主机，受限于支持加密盘的规格情况。
        ///         ///   - 裸金属实例规格主机暂不支持调配，即不支持从其他规格调整为裸金属规格或从裸金属规格调整为其他规格。
        ///         ///   - 对于按配置计费实例，调整配置后将按照新规格计费，调整前规格会立即出账结算（即对上次整点结算时间至当前时间产生的费用进行结算）。
        ///         ///   - 若当前实例带有本地数据盘，需清除本地盘内数据才可调整配置，还请谨慎操作。
        ///         ///   - 对于包年包月计费云主机：
        ///         /// 	- 若调配后规格价格低于调配前规格价格，则将延长云主机到期时间；
        ///         /// 	- 若调配后规格价格高于调配前规格价格，需要支付到期前的差价。
        ///         ///   - 如果当前主机中的弹性网卡数量，超过了目标实例规格允许的弹性网卡数量，会返回错误。可查询 [DescribeInstanceTypes](https://docs.jdcloud.com/virtual-machines/api/describeinstancetypes) 接口获得实例规格允许的弹性网卡数量。
        ///         ///   - 如果当前主机中的云硬盘数据，超过了目标实例规格允许的云硬盘数量，会返回错误。可查询 [DescribeInstanceTypes](https://docs.jdcloud.com/virtual-machines/api/describeinstancetypes) 接口获得实例规格允许的云硬盘数量。
        ///         ///   - 当前主机所使用的镜像，需要支持目标实例规格，否则返回错误。可查询 [DescribeImageConstraints](docs.jdcloud.com/virtual-machines/api/describeimageconstraints) 接口获得指定镜像的实例规格限制信息。
        ///         ///   - 云主机欠费或到期时，无法更改实例规格。
        ///         /// 
    /// </summary>
    public class ResizeInstanceResponse : JdcloudResponse<ResizeInstanceResult>
    {
    }
}