using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Auth.Sign;
using JDCloudSDK.Core.Common;
using JDCloudSDK.Core.Model;
using JDCloudSDK.Core.ServiceModel;
using JDCloudSDK.Core.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#if NET35 || NET40
using System.Net;
#else
using System.Net.Http;
#endif
using System.Text;

namespace JDCloudSDK.Core.Extensions
{
    /// <summary>
    /// http 请求客户端签名扩展类
    /// </summary>
    public static class HttpExtensions
    {

#if NET35 || NET40

        /// <summary>
        /// 扩展签名方法
        /// </summary>
        /// <param name="httpWebRequest">当前请求客户端</param>
        /// <param name="credentials">认证参数信息</param>
        /// <param name="bodyContent"></param>
        /// <param name="serviceName"></param>
        /// <param name="signType"></param>
        /// <param name="overrideDate"></param>
        /// <param name="isWriteBody"></param>
        /// <returns></returns>
        public static HttpWebRequest DoSign(this HttpWebRequest httpWebRequest, Credentials credentials,object bodyContent,bool isWriteBody =false,string serviceName= null,string signType = null, DateTime? overrideDate = null) {
            var byteContent = new byte[0];
            if (bodyContent != null) {
                if (isWriteBody)
                { 
                    var httpRequestWrite = httpWebRequest.GetRequestStream();

                    if (bodyContent is byte[])
                    {
                         byteContent = (byte[])bodyContent;
                        httpRequestWrite.Write(byteContent, 0, byteContent.Length);
                    }
                    else if (bodyContent is string)
                    {
                         byteContent = System.Text.Encoding.UTF8.GetBytes((string)bodyContent);
                        httpRequestWrite.Write(byteContent, 0, byteContent.Length);
                    }
                    else if (bodyContent is int || bodyContent is long || bodyContent is bool || bodyContent is float || bodyContent is double)
                    {  
                        if (bodyContent is int)
                        {
                            byteContent = BitConverter.GetBytes((int)bodyContent);
                        }
                        else if (bodyContent is long)
                        {
                            byteContent = BitConverter.GetBytes((long)bodyContent);
                        }
                        else if (bodyContent is bool)
                        {
                            byteContent = BitConverter.GetBytes((bool)bodyContent);
                        }
                        else if (bodyContent is float)
                        {
                            byteContent = BitConverter.GetBytes((float)bodyContent);
                        }
                        else if (bodyContent is double)
                        {
                            byteContent = BitConverter.GetBytes((double)bodyContent);
                        } 
                        httpRequestWrite.Write(byteContent, 0, byteContent.Length);
                    }
                    else if (bodyContent is JdcloudRequest)
                    {
                        var requestJson = JsonConvert.SerializeObject(bodyContent);
                        if (!requestJson.IsNullOrWhiteSpace())
                        {
                            byteContent = System.Text.Encoding.UTF8.GetBytes((string)bodyContent);
                            httpRequestWrite.Write(byteContent, 0, byteContent.Length);
                        }
                    }
                    else
                    {
                        var requestJson = JsonConvert.SerializeObject(bodyContent);
                        if (!requestJson.IsNullOrWhiteSpace())
                        {
                            byteContent = System.Text.Encoding.UTF8.GetBytes((string)bodyContent);
                            httpRequestWrite.Write(byteContent, 0, byteContent.Length);
                        }
                    }
                }
            }
            var headers = httpWebRequest.Headers;
            var requestUri = httpWebRequest.RequestUri;
            var queryString = requestUri.Query;
            var requestPath = requestUri.AbsolutePath;
            var requestContent =  bodyContent;
            var requestMethod = httpWebRequest.Method;
            string apiVersion = requestUri.GetRequestVersion();
            RequestModel requestModel = new RequestModel();
            requestModel.ApiVersion = apiVersion;
           
            requestModel.ContentType = httpWebRequest.ContentType.ToString();
            requestModel.HttpMethod = requestMethod.ToString().ToUpper();
            var pathRegion = requestUri.GetRequestVersion();
            if (!pathRegion.IsNullOrWhiteSpace())
            {
                requestModel.RegionName = pathRegion;
            }
            else
            {
                requestModel.RegionName = ParameterConstant.DEFAULT_REGION;
            }

            requestModel.ResourcePath = requestPath;
            if (!serviceName.IsNullOrWhiteSpace())
            {
                requestModel.ServiceName = serviceName;
            }
            else
            {
                serviceName = requestUri.GetServiceName();
                if (serviceName.IsNullOrWhiteSpace())
                {
                    throw new Exception("service name not config , if you not use default endpoint please config service in sign");
                }
                requestModel.ServiceName = serviceName;
            }
            requestModel.SignType = ParameterConstant.SIGN_SHA256;
            requestModel.Uri = requestUri;
            requestModel.QueryParameters = queryString;
            requestModel.OverrddenDate = overrideDate;
            if (!(requestUri.Scheme.ToLower() == "http" && requestUri.Port == 80) &&
                !(requestUri.Scheme.ToLower() == "https" && requestUri.Port == 443))
            {
                requestModel.RequestPort = requestUri.Port;
            }
            foreach (string headerKeyValue in headers.Keys)
            {
                requestModel.AddHeader(headerKeyValue,   headers.Get(headerKeyValue));
            }
            JDCloudSigner jDCloudSigner = new JDCloudSigner();
            SignedRequestModel signedRequestModel = jDCloudSigner.Sign(requestModel, credentials);
            var signedHeader = signedRequestModel.RequestHead;
            foreach(var key in signedHeader.Keys) {
                if (httpWebRequest.Headers.GetValues(key) == null) {
                    var value = signedHeader[key];
                    httpWebRequest.Headers.Add(key, value); 
                }
            }
            return httpWebRequest;
        }

#else
        /// <summary>
        /// 扩展签名方法
        /// </summary>
        /// <param name="httpClient">当前请求客户端</param>
        /// <param name="credentials">认证参数信息</param>
        /// <param name="serviceName">the current request service name</param>
        /// <param name="overrideDate">the sign date override</param>
        /// <param name="signType">the jdcloud sign method type</param>
        /// <returns></returns>
        public static HttpClientWrapper DoSign(this HttpClient httpClient, Credentials credentials,string serviceName= null,string signType = null, DateTime? overrideDate = null)
        {
            HttpClientWrapper httpClientWrapper = new HttpClientWrapper(httpClient, credentials, serviceName,signType, overrideDate); 
            return httpClientWrapper;
        }
#endif

    }
}
