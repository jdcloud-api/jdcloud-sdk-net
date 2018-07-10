using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Utils;

namespace JDCloudSDK.Core.Auth
{
    /// <summary>
    /// Session Credentials
    /// </summary>
    public class SessionCredentials :Credentials
    {
        /// <summary>
        /// session token
        /// </summary>
        private readonly string _sessionToken;


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="accessKeyId">访问密钥</param>
        /// <param name="secretAccessKey">安全密钥</param>
        /// <param name="sessionToken">session token</param>
        public SessionCredentials(string accessKeyId, string secretAccessKey,string sessionToken) : base(accessKeyId, secretAccessKey)
        {
            this._sessionToken = Validate.NotNull(sessionToken, "Session token cannot be null.");
        }

        /// <summary>
        /// 获取session token
        /// </summary>
        /// <returns>返回session证书信息</returns>
        public string SessionToken()
        {
            return _sessionToken;
        }


        /// <summary>
        /// 重写equals 方法，进行相等的判断
        /// </summary>
        /// <param name="obj">SessionCredentials 对象</param>
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
            SessionCredentials that = (SessionCredentials)obj;
            return this._sessionToken == that._sessionToken && 
                this.AccessKeyId()== that.AccessKeyId()&& 
                this.SecretAccessKey() == that.SecretAccessKey();

        }

        /// <summary>
        /// 因为重写equals 方法 重写 gethashcode 方法
        /// </summary>
        /// <returns>获取hash code</returns>
        public override int GetHashCode()
        {
            int hashCode = base.GetHashCode();
            if (this._sessionToken.GetHashCode() != hashCode)
                hashCode ^= _sessionToken.GetHashCode();
            return hashCode;

        }

    }
}
