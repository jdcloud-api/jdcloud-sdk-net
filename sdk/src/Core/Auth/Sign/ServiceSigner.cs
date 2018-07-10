using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth.Sign
{

    /// <summary>
    /// service 签名认证信息
    /// </summary>
    public interface ServiceSigner:Signer
    {
        /// <summary>
        /// 设置serviceName
        /// </summary>
        /// <param name="serviceName"> 需要设置的 服务名称</param>
        void SetServiceName(String serviceName);
    }
}
