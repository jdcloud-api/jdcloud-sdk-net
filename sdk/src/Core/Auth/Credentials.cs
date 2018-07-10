using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Utils;

namespace JDCloudSDK.Core.Auth
{
    /// <summary>
    /// 证书认证参数
    /// </summary>
    public class Credentials : ICredentials
    {
        /// <summary>
        /// 访问秘钥
        /// </summary>
        private readonly string _accessKeyId;//访问秘钥

        /// <summary>
        /// 验证秘钥
        /// </summary>
        private readonly  string _secretAccessKey;//验证秘钥 

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="accessKeyId">访问秘钥</param>
        /// <param name="secretAccessKey">验证秘钥</param>
        public Credentials(string accessKeyId, string secretAccessKey):this(accessKeyId,secretAccessKey,true)
        { 
        }

        /// <summary>
        /// 私有构造方法，主要按照java基础封装
        /// </summary>
        /// <param name="accessKeyId">访问秘钥</param>
        /// <param name="secretAccessKey">验证秘钥</param>
        /// <param name="validateCredentials">是否进行参数验证</param>
        private Credentials(string accessKeyId, string secretAccessKey, bool validateCredentials)
        {
#if NET35
            this._accessKeyId = string.IsNullOrEmpty(accessKeyId)|| string.IsNullOrEmpty(accessKeyId.Trim()) ? null:accessKeyId.Trim();
            this._secretAccessKey = string.IsNullOrEmpty(secretAccessKey) || string.IsNullOrEmpty(secretAccessKey.Trim()) ? null : secretAccessKey.Trim();
#else

            this._accessKeyId = string.IsNullOrWhiteSpace(accessKeyId)?null:accessKeyId.Trim();
            this._secretAccessKey = string.IsNullOrWhiteSpace(secretAccessKey) ? null : secretAccessKey.Trim();
#endif
            if (validateCredentials)
            {
                Validate.NotNull<string>(this._accessKeyId, "Access key ID cannot be blank.");
                Validate.NotNull<string>(this._secretAccessKey, "Secret access key cannot be blank.");
                
            }

        }

        /// <summary>
        /// 获取访问密钥
        /// </summary>
        /// <returns>访问密钥</returns>
        public string AccessKeyId()
        {
            return this._accessKeyId;
        }

        /// <summary>
        /// 获取 验证密钥
        /// </summary>
        /// <returns>验证密钥</returns>
        public string SecretAccessKey()
        {
            return this._secretAccessKey;
        }

        /// <summary>
        /// 重写 to String 方法
        /// </summary>
        /// <returns>实例字符串</returns>
        public override string ToString()
        {
            return this.GetType().Name + "(" + this._accessKeyId + ")"; ;
        }

        /// <summary>
        /// 重写equals 方法，进行相等的判断
        /// </summary>
        /// <param name="obj">Credentials 对象</param>
        /// <returns>是否相等</returns>
        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Credentials that = (Credentials)obj;
            return this._accessKeyId == that._accessKeyId &&
                   this._secretAccessKey == that._secretAccessKey;
            
        }

        /// <summary>
        /// 因为重写equals 方法 重写 gethashcode 方法
        /// </summary>
        /// <returns>对象的hashcode  值信息</returns>
        public override int GetHashCode()
        {
            int hashCode = this._accessKeyId.GetHashCode();
            if (this._accessKeyId.GetHashCode() != this._secretAccessKey.GetHashCode())
                hashCode ^= _secretAccessKey.GetHashCode();
            return hashCode;
          
        }
    }
}
