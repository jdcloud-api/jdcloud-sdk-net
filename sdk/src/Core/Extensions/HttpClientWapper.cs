using JDCloudSDK.Core.Auth;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JDCloudSDK.Core.Extensions
{
    /// <summary>
    /// http client 包装类
    /// </summary>
    public class HttpClientWrapper:HttpClient
    {

        private HttpClient _httpClient;

        private Credentials _credentials;

        /// <summary>
        /// get http client DefaultRequestHeaders
        /// </summary>
        public new HttpRequestHeaders DefaultRequestHeaders => _httpClient.DefaultRequestHeaders;

        /// <summary>
        /// get or set http client base address
        /// </summary>
        public new Uri BaseAddress { get { return _httpClient.BaseAddress; } set { _httpClient.BaseAddress = value; } }

        /// <summary>
        /// get or set MaxResponseContentBufferSize
        /// </summary>
        public new long MaxResponseContentBufferSize { get { return _httpClient.MaxResponseContentBufferSize; } set { _httpClient.MaxResponseContentBufferSize = value; } }
        
        /// <summary>
        /// get or set httpClient timeout 
        /// </summary>
        public new TimeSpan Timeout { get { return _httpClient.Timeout; } set { this._httpClient.Timeout = value; } }

        /// <summary>
        /// the construst
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="credentials"></param>
        public HttpClientWrapper(HttpClient httpClient, Credentials credentials) {
           
            this._httpClient = httpClient;

            this._credentials = credentials;
        }

        /// <summary>
        ///  exec dispose
        /// </summary>
        public new void Dispose() {
            this._httpClient.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        public new void CancelPendingRequests() {
            _httpClient.CancelPendingRequests();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken) {
            return _httpClient.DeleteAsync(requestUri, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken) {
            return _httpClient.DeleteAsync(requestUri, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> DeleteAsync(string requestUri) {
            return _httpClient.DeleteAsync(requestUri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> DeleteAsync(Uri requestUri) {
            return _httpClient.DeleteAsync(requestUri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(string requestUri) {
            return _httpClient.GetAsync(requestUri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="completionOption"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption) {
            return _httpClient.GetAsync(requestUri, completionOption);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="completionOption"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken) {
            return _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken) {
            return _httpClient.GetAsync(requestUri, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(Uri requestUri) {
            return _httpClient.GetAsync(requestUri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="completionOption"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
        {
            return _httpClient.GetAsync(requestUri, completionOption);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="completionOption"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken) {
            return _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken) {
            return _httpClient.GetAsync(requestUri, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<byte[]> GetByteArrayAsync(string requestUri) {
            return _httpClient.GetByteArrayAsync(requestUri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<byte[]> GetByteArrayAsync(Uri requestUri) {
            return _httpClient.GetByteArrayAsync(requestUri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<Stream> GetStreamAsync(string requestUri) {
            return _httpClient.GetStreamAsync(requestUri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<Stream> GetStreamAsync(Uri requestUri) {
            return _httpClient.GetStreamAsync(requestUri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<string> GetStringAsync(string requestUri) {
            return _httpClient.GetStringAsync(requestUri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<string> GetStringAsync(Uri requestUri) {
            return _httpClient.GetStringAsync(requestUri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) {
            return _httpClient.PostAsync(requestUri, content);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken) {
            return _httpClient.PostAsync(requestUri, content, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content) {
            return _httpClient.PostAsync(requestUri, content);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken) {
            return _httpClient.PostAsync(requestUri, content, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content) {
            return _httpClient.PutAsync(requestUri, content);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken) {
            return _httpClient.PutAsync(requestUri, content,cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content) {
            return _httpClient.PutAsync(requestUri, content);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken) {
            return _httpClient.PutAsync(requestUri, content,cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) {
            return _httpClient.SendAsync(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="completionOption"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption) {
            return _httpClient.SendAsync(request, completionOption);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="completionOption"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken) {
            return _httpClient.SendAsync(request, completionOption, cancellationToken);
        }
    

        /// <summary>
        /// send request 类
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override  Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,  CancellationToken cancellationToken)
        {
            request = request.DoSign(_credentials); 
            return _httpClient.SendAsync(request, cancellationToken);
        }
    }
}
