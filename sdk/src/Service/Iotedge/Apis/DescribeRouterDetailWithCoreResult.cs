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
 * EdgeRouteManager
 * iotcore-Edge消息路由管理
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


namespace  JDCloudSDK.Iotedge.Apis
{

    /// <summary>
    ///  消息路由详情查询
    /// </summary>
    public class DescribeRouterDetailWithCoreResult : JdcloudResult
    {
        ///<summary>
        /// 消息路由编号
        ///</summary>
        public   string RouterId{ get; set; }
        ///<summary>
        /// 消息路由名称
        ///</summary>
        public   string RouterName{ get; set; }
        ///<summary>
        /// 消息路由描述
        ///</summary>
        public   string RouterDesc{ get; set; }
        ///<summary>
        /// router配置更新状态, SUCCESS-更新成功，UPDATEING-更新中,FAILTURE-更新失败
        ///</summary>
        public   string RouterUpdateStatus{ get; set; }
        ///<summary>
        /// 配置下发服务详情
        ///</summary>
        public   string RouterDetail{ get; set; }
    }
}