using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace JDCloudSDK.Core.Auth.Sign
{
    /// <summary>
    /// 加密算法枚举，java 内包含Mac加密实例获取 .net 使用的是静态方法，不需要进行
    /// 因此，这个方法编写留着以后扩展
    /// </summary>
    public enum SigningAlgorithm
    {

        /// <summary>
        /// mac 加密算法 SHA1 协议
        /// </summary>
        [Description("mac 加密算法 SHA1 协议")]
        HMACSHA1 =1,

        /// <summary>
        /// mac 加密算法 SHA256 协议
        /// </summary>
        [Description("mac 加密算法 SHA256 协议")]
        HMACSHA256 = 2,

        /// <summary>
        /// mac 加密算法 SHA384  协议
        /// </summary>
        [Description("mac 加密算法 SHA384  协议")]
        HMACSHA384 =3,



        /// <summary>
        /// mac 加密算法 SHA512 协议
        /// </summary>
        [Description("mac 加密算法 SHA512 协议")]
        HMACSHA512 =4,


        /// <summary>
        /// mac 加密算法 MD5 协议
        /// </summary>
        [Description("mac 加密算法 MD5 协议")]
        HMACMD5 =5,

    }
}
