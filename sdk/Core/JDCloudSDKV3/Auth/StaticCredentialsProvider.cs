using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDKV3.Auth
{
    /// <summary>
    /// 静态认证信息提供类
    /// </summary>
    public class StaticCredentialsProvider : CredentialsProvider
    {
        /// <summary>
        /// 认证信息
        /// </summary>
        private Credential credential;

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="accessKeyId">访问密钥</param>
        /// <param name="secretKey">验证密钥</param>
        public StaticCredentialsProvider(String accessKeyId, String secretKey)
        {
            credential = new StaticCredential(accessKeyId, secretKey);
        }

        /// <summary>
        /// 获取认证信息参数
        /// </summary>
        /// <returns>认证信息</returns>
        public Credential GetCredentials()
        {
            return this.credential;
        }

        /// <summary>
        /// 静态认证信息
        /// </summary>
        private class StaticCredential : Credential
        {
            private StaticCredential() {
            }
            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="accessKeyId">访问密钥</param>
            /// <param name="secretKey">验证密钥</param>
            public StaticCredential(string accessKeyId, string secretKey)
            {
                this.AccessKeyId = accessKeyId;
                this.SecretAccessKey = secretKey;
            }

            

        }
    }
}
