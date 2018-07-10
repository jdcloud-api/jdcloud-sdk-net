using JDCloudSDK.Core.Auth; 

namespace JDCloudSDK.Core.Model
{
    /// <summary>
    /// 签名使用的信息集合
    /// </summary>
    public class SignRequest
    {
        /// <summary>
        /// 请求host
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 请求路径
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 地域分布参数
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        public string ServiceName { get; set; }

        // 因为.net 没有使用工厂构建http 客户端 停用此参数
        //public HttpClient Request { get; set; }

        /// <summary>
        /// 认证信息
        /// </summary>
        public ICredentials Credentials { get; set; }

        /// <summary>
        /// Http请求方法
        /// </summary>
        public string RequestMothed { get; set; }

        /// <summary>
        /// Http 请求头ContentType
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Http 请求body 内容
        /// </summary>
        public string RequestContent { get; set; }

        /// <summary>
        /// http请求url
        /// </summary>
        public string RequestUrl { get; set; }

        /// <summary>
        /// http 请求url 附带的参数
        /// </summary>
        public string QueryParam { get; set; }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="host">请求host</param>
        /// <param name="path">请求路径</param>
        /// <param name="region">地域信息</param>
        /// <param name="serviceName">服务名称</param>
        /// <param name="credentials">证书</param>
        public SignRequest(string host, string path, string region, string serviceName, ICredentials credentials)
        {
            this.Host = host;
            this.Path = path;
            this.Region = region;
            this.ServiceName = serviceName;
            //this.Request = httpRequest;
            this.Credentials = credentials;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="host">请求host</param>
        /// <param name="path">请求路径</param>
        /// <param name="region">地域信息</param>
        /// <param name="serviceName">服务名称</param>
        /// <param name="credentials">证书</param>
        /// <param name="requestMothed">请求方法</param>
        /// <param name="contentType">请求的content type类型</param>
        /// <param name="requestContent">请求的http content 内容</param>
        /// <param name="requestUrl">请求的url</param>
        /// <param name="queryParam">请求的query param string</param>
        public SignRequest(string host, string path, string region, string serviceName,
            ICredentials credentials, string requestMothed, string contentType, 
            string requestContent, string requestUrl, string queryParam )
        {
            this.Host = host;
            this.Path = path;
            this.Region = region;
            this.ServiceName = serviceName;
            //this.Request = httpRequest;
            this.Credentials = credentials;
            this.RequestMothed = requestMothed;
            this.ContentType = contentType;
            this.RequestContent = requestContent;
            this.RequestUrl = requestUrl;
            this.QueryParam = queryParam;
        }
    }
}
