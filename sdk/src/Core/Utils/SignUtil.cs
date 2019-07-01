using JDCloudSDK.Core.Common;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace JDCloudSDK.Core.Utils
{
    /// <summary>
    /// 签名工具类
    /// </summary>
    public class SignUtil
    {
        /// <summary>
        /// 方法描述：签名
        /// </summary>
        /// <param name="stringData">需要进行签名的数据</param>
        /// <param name="key">加密使用的key</param>
        /// <param name="algorithm">算法</param>
        /// <returns>签名计算的结果</returns>
        public static byte[] Sign(String stringData, byte[] key,
                           string algorithm)
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
        /// 进行SHA256 加密
        /// </summary>
        /// <param name="byteContent">需要计算的字节数组</param>
        /// <returns>转换后的字节数组</returns>
        public static byte[] SignHash(byte[] byteContent) {
            if (byteContent == null) {
                byteContent = new byte[0];
            }
            byte[] result = ComputeHashSha256(byteContent);
            return result;
        }

        /// <summary>
        /// 进行SHA256 加密
        /// </summary>
        /// <param name="strSrc">需要计算的字符串</param>
        /// <returns>转换后的字节数组</returns>
        public static byte[] SignHash(string strSrc)
        {
            byte[] byteArray;
 
            if (strSrc.IsNullOrWhiteSpace())
 
            {
                byteArray = new byte[0];
            }
            else
            {
                byteArray = System.Text.Encoding.UTF8.GetBytes(strSrc);
            } 
            return SignHash(byteArray); 
        }

        /// <summary>
        /// 计算sha256
        /// </summary>
        /// <param name="toBeHashed">要进行转换的byte数组</param>
        /// <returns>转换后的字节数组</returns>
        public static byte[] ComputeHashSha256(byte[] toBeHashed)
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
        public static byte[] HmacSha256(String data, byte[] key)
        {

            HMAC hmac = new HMACSHA256(key);
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
            return hmac.ComputeHash(bytes);
        }





        /// <summary>
        /// 方法描述：签名
        /// </summary>
        /// <param name="data">二进制数据</param>
        /// <param name="key">密钥</param>
        /// <param name="algorithm">算法</param>
        /// <returns>HMAC计算的结果</returns>
        public static byte[] Sign(byte[] data, byte[] key, string algorithm)
        {
            try
            {
                HMAC hMAC = GetSigningHMACAlgorithm(algorithm, key);
                return hMAC.ComputeHash(data);
            }
            catch (Exception e)
            {
                throw new Exception("Unable to calculate a request signature: ", e);
            }
        }


        /// <summary>
        /// 生成HMAC 算法实例
        /// </summary>
        /// <param name="algorithm">算法名称</param>
        /// <param name="key">需要使用的key</param>
        /// <returns>返回加密算法实例</returns>
        private static HMAC GetSigningHMACAlgorithm(string algorithm, byte[] key)
        {
            switch (algorithm.ToUpper())
            {
                case ParameterConstant.SIGN_SHA256:
                    return new HMACSHA256(key);
                case ParameterConstant.SIGN_SHA1:
                    return new HMACSHA1(key); 
                default:
                    return new HMACSHA256(key);
            } 
        }
    }
}
