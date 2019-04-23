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
 * 原生容器
 * 原生容器相关接口
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

namespace JDCloudSDK.Nativecontainer.Client
{

    /// <summary>
    ///  重置原生容器，对已有原生容器使用新的镜像重置。
        /// 原容器 id 不变，不涉及计费变动，暂不支持修改实例类型，不会改变原生容器所在的物理节点，也不支持修改已经使用的系统盘和数据盘以及网络相关参数。
        /// - 镜像
        ///     - 容器的镜像通过镜像名称来确定
        ///     - nginx:tag 或 mysql/mysql-server:tag 这样命名的镜像表示 docker hub 官方镜像
        ///     - container-registry/image:tag 这样命名的镜像表示私有仓储的镜像
        ///     - 私有仓储必须兼容 docker registry 认证机制，并通过 secret 来保存机密信息
        /// - 其他
        ///     - rebuild 之前容器必须处于关闭状态
        ///     - rebuild 完成后，容器仍为关闭状态
        /// 
    /// </summary>
    public class RebuildContainerExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  重置原生容器，对已有原生容器使用新的镜像重置。
        /// 原容器 id 不变，不涉及计费变动，暂不支持修改实例类型，不会改变原生容器所在的物理节点，也不支持修改已经使用的系统盘和数据盘以及网络相关参数。
        /// - 镜像
        ///     - 容器的镜像通过镜像名称来确定
        ///     - nginx:tag 或 mysql/mysql-server:tag 这样命名的镜像表示 docker hub 官方镜像
        ///     - container-registry/image:tag 这样命名的镜像表示私有仓储的镜像
        ///     - 私有仓储必须兼容 docker registry 认证机制，并通过 secret 来保存机密信息
        /// - 其他
        ///     - rebuild 之前容器必须处于关闭状态
        ///     - rebuild 完成后，容器仍为关闭状态
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "POST";
            }
        }
        /// <summary>
        ///  重置原生容器，对已有原生容器使用新的镜像重置。
        /// 原容器 id 不变，不涉及计费变动，暂不支持修改实例类型，不会改变原生容器所在的物理节点，也不支持修改已经使用的系统盘和数据盘以及网络相关参数。
        /// - 镜像
        ///     - 容器的镜像通过镜像名称来确定
        ///     - nginx:tag 或 mysql/mysql-server:tag 这样命名的镜像表示 docker hub 官方镜像
        ///     - container-registry/image:tag 这样命名的镜像表示私有仓储的镜像
        ///     - 私有仓储必须兼容 docker registry 认证机制，并通过 secret 来保存机密信息
        /// - 其他
        ///     - rebuild 之前容器必须处于关闭状态
        ///     - rebuild 完成后，容器仍为关闭状态
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/containers/{containerId}:rebuild";
            }
        }
    }
}
