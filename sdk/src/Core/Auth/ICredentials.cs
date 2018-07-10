using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth
{
    /// <summary>
    /// 认证信息对象接口
    /// </summary>
    public interface ICredentials
    {

        /// <summary>
        /// 获取访问密钥
        /// </summary>
        /// <returns>访问密钥</returns>
        String AccessKeyId();

        /// <summary>
        ///  获取安全密钥
        /// </summary>
        /// <returns>安全密钥</returns>
        String SecretAccessKey();
    }
}
