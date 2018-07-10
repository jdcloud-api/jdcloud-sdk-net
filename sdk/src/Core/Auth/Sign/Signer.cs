using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth.Sign
{
    /// <summary>
    /// 签名根接口
    /// </summary>
    public interface Signer
    {
        /// <summary>
        /// 使用凭据签名请求
        /// </summary>
        /// <param name="builder">SdkHttpFullRequest builder</param>
        /// <param name="credentials">认证信息</param>
        /// <returns>返回包含签名的Http 请求信息</returns>
        SdkHttpFullRequest Sign(SdkHttpFullRequestBuilder builder, Credentials credentials);
    }
}
