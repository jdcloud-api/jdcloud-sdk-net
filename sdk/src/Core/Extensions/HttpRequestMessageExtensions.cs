using JDCloudSDK.Core.Auth;
using System;
using System.Collections.Generic;
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
        /// <returns></returns>
        public static HttpRequestMessage DoSign(this HttpRequestMessage httpRequestMessage, Credentials credentials) {
            var headers =   httpRequestMessage.Headers;
            var requestUri = httpRequestMessage.RequestUri;
            var queryString = requestUri.Query;
            var requestPath = requestUri.AbsolutePath;
            var requestContent = httpRequestMessage.Content;
            var requestMethod = httpRequestMessage.Method;
            
            return httpRequestMessage;
        }
    }
}
