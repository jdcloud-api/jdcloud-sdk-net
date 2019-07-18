using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Extensions;

#if NET35 || NET40
#else
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
#endif
namespace JDCloudSDK.Core.Extensions
{
#if NET35 || NET40

#else
    /// <summary>
    /// http client 包装类
    /// </summary>
    public class HttpClientWrapper : HttpClient
    {
         
        private HttpClient _httpClient;

        private Credentials _credentials;

        private string _serviceName;

        private Version _defalutRequestVersion = HttpVersion.Version11;

        private string _signType;

        private DateTime? _overWriteDate;

        private CancellationTokenSource _pendingRequestsCts;



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
        /// <param name="serviceName">the current request service name</param>
        /// <param name="credentials"></param>
        /// <param name="overWriteDate">sign data override</param>
        /// <param name="signType">the sign method type</param>
        public HttpClientWrapper(HttpClient httpClient, Credentials credentials, string serviceName = null, string signType = null, DateTime? overWriteDate = null)
        {

            this._httpClient = httpClient;
            this._serviceName = serviceName;
            this._credentials = credentials;

            this._signType = signType;
            this._overWriteDate = overWriteDate;
            _pendingRequestsCts = new CancellationTokenSource();
        }

        /// <summary>
        ///  exec dispose
        /// </summary>
        public new void Dispose()
        {
            this._httpClient.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        public new void CancelPendingRequests()
        {
            _httpClient.CancelPendingRequests();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {

            return SendAsync(CreateRequestMessage(HttpMethod.Delete, requestUri), cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
        {
            return SendAsync(CreateRequestMessage(HttpMethod.Delete, CreateUri(requestUri)), cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> DeleteAsync(string requestUri)
        {
            return SendAsync(CreateRequestMessage(HttpMethod.Delete, CreateUri(requestUri)), CancellationToken.None);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
        {
            return SendAsync(CreateRequestMessage(HttpMethod.Delete, requestUri), CancellationToken.None);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return SendAsync(CreateRequestMessage(HttpMethod.Get, CreateUri(requestUri)), CancellationToken.None);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="completionOption"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
        {
            return SendAsync(CreateRequestMessage(HttpMethod.Get, CreateUri(requestUri)), completionOption, CancellationToken.None);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="completionOption"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return SendAsync(CreateRequestMessage(HttpMethod.Get, CreateUri(requestUri)), completionOption, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
        {
            return SendAsync(CreateRequestMessage(HttpMethod.Get, CreateUri(requestUri)), cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            return SendAsync(CreateRequestMessage(HttpMethod.Get, requestUri), CancellationToken.None);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="completionOption"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
        {
            return SendAsync(CreateRequestMessage(HttpMethod.Get, requestUri), completionOption, CancellationToken.None);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="completionOption"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return SendAsync(CreateRequestMessage(HttpMethod.Get, requestUri), completionOption, cancellationToken);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return SendAsync(CreateRequestMessage(HttpMethod.Get, requestUri), cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<byte[]> GetByteArrayAsync(string requestUri) =>
            GetByteArrayAsync(CreateUri(requestUri));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<byte[]> GetByteArrayAsync(Uri requestUri) =>
            GetByteArrayAsyncCore(GetAsync(requestUri, HttpCompletionOption.ResponseHeadersRead));

        private async Task<byte[]> GetByteArrayAsyncCore(Task<HttpResponseMessage> getTask)
        {
            using (HttpResponseMessage httpResponseMessage = await getTask.ConfigureAwait(false))
            {
                if (httpResponseMessage == null)
                {
                    throw new Exception("not get http response exception");
                }
                if (httpResponseMessage.Content == null)
                {
                    throw new Exception("the http content is null , can not get byte array");
                }
                return await httpResponseMessage.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<Stream> GetStreamAsync(string requestUri)
        {
            return FinishGetStreamAsync(GetAsync(requestUri));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<Stream> GetStreamAsync(Uri requestUri)
        {
            return FinishGetStreamAsync(GetAsync(requestUri, HttpCompletionOption.ResponseHeadersRead));
        }

        private async Task<Stream> FinishGetStreamAsync(Task<HttpResponseMessage> getTask)
        {

            using (HttpResponseMessage httpResponseMessage = await getTask.ConfigureAwait(false))
            {
                if (httpResponseMessage == null) {
                    throw new Exception("not get http response exception");
                }
                if (httpResponseMessage.Content == null) {
                    throw new Exception("the http content is null , can not get stream");
                }
                if (httpResponseMessage.StatusCode != HttpStatusCode.OK) {
                    throw new Exception($"the response status code is {httpResponseMessage.StatusCode.ToString()} not 'OK', can not get stream ");
                }
                return await httpResponseMessage.Content.ReadAsStreamAsync().ConfigureAwait(false);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<string> GetStringAsync(string requestUri)
        {
            return GetStringAsyncCore(GetAsync(requestUri));
        }
        private async Task<string> GetStringAsyncCore(Task<HttpResponseMessage> getTask)
        {
            using (HttpResponseMessage httpResponseMessage = await getTask.ConfigureAwait(false))
            {
                if (httpResponseMessage == null)
                {
                    throw new Exception("not get http response exception");
                }
                if (httpResponseMessage.Content == null)
                {
                    throw new Exception("the http content is null , can not get string");
                }
                return await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public new Task<string> GetStringAsync(Uri requestUri)
        {
            return GetStringAsyncCore(GetAsync(requestUri));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            return PostAsync(CreateUri(requestUri), content);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return PostAsync(CreateUri(requestUri), content, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
        {
            return PostAsync(requestUri, content, CancellationToken.None);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            HttpRequestMessage requestMessage = CreateRequestMessage(HttpMethod.Post, requestUri);
            requestMessage.Content = content;
            return SendAsync(requestMessage, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
        {
            return PutAsync(CreateUri(requestUri), content);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return PutAsync(CreateUri(requestUri), content, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
        {

            return PutAsync(requestUri, content, CancellationToken.None);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
            requestMessage.Content = content;
            return SendAsync(requestMessage, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            request = request.DoRequestMessageSign(_credentials, _serviceName, _signType, _overWriteDate);
            return _httpClient.SendAsync(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="completionOption"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
        {
            request = request.DoRequestMessageSign(_credentials, _serviceName, _signType, _overWriteDate);
            return _httpClient.SendAsync(request, completionOption);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="completionOption"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public new Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            request = request.DoRequestMessageSign(_credentials, _serviceName, _signType, _overWriteDate);
            return _httpClient.SendAsync(request, completionOption, cancellationToken);
        } 

        private Uri CreateUri(string uri) =>
          string.IsNullOrEmpty(uri) ? null : new Uri(uri, UriKind.RelativeOrAbsolute);

        private HttpRequestMessage CreateRequestMessage(HttpMethod method, Uri uri) =>
            new HttpRequestMessage(method, uri) { Version = _defalutRequestVersion };



        /// <summary>
        /// send request 类
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request = request.DoRequestMessageSign(_credentials, _serviceName, _signType, _overWriteDate);
            return _httpClient.SendAsync(request, cancellationToken);
        }
    }
#endif
}