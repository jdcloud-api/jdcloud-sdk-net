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
 * TOPIC相关 API
 * 流数据总线topic相关信息接口
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

using JDCloudSDK.Streambus.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Streambus.Apis
{

    /// <summary>
    ///  此接口可以用来更新主题，创建归档，修改归档，删除归档，传入不同的参数可以实现不同的功能。修改归档只需要修改相应归档的参数，删除归档只需要把归档参数置为空即可
    /// </summary>
    public class UpdateTopicRequest : JdcloudRequest
    {
        ///<summary>
        /// 当更新主题时只需要修改topicModel中的topic中的属性即可；创建归档需要指定target以及归档的目的地(mysql,京东云 Elasticsearch,对象存储,数据计算服务)参数
        ///Required:true
        ///</summary>
        [Required]
        public   TopicModel TopicModel{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}