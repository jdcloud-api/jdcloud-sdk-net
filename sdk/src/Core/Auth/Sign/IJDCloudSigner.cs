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

        /// <summary>
        /// sign with all param 
        /// </summary>
        /// <param name="host"> request host</param>
        /// <param name="port"> request port</param>
        /// <param name="path"> request path</param>
        /// <param name="queryString">request query string</param>
        /// <param name="serviceName">the request service name</param>
        /// <param name="httpRequestMethod">the request http method</param>
        /// <param name="regionName">the source region name</param>
        /// <param name="apiVersion">the api version</param>
        /// <param name="credentials">the jdcloud credentials</param>
        /// <param name="content">the request body content</param>
        /// <param name="contentType">the request body content type</param>
        /// <param name="header">the request header</param>
        /// <param name="nonceId">the request nonce id</param>
        /// <param name="overrddenDate">the sgin overrdden date</param>
        /// <returns></returns>
        SignedRequestModel Sign(string host,string port ,string path,string queryString, string serviceName, 
            string httpRequestMethod,
            string regionName, string apiVersion, Credential credentials,  byte[] content, 
            string contentType, Dictionary<string, List<string>> header,string nonceId, DateTime? overrddenDate = null);

    }
}
