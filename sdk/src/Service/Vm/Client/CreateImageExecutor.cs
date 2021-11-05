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


using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Vm.Client
{

    /// <summary>
    ///  
        /// 为云主机制作私有镜像。
        /// 
        /// 详细操作说明请参考帮助文档：[基于实例创建私有镜像](https://docs.jdcloud.com/cn/virtual-machines/create-private-image)
        /// 
        /// ## 接口说明
        /// - 云主机实例没有正在进行中的任务时才可制作镜像。
        /// - 本地系统盘的实例，仅支持关机（已停止）状态下制作私有镜像。
        /// - 云盘系统盘的实例，支持开机(运行中)/关机（已停止）状态下制作私有镜像。
        /// - 调用接口后，需要等待镜像状态变为 &#x60;ready&#x60; 后，才能正常使用镜像。
        /// - 若当前实例系统盘为本地盘，则创建完成后的私有镜像为本地盘系统盘镜像；若当前实例系统盘为云硬盘，则创建完成后的私有镜像为云硬盘系统盘镜像。您可通过镜像类型转换 [convertImage](https://docs.jdcloud.com/Image/api/convertimage) 将本地盘系统盘镜像转换为云硬盘系统盘镜像后使用。
        /// - 默认情况下，制作的镜像中包括数据盘中的云硬盘（制作快照），但是不包含本地数据盘。
        /// - 如果需要变更打包镜像中的一些数据盘、或排除一些数据盘不需要制作快照，可通过 &#x60;dataDisks&#x60; 中的参数进行控制。
        /// 
    /// </summary>
    public class CreateImageExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  
        /// 为云主机制作私有镜像。
        /// 
        /// 详细操作说明请参考帮助文档：[基于实例创建私有镜像](https://docs.jdcloud.com/cn/virtual-machines/create-private-image)
        /// 
        /// ## 接口说明
        /// - 云主机实例没有正在进行中的任务时才可制作镜像。
        /// - 本地系统盘的实例，仅支持关机（已停止）状态下制作私有镜像。
        /// - 云盘系统盘的实例，支持开机(运行中)/关机（已停止）状态下制作私有镜像。
        /// - 调用接口后，需要等待镜像状态变为 &#x60;ready&#x60; 后，才能正常使用镜像。
        /// - 若当前实例系统盘为本地盘，则创建完成后的私有镜像为本地盘系统盘镜像；若当前实例系统盘为云硬盘，则创建完成后的私有镜像为云硬盘系统盘镜像。您可通过镜像类型转换 [convertImage](https://docs.jdcloud.com/Image/api/convertimage) 将本地盘系统盘镜像转换为云硬盘系统盘镜像后使用。
        /// - 默认情况下，制作的镜像中包括数据盘中的云硬盘（制作快照），但是不包含本地数据盘。
        /// - 如果需要变更打包镜像中的一些数据盘、或排除一些数据盘不需要制作快照，可通过 &#x60;dataDisks&#x60; 中的参数进行控制。
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "POST";
            }
        }
        /// <summary>
        ///  
        /// 为云主机制作私有镜像。
        /// 
        /// 详细操作说明请参考帮助文档：[基于实例创建私有镜像](https://docs.jdcloud.com/cn/virtual-machines/create-private-image)
        /// 
        /// ## 接口说明
        /// - 云主机实例没有正在进行中的任务时才可制作镜像。
        /// - 本地系统盘的实例，仅支持关机（已停止）状态下制作私有镜像。
        /// - 云盘系统盘的实例，支持开机(运行中)/关机（已停止）状态下制作私有镜像。
        /// - 调用接口后，需要等待镜像状态变为 &#x60;ready&#x60; 后，才能正常使用镜像。
        /// - 若当前实例系统盘为本地盘，则创建完成后的私有镜像为本地盘系统盘镜像；若当前实例系统盘为云硬盘，则创建完成后的私有镜像为云硬盘系统盘镜像。您可通过镜像类型转换 [convertImage](https://docs.jdcloud.com/Image/api/convertimage) 将本地盘系统盘镜像转换为云硬盘系统盘镜像后使用。
        /// - 默认情况下，制作的镜像中包括数据盘中的云硬盘（制作快照），但是不包含本地数据盘。
        /// - 如果需要变更打包镜像中的一些数据盘、或排除一些数据盘不需要制作快照，可通过 &#x60;dataDisks&#x60; 中的参数进行控制。
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/instances/{instanceId}:createImage";
            }
        }
    }
}
