using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth
{
    /// <summary>
    /// 认证信息对象接口
    /// </summary>
    public abstract class Credential
    {
        /// <summary>
        /// 获取访问密钥
        /// </summary>
        public virtual string AccessKeyId { get; set; }

        /// <summary>
        /// 获取安全密钥
        /// </summary>
        public virtual string SecretAccessKey { get; set; }
    }
}
