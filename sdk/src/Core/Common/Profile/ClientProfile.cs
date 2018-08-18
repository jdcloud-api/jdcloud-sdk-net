using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Common.Profile
{
    /// <summary>
    /// 客户端配置信息
    /// </summary>
    public class ClientProfile
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ClientProfile()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="signMethod">签名方法</param>
        /// <param name="httpProfile">HttpProfile实例</param>
        public ClientProfile(string signMethod, HttpProfile httpProfile)
        {
            this.SignMethod = signMethod;
            this.HttpProfile = httpProfile;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="httpProfile"></param>
        public ClientProfile(HttpProfile httpProfile) : this(SIGN_SHA256, httpProfile)
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="signMethod">签名方法</param>
        public ClientProfile(string signMethod)
            : this(signMethod, new HttpProfile())
        {

        }

        /// <summary>
        /// http 配置选项 请参考<seealso cref="HttpProfile"/>
        /// </summary>
        public HttpProfile HttpProfile { get; set; }

        /// <summary>
        /// 签名方法 目前仅支持 HmacSHA256
        /// </summary>
        public string SignMethod { get; set; } = SIGN_SHA256;

        /// <summary>
        /// HmacSHA1签名方法
        /// </summary>
        public const string SIGN_SHA1 = "HmacSHA1";

        /// <summary>
        /// HmacSHA256签名方法
        /// </summary>
        public static string SIGN_SHA256 = "HmacSHA256";
    }
}
