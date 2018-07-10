using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using JDCloudSDK.Core.Utils;

namespace JDCloudSDK.Core.Http
{
    /// <summary>
    /// 请求基础类型
    /// </summary>
    public class DefaultSdkHttpFullRequest : SdkHttpFullRequest
    {
        /// <summary>
        /// 请求的头信息
        /// </summary>
        private Dictionary<string, List<string>> headers = new Dictionary<string, List<string>>();

        /// <summary>
        /// 请求的resource path
        /// </summary>
        private string resourcePath;

        /// <summary>
        /// 请求的query param 参数字符串
        /// </summary>
        private string queryParameters ;
       
        /// <summary>
        /// 请求地址信息
        /// </summary>
        private Uri endpoint;

        /// <summary>
        /// 请求方法
        /// </summary>
        private SdkHttpMethod httpMethod;

        /// <summary>
        /// http body 存放内容
        /// </summary>
        private string content;
 
        /// <summary>
        /// 获取http body 内容
        /// </summary>
        /// <returns>http body 内容信息</returns>
        public string GetContent()
        {
            return content;
        }

        /// <summary>
        /// 获取终节点内容
        /// </summary>
        /// <returns>终结点信息</returns>
        public Uri GetEndpoint()
        {
            return endpoint;
        }

        /// <summary>
        /// 获取所有的请求头信息
        /// </summary>
        /// <returns>请求头信息</returns>
        public Dictionary<string, List<string>> GetHeaders()
        {
            return headers;
        }

        /// <summary>
        /// 获取请求的方法信息
        /// </summary>
        /// <returns>http 请求方法</returns>
        public SdkHttpMethod GetHttpMethod()
        {
            return httpMethod;
        }

        /// <summary>
        /// get the query param 
        /// </summary>
        /// <returns>请求 query param 参数信息</returns>
        public string GetParameters()
        {
            return queryParameters;
        }

        /// <summary>
        /// get the request resource path
        /// </summary>
        /// <returns>获取请求的路径信息</returns>
        public string GetResourcePath()
        {
            return resourcePath;
        }


        /// <summary>
        /// get DefaultSdkHttpFullRequestBuilder
        /// </summary>
        /// <returns>http request 对象构建类</returns>
        public static DefaultSdkHttpFullRequestBuilder Builder()
        {
            return new DefaultSdkHttpFullRequestBuilder();
        }


        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="builder">http request 对象构建类</param>
        public DefaultSdkHttpFullRequest(DefaultSdkHttpFullRequestBuilder builder)
        {
            var headers = builder.GetHeaders();
            foreach (var key in headers.Keys)
            {
                this.headers.Add(key,headers[key]);
            } 
            this.queryParameters = builder.GetParameters();
            this.resourcePath = builder.GetResourcePath();
            this.endpoint = builder.GetEndpoint();
            this.httpMethod = builder.GetHttpMethod();
            this.content = builder.GetContent();
        }

        /// <summary>
        /// DefaultSdkHttpFullRequestBuilder sub class implement SdkHttpFullRequestBuilder
        /// </summary>
        public class DefaultSdkHttpFullRequestBuilder : SdkHttpFullRequestBuilder
        {
            /// <summary>
            /// 头信息
            /// </summary>
            private Dictionary<string, List<string>> headers = new Dictionary<string, List<string>>();

            /// <summary>
            /// 请求资源地址
            /// </summary>
            private string resourcePath;

            /// <summary>
            /// query param 
            /// </summary>
            private string  queryParameters  ;


            /// <summary>
            /// 请求终节点
            /// </summary>
            private Uri endpoint;

            /// <summary>
            /// 
            /// 请求方法
            /// </summary>
            private SdkHttpMethod httpMethod;


            /// <summary>
            /// 请求的内容
            /// </summary>
            private string content;


            /// <summary>
            /// 默认构造函数
            /// </summary>
            public DefaultSdkHttpFullRequestBuilder()
            {
                
            }



            /// <summary>
            /// 清除 query Parameters
            /// </summary>
            /// <returns>http request 对象构建接口</returns>
            public SdkHttpFullRequestBuilder ClearQueryParameters()
            {
                this.queryParameters=null;

                return this;
            }

