using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace JDCloudSDK.Core.Utils
{

    /// <summary>
    /// 加密工具
    /// </summary>
    public class EncryptUtils
    {
        /// <summary>
        /// 进行SHA256 hash 生成 并转换为16进制
        /// </summary>
        /// <param name="strIn">需要进行sha256 计算的字符串</param>
        /// <returns>生成字符数组的16进制字符串</returns>
        public static string SHA256Encrypt(string strIn)
        { 
            using (var sha256 = SHA256.Create())
            {
                byte[] encodeBytes = System.Text.Encoding.UTF8.GetBytes(strIn);
                byte[] bytes =  sha256.ComputeHash(encodeBytes);  
                return StringUtils.ByteToHex(bytes, true);
            } 
        }


    }
}
