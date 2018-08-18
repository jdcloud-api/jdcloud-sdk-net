using JDCloudSDK.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth
{
    /// <summary>
    /// Session Credentials
    /// </summary>
    public sealed class SessionCredentials :Credential
    {
        /// <summary>
        /// session token
        /// </summary>
        public string SessionToken { get; set; }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="accessKeyId">访问密钥</param>
        /// <param name="secretAccessKey">安全密钥</param>
        /// <param name="sessionToken">session token</param>
        public SessionCredentials(string accessKeyId, string secretAccessKey, string sessionToken)  
        {
#if NET35
            AccessKeyId = string.IsNullOrEmpty(accessKeyId)|| string.IsNullOrEmpty(accessKeyId.Trim()) ? null:accessKeyId.Trim();
            SecretAccessKey = string.IsNullOrEmpty(secretAccessKey) || string.IsNullOrEmpty(secretAccessKey.Trim()) ? null : secretAccessKey.Trim();
            SessionToken = string.IsNullOrEmpty(sessionToken)|| string.IsNullOrEmpty(sessionToken.Trim()) ? null:sessionToken.Trim();
#else

            AccessKeyId = string.IsNullOrWhiteSpace(accessKeyId) ? null : accessKeyId.Trim();
            SecretAccessKey = string.IsNullOrWhiteSpace(secretAccessKey) ? null : secretAccessKey.Trim();
            SessionToken = string.IsNullOrWhiteSpace(sessionToken) ? null : sessionToken.Trim();
#endif 
            Validate.NotNull<string>(this.AccessKeyId, "Access key ID cannot be blank.");
            Validate.NotNull<string>(this.SecretAccessKey, "Secret access key cannot be blank.");
            Validate.NotNull(sessionToken, "Session token cannot be null.");
        }

        /// <summary>
        /// 重写 to String 方法
        /// </summary>
        /// <returns>实例字符串</returns>
        public override string ToString()
        {
            return this.GetType().Name + "(" + this.AccessKeyId + ")"; ;
        }

    }
}
