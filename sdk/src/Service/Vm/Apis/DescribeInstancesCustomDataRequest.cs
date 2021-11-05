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

using JDCloudSDK.Common.Model;
using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  
        ///         /// 批量查询云主机用户自定义元数据。
        ///         /// 
        ///         /// 详细操作说明请参考帮助文档：[自定义元数据](https://docs.jdcloud.com/cn/virtual-machines/userdata)
        ///         /// 
        ///         /// ## 接口说明
        ///         /// - 使用 &#x60;filters&#x60; 过滤器进行条件筛选，每个 &#x60;filter&#x60; 之间的关系为逻辑与（AND）的关系。
        ///         /// - 单次查询最大可查询10台云主机实例自定义元数据。
        ///         /// 
    /// </summary>
    public class DescribeInstancesCustomDataRequest : JdcloudRequest
    {
        ///<summary>
        /// 页码；默认为1。
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 分页大小；默认为10；取值范围[1, 10]。
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// &lt;b&gt;filters 中支持使用以下关键字进行过滤&lt;/b&gt;
        /// &#x60;instanceId&#x60;: 云主机ID，精确匹配，支持多个
        /// &#x60;privateIpAddress&#x60;: 主网卡内网主IP地址，模糊匹配，支持多个
        /// &#x60;vpcId&#x60;: 私有网络ID，精确匹配，支持多个
        /// &#x60;status&#x60;: 云主机状态，精确匹配，支持多个，参考 [云主机状态](https://docs.jdcloud.com/virtual-machines/api/vm_status)
        /// &#x60;name&#x60;: 云主机名称，模糊匹配，支持单个
        /// &#x60;imageId&#x60;: 镜像ID，精确匹配，支持多个
        /// &#x60;agId&#x60;: 使用可用组id，支持单个
        /// &#x60;faultDomain&#x60;: 错误域，支持多个
        /// &#x60;networkInterfaceId&#x60;: 弹性网卡ID，精确匹配，支持多个
        /// &#x60;subnetId&#x60;: 子网ID，精确匹配，支持多个
        /// 
        ///</summary>
        public List<JDCloudSDK.Common.Model.Filter> Filters{ get; set; }

        ///<summary>
        /// 地域ID。
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}