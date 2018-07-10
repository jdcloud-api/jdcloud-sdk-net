using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth
{
    /// <summary>
    /// 静态认证信息提供类
    /// </summary>
    public class StaticCredentialsProvider : CredentialsProvider
    {
        /// <summary>
        /// 认证信息
        /// </summary>
        private ICredentials credential;

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
        public ICredentials GetCredentials()
        {
            return this.credential;
        }

        /// <summary>
        /// 静态认证信息
        /// </summary>
        private class StaticCredential : ICredentials
        {
            /// <summary>
            /// 访问密钥
            /// </summary>
            private String _accessKeyId;
            /// <summary>
            /// 验证密钥
            /// </summary>
            private String _secretAccessKey;

            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="accessKeyId">访问密钥</param>
            /// <param name="secretKey">验证密钥</param>
            public StaticCredential(String accessKeyId, String secretKey)
            {
                this._accessKeyId = accessKeyId;
                this._secretAccessKey = secretKey;
            }

            /// <summary>
            /// 访问密钥 从jdcloud 官网获取
            /// </summary>
            /// <returns>访问密钥</returns>
            public String AccessKeyId()
            {
                return _accessKeyId;
            }

            /// <summary>
            /// 验证密钥 从jdcloud 官网获取
            /// </summary>
            /// <returns>验证密钥</returns>
            public String SecretAccessKey()
            {
                return _secretAccessKey;
            }

        }
    }
}
