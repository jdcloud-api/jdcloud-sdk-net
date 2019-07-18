using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth
{
    /// <summary>
    /// 认证信息封装提供类
    /// </summary>
    public interface CredentialsProvider
    {
        /// <summary>
        /// 获取密钥信息
        /// </summary>
        /// <returns>密钥信息</returns>
        Credential GetCredentials();
    } 
}
