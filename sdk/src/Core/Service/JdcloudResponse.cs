using JDCloudSDK.Core.Model;
using JDCloudSDK.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Service
{
    /// <summary>
    /// 请求的返回信息
    /// </summary>
    /// <typeparam name="R">请求应返回的结果信息</typeparam>
    public class JdcloudResponse<R> where R: JdcloudResult
    {
        /// <summary>
        /// 请求的request id
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// 请求的错误信息
        /// </summary>
        public ServiceError Error { get; set; }

        /// <summary>
        /// 请求的结果信息
        /// </summary>
        public R Result { get; set; } 

        public HttpSDKResponse HttpResponse { get; set; }
    }
}
