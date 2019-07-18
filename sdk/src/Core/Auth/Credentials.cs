using JDCloudSDK.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth
{
    /// <summary>
    /// 证书认证参数
    /// </summary>
    public   class Credentials : Credential
    {


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="accessKeyId">访问秘钥</param>
        /// <param name="secretAccessKey">验证秘钥</param>
        public Credentials(string accessKeyId, string secretAccessKey) : this(accessKeyId, secretAccessKey, true)
        {

        }



        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="accessKeyId"></param>
        /// <param name="secretAccessKey"></param>
        /// <param name="validateCredentials"></param>
        public Credentials(string accessKeyId, string secretAccessKey, bool validateCredentials)
        {

#if NET35
            this.AccessKeyId = string.IsNullOrEmpty(accessKeyId)|| string.IsNullOrEmpty(accessKeyId.Trim()) ? null:accessKeyId.Trim();
            this.SecretAccessKey = string.IsNullOrEmpty(secretAccessKey) || string.IsNullOrEmpty(secretAccessKey.Trim()) ? null : secretAccessKey.Trim();
#else

            this.AccessKeyId = string.IsNullOrWhiteSpace(accessKeyId) ? null : accessKeyId.Trim();
            this.SecretAccessKey = string.IsNullOrWhiteSpace(secretAccessKey) ? null : secretAccessKey.Trim();
#endif
 
            if (validateCredentials)
            {
                Validate.NotNull<string>(this.AccessKeyId, "Access key ID cannot be blank.");
                Validate.NotNull<string>(this.SecretAccessKey, "Secret access key cannot be blank.");

            }
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
