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
 * 镜像仓库认证信息
 * 关于镜像仓库认证信息的相关接口
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

namespace JDCloudSDK.Pod.Client
{

    /// <summary>
    ///  校验镜像与镜像仓库认证信息是否有效。&lt;br&gt;
        /// 设置 image，如果 secret 不设置，使用 docker 官方镜像可以直接将 image 字段设置为镜像名称，不可设置 serverAddress、username、password；&lt;br&gt;
        /// 同时设置 image 与 secret 时，需要保证该 secret 已经创建成功，不可设置 serverAddress、username、password；&lt;br&gt;
        /// 如果不设置 image，则用于 check secret，需必传 serverAddress 路径，用户名密码可选。&lt;br&gt;
        /// 
    /// </summary>
    public class VerifyImageAccessExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  校验镜像与镜像仓库认证信息是否有效。&lt;br&gt;
        /// 设置 image，如果 secret 不设置，使用 docker 官方镜像可以直接将 image 字段设置为镜像名称，不可设置 serverAddress、username、password；&lt;br&gt;
        /// 同时设置 image 与 secret 时，需要保证该 secret 已经创建成功，不可设置 serverAddress、username、password；&lt;br&gt;
        /// 如果不设置 image，则用于 check secret，需必传 serverAddress 路径，用户名密码可选。&lt;br&gt;
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "POST";
            }
        }
        /// <summary>
        ///  校验镜像与镜像仓库认证信息是否有效。&lt;br&gt;
        /// 设置 image，如果 secret 不设置，使用 docker 官方镜像可以直接将 image 字段设置为镜像名称，不可设置 serverAddress、username、password；&lt;br&gt;
        /// 同时设置 image 与 secret 时，需要保证该 secret 已经创建成功，不可设置 serverAddress、username、password；&lt;br&gt;
        /// 如果不设置 image，则用于 check secret，需必传 serverAddress 路径，用户名密码可选。&lt;br&gt;
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/secrets:verifyImageAccess";
            }
        }
    }
}
