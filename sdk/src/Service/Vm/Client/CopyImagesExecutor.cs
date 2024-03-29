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
 * 镜像
 * 关于主机镜像操作的相关接口
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
        /// 镜像跨地域复制。
        /// 
        /// 详细操作说明请参考帮助文档：[镜像复制](https://docs.jdcloud.com/cn/virtual-machines/copy-image)
        /// 
        /// ## 接口说明
        /// - 调用该接口将私有镜像复制到其它地域下。
        /// - 只支持云盘系统盘的镜像。
        /// - 不支持带有加密快照的镜像。
        /// 
    /// </summary>
    public class CopyImagesExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  
        /// 镜像跨地域复制。
        /// 
        /// 详细操作说明请参考帮助文档：[镜像复制](https://docs.jdcloud.com/cn/virtual-machines/copy-image)
        /// 
        /// ## 接口说明
        /// - 调用该接口将私有镜像复制到其它地域下。
        /// - 只支持云盘系统盘的镜像。
        /// - 不支持带有加密快照的镜像。
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
        /// 镜像跨地域复制。
        /// 
        /// 详细操作说明请参考帮助文档：[镜像复制](https://docs.jdcloud.com/cn/virtual-machines/copy-image)
        /// 
        /// ## 接口说明
        /// - 调用该接口将私有镜像复制到其它地域下。
        /// - 只支持云盘系统盘的镜像。
        /// - 不支持带有加密快照的镜像。
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/images:copyImages";
            }
        }
    }
}
