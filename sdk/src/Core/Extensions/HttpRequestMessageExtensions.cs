#if!(NET35||NET40)
using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Auth.Sign;
using JDCloudSDK.Core.Common;
using JDCloudSDK.Core.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace JDCloudSDK.Core.Extensions
{
    /// <summary>
    /// HttpRequestMessage extensions
    /// </summary>
    public static class HttpRequestMessageExtensions
    {
        /// <summary>
        /// do sign http request message
        /// </summary>
        /// <param name="httpRequestMessage">the http request</param>
        /// <param name="credentials">the jdcloud credentials</param>
        /// <param name="overWriteDate">over write sign data</param>
        /// <param name="signType">the signType now support HMACSHA256</param>
        /// <param name="serviceName">the current http request request serviceName</param>
        /// <returns></returns>
        public static HttpRequestMessage DoRequestMessageSign(this HttpRequestMessage httpRequestMessage, Credential credentials,string serviceName = null,string signType = null,DateTime? overWriteDate = null) {
            var headers =   httpRequestMessage.Headers;
            var requestUri = httpRequestMessage.RequestUri;
            var queryString = requestUri.Query;
            var requestPath = requestUri.AbsolutePath;
            var requestContent = httpRequestMessage.Content;
            var requestMethod = httpRequestMessage.Method;
            string apiVersion = requestUri.GetRequestVersion();
            RequestModel requestModel = new RequestModel();
            requestModel.ApiVersion = apiVersion;
            if (requestContent != null) {
                using (var contentStream = new MemoryStream())
                {
                    requestContent.CopyToAsync(contentStream).RunSynchronously();
                    if (contentStream.Length > 0)
                    {
                        requestModel.Content = contentStream.ToArray();
                    }
                }

                requestModel.ContentType = requestContent.Headers.ContentType.ToString();
            }
            requestModel.HttpMethod = requestMethod.ToString().ToUpper();
            var pathRegion = requestUri.GetRequestVersion();
            if (!string.IsNullOrWhiteSpace(pathRegion)) {
                requestModel.RegionName = pathRegion;
            }
            else {
                requestModel.RegionName = ParameterConstant.DEFAULT_REGION;
            }

            requestModel.ResourcePath = requestPath;
            if (!string.IsNullOrWhiteSpace(serviceName))
            {
                requestModel.ServiceName = serviceName;
            }
            else {
                serviceName = requestUri.GetServiceName();
                if (string.IsNullOrWhiteSpace(serviceName)) {
                    throw new Exception("service name not config , if you not use default endpoint please config service in sign");
                }
                requestModel.ServiceName = serviceName;
            } 
            requestModel.SignType = ParameterConstant.SIGN_SHA256;
            requestModel.Uri = requestUri;
            requestModel.QueryParameters = queryString;
            requestModel.OverrddenDate = overWriteDate;
            if (!(requestUri.Scheme.ToLower() == "http" && requestUri.Port == 80) &&
                !(requestUri.Scheme.ToLower() == "https" && requestUri.Port == 443)) {
                requestModel.RequestPort = requestUri.Port;
            } 
            foreach (var headerKeyValue in headers) {
                requestModel.AddHeader(headerKeyValue.Key, string.Join(",", headerKeyValue.Value));
            }
            JDCloudSigner jDCloudSigner = new JDCloudSigner();
            SignedRequestModel signedRequestModel = jDCloudSigner.Sign(requestModel, credentials);
            var signedHeader = signedRequestModel.RequestHead;
            foreach (var key in signedHeader.Keys)
            {
                if (!httpRequestMessage.Headers.Contains(key))
                {
                    var value = signedHeader[key];
                    httpRequestMessage.Headers.TryAddWithoutValidation(key, value);
                }
            }
            return httpRequestMessage;
        }
    }
}
#endif