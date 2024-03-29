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


namespace JDCloudSDK.Starshield.Model
{

    /// <summary>
    ///  data
    /// </summary>
    public class Data
    {

        ///<summary>
        /// 位置的大小（米）
        ///</summary>
        public double? Size{ get; set; }
        ///<summary>
        /// 位置高度（米）
        ///</summary>
        public double? Altitude{ get; set; }
        ///<summary>
        /// 经度
        ///</summary>
        public double? Long_degrees{ get; set; }
        ///<summary>
        /// 纬度
        ///</summary>
        public double? Lat_degrees{ get; set; }
        ///<summary>
        /// 水平定位精度
        ///</summary>
        public double? Precision_horz{ get; set; }
        ///<summary>
        /// 垂直定位精度
        ///</summary>
        public double? Precision_vert{ get; set; }
        ///<summary>
        /// 经度方向
        ///</summary>
        public string Long_direction{ get; set; }
        ///<summary>
        /// 经度分
        ///</summary>
        public double? Long_minutes{ get; set; }
        ///<summary>
        /// 经度秒
        ///</summary>
        public double? Long_seconds{ get; set; }
        ///<summary>
        /// 纬度方向
        ///</summary>
        public string Lat_direction{ get; set; }
        ///<summary>
        /// 纬度分
        ///</summary>
        public double? Lat_minutes{ get; set; }
        ///<summary>
        /// 纬度秒
        ///</summary>
        public double? Lat_seconds{ get; set; }
        ///<summary>
        /// 以下划线为前缀的服务类型
        ///</summary>
        public string Service{ get; set; }
        ///<summary>
        /// 有效的协议
        ///</summary>
        public string Proto{ get; set; }
        ///<summary>
        /// 有效的主机名
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 与一些记录如MX和SRV一起使用，以确定优先级。如果你没有为MX记录提供一个优先级，默认值为0将被设置。
        ///</summary>
        public double? Priority{ get; set; }
        ///<summary>
        /// 记录的权重
        ///</summary>
        public double? Weight{ get; set; }
        ///<summary>
        /// 服务的端口
        ///</summary>
        public double? Port{ get; set; }
        ///<summary>
        /// 有效的主机名
        ///</summary>
        public string Target{ get; set; }
        ///<summary>
        /// 类型
        ///</summary>
        public double? Ty_pe{ get; set; }
        ///<summary>
        /// Key Tag
        ///</summary>
        public double? Key_tag{ get; set; }
        ///<summary>
        /// Algorithm
        ///</summary>
        public double? Algorithm{ get; set; }
        ///<summary>
        /// 证书
        ///</summary>
        public string Certificate{ get; set; }
        ///<summary>
        /// Flags
        ///</summary>
        public double? Flags{ get; set; }
        ///<summary>
        /// 协议
        ///</summary>
        public double? Protocol{ get; set; }
        ///<summary>
        /// 公钥
        ///</summary>
        public string Public_key{ get; set; }
        ///<summary>
        /// 摘要类型
        ///</summary>
        public double? Digest_type{ get; set; }
        ///<summary>
        /// 摘要
        ///</summary>
        public string Digest{ get; set; }
        ///<summary>
        /// Order
        ///</summary>
        public double? Order{ get; set; }
        ///<summary>
        /// Preference
        ///</summary>
        public double? Preference{ get; set; }
        ///<summary>
        /// Regex
        ///</summary>
        public string Regex{ get; set; }
        ///<summary>
        /// Replacement
        ///</summary>
        public string Replacement{ get; set; }
        ///<summary>
        /// Usage
        ///</summary>
        public double? Usage{ get; set; }
        ///<summary>
        /// Selector
        ///</summary>
        public double? Selector{ get; set; }
        ///<summary>
        /// Matching Type
        ///</summary>
        public double? Matching_type{ get; set; }
        ///<summary>
        /// 指纹
        ///</summary>
        public string Fingerprint{ get; set; }
        ///<summary>
        /// 记录内容
        ///</summary>
        public string Content{ get; set; }
    }
}
