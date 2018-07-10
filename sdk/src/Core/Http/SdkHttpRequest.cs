
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace JDCloudSDK.Core.Http
{
    /// <summary>
    /// sdk http 请求签名需要的信息
    /// </summary>
    public interface SdkHttpRequest
    {
        /// <summary>
        /// 获取所有的请求头信息
        /// </summary>
        /// <returns>请求头信息</returns>
        Dictionary<string,List<string>> GetHeaders();

        /// <summary>
        /// 获取请求资源路径
        /// </summary>
        /// <returns>请求资源路径</returns>
        string GetResourcePath();

        /// <summary>
        /// 获取所有的请求参数字典
        /// </summary>
        /// <returns>请求参数字典</returns> 
        string GetParameters();

        /// <summary>
        /// 返回服务端点 请求发送的服务端点
        /// </summary>
        /// <returns>请求发送的服务端点</returns>
        Uri GetEndpoint();

        /// <summary>
        /// 获取 发送请求的方法
        /// </summary>
        /// <returns>发送请求的方法</returns>
        SdkHttpMethod GetHttpMethod();



    }
}
