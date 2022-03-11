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

using JDCloudSDK.Core.Annotation;
using JDCloudSDK.Charge.Model;
using JDCloudSDK.Vpc.Model;

namespace JDCloudSDK.Lb.Model
{

    /// <summary>
    ///  createLoadBalancerSpec
    /// </summary>
    public class CreateLoadBalancerSpec
    {

        ///<summary>
        /// LoadBalancer的名称,只允许输入中文、数字、大小写字母、英文下划线“_”及中划线“-”，不允许为空且不超过32字符
        ///Required:true
        ///</summary>
        [Required]
        public string LoadBalancerName{ get; set; }
        ///<summary>
        /// LoadBalancer所属子网的Id
        ///Required:true
        ///</summary>
        [Required]
        public string SubnetId{ get; set; }
        ///<summary>
        /// LoadBalancer的类型，取值：alb、nlb、dnlb，默认为alb
        ///</summary>
        public string Type{ get; set; }
        ///<summary>
        /// 【alb，nlb】LoadBalancer所属availability Zone列表,对于alb,nlb是必选参数，可用区个数不能超过2个 &lt;br&gt;【dnlb】中心可用区，dnlb不需要传该参数，全可用区可用；边缘可用区，仅支持传入单可用区
        ///</summary>
        public List<string> Azs{ get; set; }
        ///<summary>
        /// 【alb】支持按用量计费，默认为按用量。【nlb】支持按用量计费。【dnlb】支持按配置计费
        ///</summary>
        public ChargeSpec ChargeSpec{ get; set; }
        ///<summary>
        /// 负载均衡关联的弹性IP规格
        ///</summary>
        public ElasticIpSpec ElasticIp{ get; set; }
        ///<summary>
        /// 指定LoadBalancer的VIP(内网IPv4地址)，需要属于指定的子网并且未被占用
        ///</summary>
        public string PrivateIpAddress{ get; set; }
        ///<summary>
        /// 【alb】 安全组 ID列表
        ///</summary>
        public List<string> SecurityGroupIds{ get; set; }
        ///<summary>
        /// LoadBalancer的描述信息,允许输入UTF-8编码下的全部字符，不超过256字符
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 删除保护，取值为True(开启)或False(关闭)，默认为False
        ///</summary>
        public bool DeleteProtection{ get; set; }
        ///<summary>
        /// 用户tag 信息
        ///</summary>
        public List<Tag> UserTags{ get; set; }
    }
}