            /// <summary>
            /// 设置请求包体内容
            /// </summary>
            /// <param name="content">http content 内容</param>
            /// <returns>http request 对象构建接口</returns>
            public SdkHttpFullRequestBuilder Content(string content)
            {
                this.content = content;
                return this;
            }

            /// <summary>
            /// 设置终结点
            /// </summary>
            /// <param name="endpoint">请求的终结点信息</param>
            /// <returns>http request 对象构建接口</returns>
            public SdkHttpFullRequestBuilder Endpoint(Uri endpoint)
            {
                this.endpoint = endpoint;

                return this;
            }

            /// <summary>
            /// 获取包体内容
            /// </summary>
            /// <returns>获取http content 内容</returns>
            public string GetContent()
            {
                return this.content;
            }

            /// <summary>
            /// 获取终节点
            /// </summary>
            /// <returns>获取终结点信息</returns>
            public Uri GetEndpoint()
            {
                return this.endpoint;
            }

            /// <summary>
            /// 获取所有的请求头信息
            /// </summary>
            /// <returns>获取请求头信息</returns>
            public Dictionary<string, List<string>> GetHeaders()
            {
                return this.headers;
            }

            /// <summary>
            /// 获取请求方法
            /// </summary>
            /// <returns>获取http 请求方法</returns>
            public SdkHttpMethod GetHttpMethod()
            {
                return this.httpMethod;
            }

            /// <summary>
            /// 获取请求参数信息
            /// </summary>
            /// <returns>获取 query param 参数字符串</returns>
            public string  GetParameters()
            {
                return this.queryParameters;
            }

            /// <summary>
            /// 获取请求资源地址
            /// </summary>
            /// <returns>获取请求资源的路径</returns>
            public string GetResourcePath()
            {
                return this.resourcePath;
            }

            /// <summary>
            /// 添加头信息
            /// </summary>
            /// <param name="key">头信息要添加的key</param>
            /// <param name="value">要添加header 的值</param>
            /// <returns>http request 对象构建接口</returns>
            public SdkHttpFullRequestBuilder Header(string key, string value)
            {
                List<string> listValue = new List<string>();
                listValue.Add(value);
                return Header(key, listValue);
            }

            /// <summary>
            /// 添加头信息
            /// </summary>
            /// <param name="key">对象的key</param>
            /// <param name="values">对象的值的列表信息</param>
            /// <returns>http request 对象构建接口</returns>
            public SdkHttpFullRequestBuilder Header(string key, List<string> values)
            {
                this.headers.Add(key, values);
                return this;
            }

            /// <summary>
            /// 添加头信息
            /// </summary>
            /// <param name="headers">头信息字典</param> 
            /// <returns>http request 对象构建接口</returns>
            public SdkHttpFullRequestBuilder Headers(Dictionary<string, List<string>> headers)
            {
                foreach (var key in headers.Keys)
                {
                    if (headers[key] != null && headers[key].Count > 0)
                    {
                        this.headers.Add(key, headers[key]);
                    }

                }
                return this;
            }


            /// <summary>
            /// 设置请求方法
            /// </summary>
            /// <param name="httpMethod">http 请求方法</param>
            /// <returns>http request 对象构建接口</returns>
            public SdkHttpFullRequestBuilder HttpMethod(SdkHttpMethod httpMethod)
            {
                this.httpMethod = httpMethod;
                return this;
            }



            /// <summary>
            /// 设置资源地址
            /// </summary>
            /// <param name="resourcePath">要设置的请求资源地址字符串</param>
            /// <returns>http request 对象构建接口</returns>
            public SdkHttpFullRequestBuilder ResourcePath(string resourcePath)
            {
                this.resourcePath = resourcePath;
                return this;
            }

            /// <summary>
            /// 构造DefaultSdkHttpFullRequest 对象
            /// </summary>
            /// <returns>构建的DefaultSdkHttpFullRequest 对象</returns>
            public SdkHttpFullRequest Build()
            {
                return new DefaultSdkHttpFullRequest(this);
            }

        

            /// <summary>
            /// 设置 Query Parameter
            /// </summary>
            /// <param name="queryParameter">the http Query Parameter string</param>
            /// <returns>http request 对象构建接口</returns>
            public SdkHttpFullRequestBuilder QueryParameter(string queryParameter)
            {
                this.queryParameters = queryParameter;
                return this;
            }
        } 

    }


    
}
