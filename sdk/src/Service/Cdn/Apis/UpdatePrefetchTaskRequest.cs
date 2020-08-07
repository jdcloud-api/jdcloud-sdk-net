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
 * Pcdn刷新预热接口
 * Openapi For JCLOUD cdn
 *
 * OpenAPI spec version: v1
 * Contact: pid-cdn@jd.com
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;


namespace  JDCloudSDK.Cdn.Apis
{

    /// <summary>
    ///  更新预热任务接口
    /// </summary>
    public class UpdatePrefetchTaskRequest : JdcloudRequest
    {
        ///<summary>
        /// url
        ///</summary>
        public   string Url{ get; set; }
        ///<summary>
        /// 地区[huabei huadong dongbei huazhong huanan xinan xibei gangaotai]中的一个
        ///</summary>
        public   string Region{ get; set; }
        ///<summary>
        /// 运营商[ct uni cm]中的一个,分别代表电信 联通 移动
        ///</summary>
        public   string Isp{ get; set; }
        ///<summary>
        /// 副本数,介于1-1000之间
        ///</summary>
        public   int? CopyNum{ get; set; }
    }
}