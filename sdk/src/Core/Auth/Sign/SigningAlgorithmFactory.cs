using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace JDCloudSDK.Core.Auth.Sign
{
    /// <summary>
    /// HMAC算法工厂
    /// </summary>
    public class SigningAlgorithmHMACFactory
    {
        /// <summary>
        /// 生成HMAC 算法实例
        /// </summary>
        /// <param name="signingAlgorithm">算法名称枚举</param>
        /// <param name="key">需要使用的key</param>
        /// <returns>返回加密算法实例</returns>
        public static HMAC GetSigningHMACAlgorithm(SigningAlgorithm signingAlgorithm,byte[] key)
        {
            switch (signingAlgorithm)
            {
                case SigningAlgorithm.HMACSHA256:
                    return new HMACSHA256(key);
                case SigningAlgorithm.HMACSHA1:
                    return new HMACSHA1(key);
                case SigningAlgorithm.HMACSHA384:
                    return new HMACSHA384(key);
                case SigningAlgorithm.HMACSHA512:
                    return new HMACSHA512(key);
                case SigningAlgorithm.HMACMD5: 
                    return new HMACMD5(key);
                default:
                    return new HMACMD5(key);
            }

        }
    }
}
