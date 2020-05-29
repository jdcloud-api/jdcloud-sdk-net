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
 * LoongrayDeviceInfo
 * 朗讯device管理模块
 *
 * OpenAPI spec version: v2
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;
using Newtonsoft.Json;

namespace  JDCloudSDK.Iotcore.Apis
{

    /// <summary>
    ///  朗瑞分页查询设备信息,支持一个或多个条件
    /// </summary>
    public class LoongrayQueryPageRequest : JdcloudRequest
    {
        ///<summary>
        /// 设备名称，模糊匹配
        ///</summary>
        public   string DeviceName{ get; set; }
        ///<summary>
        /// 设备状态 0-未激活，1-激活离线，2-激活在线
        ///</summary>
        public   int? Status{ get; set; }
        ///<summary>
        /// 设备所归属的产品Key
        ///</summary>
        public   string ProductKey{ get; set; }
        ///<summary>
        /// 设备类型，同产品类型，0-设备，1-网关
        ///</summary>
        public   int? DeviceType{ get; set; }
        ///<summary>
        /// 当前页数
        ///</summary>
        public   int? NowPage{ get; set; }
        ///<summary>
        /// 每页的数据条数
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        /// 排序关键字--name,type,productKey,status--最多支持一个字段
        ///</summary>
        public   string Order{ get; set; }
        ///<summary>
        /// 顺序，升序降序--asc,desc
        ///</summary>
        public   string Direction{ get; set; }
        ///<summary>
        /// 父设备Id
        ///</summary>
        public   string ParentId{ get; set; }
        ///<summary>
        /// 订单号
        ///</summary>
        public   int? OrderId{ get; set; }
        ///<summary>
        /// 设备采集器类型
        ///</summary>
        public   string DeviceCollectorType{ get; set; }
        ///<summary>
        /// 设备归属的实例ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        /// 设备归属的实例所在区域
        ///Required:true
        ///</summary>
        [Required]
        [JsonProperty("regionId")]
        public   string RegionIdValue{ get; set; }
    }
}