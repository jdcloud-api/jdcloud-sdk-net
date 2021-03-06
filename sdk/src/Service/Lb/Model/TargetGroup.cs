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


namespace JDCloudSDK.Lb.Model
{

    /// <summary>
    ///  targetGroup
    /// </summary>
    public class TargetGroup
    {

        ///<summary>
        /// TargetGroup的Id
        ///</summary>
        public string TargetGroupId{ get; set; }
        ///<summary>
        /// TargetGroup的名字
        ///</summary>
        public string TargetGroupName{ get; set; }
        ///<summary>
        /// TargetGroup所属LoadBalancer的Id
        ///</summary>
        public string LoadBalancerId{ get; set; }
        ///<summary>
        /// TargetGroup所属负载均衡类型，取值为：alb、nlb、dnlb
        ///</summary>
        public string LoadBalancerType{ get; set; }
        ///<summary>
        /// TargetGroup所属LoadBalancer的名称
        ///</summary>
        public string LoadBalancerName{ get; set; }
        ///<summary>
        /// TargetGroup的描述信息
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// TargetGroup的创建时间
        ///</summary>
        public string CreatedTime{ get; set; }
        ///<summary>
        /// Target列表。该字段即将下线，请勿使用，已经使用该字段查询Target详情的服务请尽快切换使用describeTargets接口
        ///</summary>
        public List<Target> Targets{ get; set; }
        ///<summary>
        /// 实例或IP
        ///</summary>
        public string Type{ get; set; }
    }
}
