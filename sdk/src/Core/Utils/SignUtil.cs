using JDCloudSDK.Core.Auth.Sign;
using JDCloudSDK.Core.Common;
using JDCloudSDK.Core.Model;
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
        /// get signer
        /// </summary>
        /// <param name="jDCloudSignVersionType"></param>
        /// <returns></returns>
        public static IJDCloudSigner GetJDCloudSigner(JDCloudSignVersionType jDCloudSignVersionType)
        {
            switch (jDCloudSignVersionType)
            {
                case JDCloudSignVersionType.JDCloud_V2:
                    return new JDCloudSigner();
                case JDCloudSignVersionType.JDCloud_V3:
                    return new JDCloudSignerV3();
                default:
                    return new JDCloudSignerV3();
            }
        }


        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestParameters"> request query string</param>
        /// <param name="contentSha256"> request content sha 256</param>
        /// <param name="requestPath">request source path</param>
        /// <param name="httpMethod">request method</param>
        /// <param name="signHeaderString"> sign header string</param>
        /// <param name="signHeaderKeyString"> the header key which header signed</param>
        /// <returns></returns>
        public static string CreateCanonicalRequest(string requestParameters,string requestPath,string httpMethod,
            string signHeaderString,string signHeaderKeyString, string contentSha256)
        { 
            string canonicalRequest = new StringBuilder(httpMethod)
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(requestPath)
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(requestParameters)
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(signHeaderString)
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(signHeaderKeyString)
                .Append(ParameterConstant.LINE_SEPARATOR)
                .Append(contentSha256)
                .ToString();
            return canonicalRequest;
        }


        /// <summary>
        ///  获得待计算签名的字符串
        /// </summary>
        /// <param name="canonicalRequest">canonicalRequest 字符串</param>
        /// <param name="formattedSigningDateTime">签名时间信息</param>
        /// <param name="scope">签名 scope 信息</param>
        /// <param name="signingAlgorithm">jd cloud signing algorithm</param>
        /// <returns>计算签名的字符串</returns>
        public static string CreateStringToSign(string canonicalRequest,
                                     string formattedSigningDateTime, string scope,string signingAlgorithm)
        {
            string stringToSign = new StringBuilder(signingAlgorithm)
                  .Append(ParameterConstant.LINE_SEPARATOR)
                  .Append(formattedSigningDateTime)
                  .Append(ParameterConstant.LINE_SEPARATOR)
                  .Append(scope)
                  .Append(ParameterConstant.LINE_SEPARATOR)
                  .Append(StringUtils.ByteToHex(SignUtil.SignHash(canonicalRequest), true))
                  .ToString();
            return stringToSign;
        }

        /// <summary>
        /// 计算签名
        /// </summary>
        /// <param name="stringToSign">需要签名的字符串</param>
        /// <param name="signingKey">签名使用的key</param>
        /// <returns>签名后的字节数组信息</returns>
        public static byte[] ComputeSignature(string stringToSign, byte[] signingKey)
        {
            byte[] stringToSignBytes = System.Text.Encoding.UTF8.GetBytes(stringToSign);
            return SignUtil.Sign(stringToSignBytes, signingKey, ParameterConstant.SIGN_SHA256);
        }



        /// <summary>
        /// 计算http content SHA256 hash 校验值
        /// </summary>
        /// <param name="content">http  请求body信息</param>
        /// <returns>计算后的16进制加密的 content 信息</returns>
        public static string CalculateContentHash(byte[] content)
        {
            try
            { 
                if (content == null || content.Length <= 0)
                {
                    content = new byte[0];
                }
                string contentSha256 = StringUtils.ByteToHex(SignUtil.SignHash(content), true);
                return contentSha256;

            }
            catch (Exception ex)
            {

                throw new Exception("get the request content sha256 error", ex);
            }
        }

        /// <summary>
        /// Returns the scope to be used for the signing.
        /// </summary>
        /// <param name="dateStamp">日期戳</param>
        /// <param name="serviceName">服务名</param>
        /// <param name="regionName">区域名</param>
        /// <param name="jdcloudTerminator">jdcloud terminator</param>
        /// <returns>Scope 字符串</returns>
        public static string GenerateScope(string dateStamp, string serviceName, string regionName,string jdcloudTerminator)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(dateStamp)
                .Append("/")
                .Append(regionName)
                .Append("/")
                .Append(serviceName)
                .Append("/")
                .Append(jdcloudTerminator);
            return stringBuilder.ToString();
        }
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
