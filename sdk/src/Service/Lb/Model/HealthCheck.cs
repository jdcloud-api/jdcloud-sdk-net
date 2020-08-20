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
    ///  healthCheck
    /// </summary>
    public class HealthCheck
    {

        ///<summary>
        /// 健康检查协议 &lt;br&gt;【alb、nlb】取值为Http, Tcp &lt;br&gt;【dnlb】取值为Tcp
        ///</summary>
        public string Protocol{ get; set; }
        ///<summary>
        /// 健康阀值，&gt;&#x3D;1，默认为3
        ///</summary>
        public int? HealthyThresholdCount{ get; set; }
        ///<summary>
        /// 不健康阀值，&gt;&#x3D;1, 默认为3
        ///</summary>
        public int? UnhealthyThresholdCount{ get; set; }
        ///<summary>
        /// 响应超时时间, 取值范围为[2,60]，默认为3s
        ///</summary>
        public int? CheckTimeoutSeconds{ get; set; }
        ///<summary>
        /// 健康检查间隔, 范围为[5,300], 默认为5s
        ///</summary>
        public int? IntervalSeconds{ get; set; }
        ///<summary>
        /// 检查端口, 取值范围为[0,65535], 默认为0，默认端口为每个后端实例接收负载均衡流量的端口
        ///</summary>
        public int? Port{ get; set; }
        ///<summary>
        /// 【Http协议】检查域名，支持输入域名和IP地址。如果输入域名，仅支持大小写字母、数字、英文中划线&quot;-&quot;和点&quot;.&quot;，不区分大小写，且不超过255个字符。默认为空，表示健康检查不携带域名
        ///</summary>
        public string HttpDomain{ get; set; }
        ///<summary>
        /// 【Http协议】检查路径, 健康检查的目标路径，必须以&quot;/&quot;开头，允许输入具体的文件路径，默认为根目录
        ///</summary>
        public string HttpPath{ get; set; }
        ///<summary>
        /// 【Http协议】检查来自后端目标服务器的成功响应时，要使用的HTTP状态码。您可以指定：单个数值（例如：&quot;200&quot;，取值范围200-499）、一段连续数值（例如：&quot;201-205&quot;，取值范围范围200-499，且前面的参数小于后面）和一类连续数值缩写（例如：&quot;3xx&quot;，等价于&quot;300-399&quot;，取值范围2xx、3xx和4xx）。多个数值之间通过&quot;,&quot;分割（例如：&quot;200,202-207,302,4xx&quot;）。目前仅支持2xx、3xx、4xx。
        ///</summary>
        public List<string> HttpCode{ get; set; }
    }
}
