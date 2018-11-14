using JDCloudSDK.Core.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth.Sign
{
    /// <summary>
    /// 京东云网关签名类
    /// </summary>
    public class JDCloudSigner
    {
        /// <summary>
        /// 要进行忽略的签名头信息
        /// </summary>
        private static readonly string[] LIST_OF_HEADERS_TO_IGNORE_IN_LOWER_CASE = { "connection","x-jdcloud-trace-id"};

        /// <summary>
        /// 服务名称
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 可用区名称
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        ///  重写日期信息
        /// </summary>
        public DateTime? OverrddenDate { get; set; } = null;

        /// <summary>
        /// URL 进行二次加密
        /// </summary>
        public bool DoubleUrlEncode { get; set; }=false;
        
        /// <summary>
        /// 签名注释
        /// </summary>
        public JDCloudSigner()
        {
        }

        /// <summary>
        /// 进行二次url endcode 加密的签名
        /// </summary>
        /// <param name="doubleUrlEncode"></param>
        public JDCloudSigner(bool doubleUrlEncode)
        {
             DoubleUrlEncode = doubleUrlEncode;
        }

        /// <summary>
        /// 进行请求签名
        /// </summary>
        /// <param name="requestModel"></param>
        /// <param name="credentials"></param>
        /// <returns></returns>
        public RequestModel Sign(RequestModel requestModel, Credentials credentials) {
            return null;
        }



    }

}
