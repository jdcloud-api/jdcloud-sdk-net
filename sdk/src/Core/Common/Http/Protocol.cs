using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace JDCloudSDK.Core.Http
{

    /// <summary>
    /// http 请求协议信息枚举 http or https
    /// </summary>
    public enum Protocol
    {

        /// <summary>
        /// 请求协议HTTP
        /// </summary>
        [Description("请求协议HTTP")]
        HTTP=1,

        /// <summary>
        /// 请求协议HTTPS
        /// </summary>
        [Description("请求协议HTTPS")]
        HTTPS =2
    }
}
