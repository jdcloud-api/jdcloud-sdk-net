using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace JDCloudSDK.Core.Http
{
    /// <summary>
    /// sdk请求的方法枚举
    /// </summary>
    public enum SdkHttpMethod
    {
        /// <summary>
        /// Http Get 请求
        /// </summary>
        [Description("Http Get 请求")]
        GET=1,

        /// <summary>
        /// Http Post 请求
        /// </summary>
        [Description("Http Post 请求")]
        POST =2,

        /// <summary>
        /// Http put 请求
        /// </summary>
        [Description("Http put 请求")]
        PUT =3,

        /// <summary>
        /// Http delete 
        /// </summary>
        [Description("Http delete 请求")]
        DELETE =4,

        /// <summary>
        /// Http head 请求
        /// </summary>
        [Description("Http head 请求")]
        HEAD=5,

        /// <summary>
        /// Http patch 请求
        /// </summary>
        [Description("Http patch 请求")]
        PATCH =6,

        /// <summary>
        /// Http options 请求
        /// </summary>
        [Description("Http options 请求")]
        OPTIONS =7
    }
}
