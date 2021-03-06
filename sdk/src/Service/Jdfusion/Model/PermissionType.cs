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


namespace JDCloudSDK.Jdfusion.Model
{

    /// <summary>
    ///  安全组规则类型
    /// </summary>
    public class PermissionType
    {

        ///<summary>
        /// 云注册信息ID
        ///</summary>
        public string CloudID{ get; set; }
        ///<summary>
        /// IP协议
        ///</summary>
        public string IpProtocol{ get; set; }
        ///<summary>
        /// 端口范围
        ///</summary>
        public string PortRange{ get; set; }
        ///<summary>
        /// 描述信息
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 源IP地址段，用于入方向授权
        ///</summary>
        public string SourceCidrIp{ get; set; }
        ///<summary>
        /// 源安全组，用于入方向授权
        ///</summary>
        public string SourceGroupId{ get; set; }
        ///<summary>
        /// 源安全组所属阿里云账户Id
        ///</summary>
        public string SourceGroupOwnerAccount{ get; set; }
        ///<summary>
        /// 目标IP地址段，用于出方向授权
        ///</summary>
        public string DestCidrIp{ get; set; }
        ///<summary>
        /// 目标安全组，用于出方向授权
        ///</summary>
        public string DestGroupId{ get; set; }
        ///<summary>
        /// 目标安全组所属阿里云账户Id
        ///</summary>
        public string DestGroupOwnerAccount{ get; set; }
        ///<summary>
        /// 授权策略
        ///</summary>
        public string Policy{ get; set; }
        ///<summary>
        /// 网络类型
        ///</summary>
        public string NicType{ get; set; }
        ///<summary>
        /// 规则优先级
        ///</summary>
        public string Priority{ get; set; }
        ///<summary>
        /// 授权方向
        ///</summary>
        public string Direction{ get; set; }
    }
}
