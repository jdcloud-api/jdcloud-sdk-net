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
        /// 取消共享私有镜像。
        /// 
        /// 详细操作说明请参考帮助文档：[取消共享私有镜像](https://docs.jdcloud.com/cn/virtual-machines/cancel-share-image)
        /// 
        /// ## 接口说明
        /// - 只允许操作用户的私有镜像。
        /// - 原被共享用户将无法再使用该镜像创建云主机实例，同时使用该镜像创建的云主机实例也无法重置为原始系统状态。
        /// 
    /// </summary>
    public class UnShareImageExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  
        /// 取消共享私有镜像。
        /// 
        /// 详细操作说明请参考帮助文档：[取消共享私有镜像](https://docs.jdcloud.com/cn/virtual-machines/cancel-share-image)
        /// 
        /// ## 接口说明
        /// - 只允许操作用户的私有镜像。
        /// - 原被共享用户将无法再使用该镜像创建云主机实例，同时使用该镜像创建的云主机实例也无法重置为原始系统状态。
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
        /// 取消共享私有镜像。
        /// 
        /// 详细操作说明请参考帮助文档：[取消共享私有镜像](https://docs.jdcloud.com/cn/virtual-machines/cancel-share-image)
        /// 
        /// ## 接口说明
        /// - 只允许操作用户的私有镜像。
        /// - 原被共享用户将无法再使用该镜像创建云主机实例，同时使用该镜像创建的云主机实例也无法重置为原始系统状态。
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/images/{imageId}:unshare";
            }
        }
    }
}
