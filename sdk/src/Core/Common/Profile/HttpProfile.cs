#if !(NET35||NET40)
using System.Net.Http;
#endif
namespace JDCloudSDK.Core.Common.Profile
{
    /// <summary>
    /// http 请求配置信息
    /// </summary>
    public class HttpProfile
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public HttpProfile()
        {

        }

        /// <summary>
        /// 构造函数
        /// timeout default 10
        /// ContentType default "application/json"
        /// </summary>
        /// <param name="protocol">请求协议</param>
        /// <param name="WebProxy">代理服务器</param>
        public HttpProfile(string protocol,  string WebProxy = null)
        {
            this.Protocol = protocol;
            this.WebProxy = WebProxy;
        }

        /// <summary>
        /// 构造函数
        /// timeout default 10
        /// ContentType default "application/json"
        /// protocol defualt https
        /// </summary>
        /// <param name="WebProxy"></param>
        public HttpProfile( string WebProxy = null)
        {
            this.WebProxy = WebProxy;
        }

        /// <summary>
        /// 构造函数
        /// ContentType default "application/json"
        /// protocol defualt https
        /// </summary>
        /// <param name="WebProxy"></param>
        /// <param name="timeout"></param>
        public HttpProfile(string WebProxy =null,int timeout =15)
        {
            this.WebProxy = WebProxy;
            this.Timeout = timeout;
        }

#if!(NET35||NET40)
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="protocol">请求协议</param>
        /// <param name="timeout">超时时间</param>
        /// <param name="httpMethod">请求方法</param>
        /// <param name="contentType">请求body类型</param>
        /// <param name="webProxy">代理服务器</param>
        public HttpProfile(string protocol, int timeout, HttpMethod httpMethod, string contentType, string webProxy)
        {
            Protocol = protocol;
            Timeout = timeout;
            HttpMethod = httpMethod;
            ContentType = contentType;
            WebProxy = webProxy;
        }
#endif
        private string _Protocol;
        /// <summary>
        /// 请求协议
        /// </summary>
        public string Protocol {
            get {
                switch (_Protocol.Trim().ToUpper())
                {
                    case "HTTP":
                        return "HTTP";
                    default:
                        return "HTTPS";
                }
            }
            set {
                _Protocol = value;
            }
        }  

        /// <summary>
        /// 请求超时时间
        /// </summary>
        public int Timeout { get; set; } = 15;

#if!(NET35||NET40)

        /// <summary>
        /// 请求方法
        /// </summary>
        public HttpMethod HttpMethod { get; set; }
#endif
        /// <summary>
        /// 请求 content-type
        /// </summary>
        public string ContentType { get; set; } = "application/json";

        /// <summary>
        /// 代理服务器
        /// </summary>
        public string WebProxy { get; set; }
    }
}
