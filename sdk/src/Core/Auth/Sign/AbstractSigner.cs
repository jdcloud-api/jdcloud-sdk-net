using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Core.Utils;

namespace JDCloudSDK.Core.Auth.Sign
{

    /// <summary>
    /// 抽象签名类
    /// </summary>
    public abstract class AbstractSigner : Signer
    {
        /// <summary>
        /// 空的SHA256 计算字符串
        /// </summary>
        public readonly String EMPTY_STRING_SHA256_HEX = EncryptUtils.SHA256Encrypt("");


        /// <summary>
        /// 进行签名调用的方法
        /// </summary>
        /// <param name="builder">request 构建对象</param>
        /// <param name="credentials">认证的akey 和 skey 信息</param>
        /// <returns>返回签名后的http 请求信息</returns>
        public abstract SdkHttpFullRequest Sign(SdkHttpFullRequestBuilder builder, Credentials credentials);


        /// <summary>
        /// Adds session credentials to the request given.
        /// </summary>
        /// <param name="mutableRequest">request 构建对象</param>
        /// <param name="credentials">session 认证的 akey 和 skey 信息</param>
        protected abstract void AddSessionCredentials(SdkHttpFullRequestBuilder mutableRequest,
                                                 SessionCredentials credentials);

        /// <summary>
        /// 方法描述：签名
        /// </summary>
        /// <param name="stringData">需要进行签名的数据</param>
        /// <param name="key">加密使用的key</param>
        /// <param name="algorithm">算法</param>
        /// <returns>签名计算的结果</returns>
        public byte[] Sign(String stringData, byte[] key,
                           SigningAlgorithm algorithm)
        {
            try
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(stringData);
                return Sign(data, key, algorithm);
            }
            catch (Exception e)
            {
                throw new Exception("Unable to calculate a request signature: ", e);
            }
        }




        /// <summary>
        /// 方法描述：签名
        /// </summary>
        /// <param name="data">二进制数据</param>
        /// <param name="key">密钥</param>
        /// <param name="algorithm">算法</param>
        /// <returns>HMAC计算的结果</returns>
        protected byte[] Sign(byte[] data, byte[] key, SigningAlgorithm algorithm)
        {
            try
            {
                HMAC hMAC = SigningAlgorithmHMACFactory.GetSigningHMACAlgorithm(algorithm, key);
                return hMAC.ComputeHash(data);
            }
            catch (Exception e)
            {
                throw new Exception("Unable to calculate a request signature: ", e);
            }
        }


        /// <summary>
        /// 进行证书类转换（从java 拷贝过来，感觉编译类型原因在dotnet 无用，目前做代码兼容保留）
        /// </summary>
        /// <param name="credentials">证书信息</param>
        /// <returns>证书信息</returns>
        protected Credentials SanitizeCredentials(Credentials credentials)
        {
            String accessKeyId = credentials.AccessKeyId().Trim();
            String secretKey = credentials.SecretAccessKey().Trim();
            if (credentials.GetType() == typeof(SessionCredentials))
            {
                SessionCredentials sessionCredentials = (SessionCredentials)credentials;
                return new SessionCredentials(accessKeyId,
                        secretKey, sessionCredentials.SessionToken().Trim());
            }
            return credentials;
        }

        /// <summary>
        /// 进行请求path 转换
        /// </summary>
        /// <param name="path">请求path</param>
        /// <param name="doubleUrlEncode">是否进行二次编码</param>
        /// <returns>转换后的path</returns>
        protected string GetCanonicalizedResourcePath(string path, bool doubleUrlEncode)
        {
#if NET35
            if (string.IsNullOrEmpty(path)||string.IsNullOrEmpty(path.Trim()))
#else
            if (string.IsNullOrWhiteSpace(path))
#endif            
            {
                return "/";
            }
            else
            {
                string value = doubleUrlEncode ? SdkHttpUtils.UrlEncode(path, true) : path;
                if (value.StartsWith("/"))
                {
                    return value;
                }
                else
                {
                    return $"/{value}";
                }
            }
        }




        /// <summary>
        /// 进行SHA256 加密
        /// </summary>
        /// <param name="strSrc">需要计算的字符串</param>
        /// <returns>转换后的字节数组</returns>
        protected static byte[] SignHash(String strSrc)
        {
            byte[] byteArray;
#if NET35
            if (string.IsNullOrEmpty(strSrc) || string.IsNullOrEmpty(strSrc.Trim()))
#else
            if (string.IsNullOrWhiteSpace(strSrc))
#endif
            {
                byteArray = new byte[0];
            }
            else
            {
                byteArray = System.Text.Encoding.UTF8.GetBytes(strSrc);
            }

            byte[] result = ComputeHashSha256(byteArray);
            return result;

        }

        /// <summary>
        /// 计算sha256
        /// </summary>
        /// <param name="toBeHashed">要进行转换的byte数组</param>
        /// <returns>转换后的字节数组</returns>
        protected static byte[] ComputeHashSha256(byte[] toBeHashed)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(toBeHashed);
            }
        }

        /// <summary>
        /// HmacSha256 加密
        /// </summary>
        /// <param name="data">需要进行HMACSHA256计算的数据</param>
        /// <param name="key">HMACSHA256 使用的key</param>
        /// <returns>返回计算后的字节数组</returns>
        protected static byte[] HmacSha256(String data, byte[] key)
        {

            HMAC hmac = new HMACSHA256(key);
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
            return hmac.ComputeHash(bytes);
        }


    }
}
