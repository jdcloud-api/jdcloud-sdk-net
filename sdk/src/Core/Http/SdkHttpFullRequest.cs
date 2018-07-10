using JDCloudSDK.Core.Builder;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace JDCloudSDK.Core.Http
{
    /// <summary>
    /// 请求对象接口
    /// </summary>
    public interface SdkHttpFullRequest:SdkHttpRequest
    {
        /// <summary>
        /// 获取请求对象http content 内容
        /// </summary>
        /// <returns>http content 内容</returns>
        string GetContent();  
    }

    /// <summary>
    /// 请求信息构造接口
    /// </summary>
    public  interface SdkHttpFullRequestBuilder : SdkHttpRequest, SdkBuilder<SdkHttpFullRequest>
    {
        /// <summary>
        /// 设置头信息
        /// </summary>
        /// <param name="key">要设置的http header 的key </param>
        /// <param name="value">要设置的http header 的value </param>
        /// <returns>请求信息构造接口</returns>
        SdkHttpFullRequestBuilder Header(String key, String value);

        /// <summary>
        /// 设置头信息
        /// </summary>
        /// <param name="key">要设置的http header 的key</param>
        /// <param name="values">要设置的http header 的value  列表对象</param>
        /// <returns>请求信息构造接口</returns>
        SdkHttpFullRequestBuilder Header(String key, List<String> values);

        /// <summary>
        /// 设置头信息
        /// </summary>
        /// <param name="headers">头信息字典</param>
        /// <returns>请求信息构造接口</returns>
        SdkHttpFullRequestBuilder Headers(Dictionary<string,List<string>> headers);

        /// <summary>
        /// 设置请求资源的地址
        /// </summary>
        /// <param name="resourcePath">请求资源的地址</param>
        /// <returns>请求信息构造接口</returns>
        SdkHttpFullRequestBuilder ResourcePath(String resourcePath);

        /// <summary>
        /// 清除请求资源的参数
        /// </summary>
        /// <returns>请求信息构造接口</returns>
        SdkHttpFullRequestBuilder ClearQueryParameters();

        /// <summary>
        /// 设置请求地址的get 参数
        /// </summary>
        /// <param name="queryParameter"></param>
        /// <returns>请求信息构造接口</returns>
        SdkHttpFullRequestBuilder QueryParameter(string queryParameter);


        /// <summary>
        /// 设置终结点信息
        /// </summary>
        /// <param name="endpoint">终结点信息</param>
        /// <returns>请求信息构造接口</returns>
        SdkHttpFullRequestBuilder Endpoint(Uri endpoint);

        /// <summary>
        /// 设置请求方法
        /// </summary>
        /// <param name="httpMethod">请求方法枚举</param>
        /// <returns>请求信息构造接口</returns>
        SdkHttpFullRequestBuilder HttpMethod(SdkHttpMethod httpMethod);
        /// <summary>
        /// 设置请求的http content 内容
        /// </summary>
        /// <param name="content">http content 内容</param>
        /// <returns>请求信息构造接口</returns>
        SdkHttpFullRequestBuilder Content(string content);

        /// <summary>
        /// 获取http content 内容
        /// </summary>
        /// <returns>http content 内容</returns>
        string GetContent();

    }
}
