using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Model
{
    /// <summary>
    /// 请求结果返回的错误信息
    /// </summary>
    public class ServiceError
    {
        /// <summary>
        /// 错误编号
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///  错误详细信息
        /// </summary>
        public Dictionary<string, string>[] Details {get;set;}
    }
}
