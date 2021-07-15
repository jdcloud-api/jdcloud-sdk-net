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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Censor.Model
{

    /// <summary>
    ///  imageTaskV2
    /// </summary>
    public class ImageTaskV2
    {

        ///<summary>
        /// 最大长度1024，图片名称(或图片标识)， 该字段为回调信号字段，产品可以根据业务情况自行设计，如json结构、或者为图片url均可
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 最大长度4，类型，分别为1：图片URL，2:图片BASE64值
        ///</summary>
        public int? Type{ get; set; }
        ///<summary>
        /// 图片内容，如type&#x3D;1，则该值为图片URL，如type&#x3D;2，则该值为图片BASE64值。图片URL检测单次请求最多支持32张，图片BASE64值检测单次请求大小限制为最多10MB
        ///</summary>
        public string Data{ get; set; }
        ///<summary>
        /// 离线结果回调通知到客户的URL。主动回调数据接口超时时间设置为2s，为了保证顺利接收数据，需保证接收接口性能稳定并且保证幂等性。
        ///</summary>
        public string CallbackUrl{ get; set; }
    }
}
