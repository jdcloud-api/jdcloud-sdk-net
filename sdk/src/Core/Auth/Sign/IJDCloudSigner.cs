using JDCloudSDK.Core.Model;
using JDCloudSDK.Core.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Core.Auth.Sign
{
    /// <summary>
    /// 签名实现接口
    /// </summary>
    public interface IJDCloudSigner
    {
        /// <summary>
        /// 标准签名方法接口
        /// </summary>
        /// <param name="requestModel">签名参数类</param>
        /// <param name="credentials">认证信息</param>
        /// <returns></returns>
        SignedRequestModel Sign(RequestModel requestModel, Credential credentials);


        SignedRequestModel Sign(string requestUrl, string serviceName, string httpRequestMethod,
            string regionName, string apiVersion, Credential credentials,  byte[] content, 
            string contentType, Dictionary<string, List<string>> header, DateTime? overrddenDate = null);

    }
}
