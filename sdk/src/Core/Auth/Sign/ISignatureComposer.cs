using JDCloudSDK.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth.Sign
{

    /// <summary>
    /// 进行签名认证的接口
    /// </summary>
    public interface ISignatureComposer
    {
        /// <summary>
        /// 方法描述：签名
        /// </summary>
        /// <param name="signRequest">signRequest 签名信息对象</param>
        /// <returns>返回签名后的头信息</returns>
        Dictionary<string, string> Sign(SignRequest signRequest);
    }
}
