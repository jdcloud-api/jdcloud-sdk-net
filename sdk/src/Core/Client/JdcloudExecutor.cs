using JDCloudSDK.Core.Annotation;
using JDCloudSDK.Core.Auth.Sign;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Core.Model;
using JDCloudSDK.Core.Service;
using JDCloudSDK.Core.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
#if NET35
#else
using System.Threading.Tasks;
#endif
using System.Linq;

 
namespace JDCloudSDK.Core.Client
{
    /// <summary>
    /// 为了保持兼容性，目前暂时没有引用日志框架，
    /// 引用日志 框架需要在启动的时候进行初始化配置
    /// 加载配置文件等配置，因不同版本的.NET 对配置方式处理的不同，
    /// 有的版本需要手动进行加载
    /// </summary>
    public abstract  class JdcloudExecutor
    {
        /// <summary>
        /// 时间格式化字符串信息
        /// </summary>
        private const string dateFormat = "yyyy-MM-dd'T'HH:mm:ss";

        /// <summary>
        /// 默认的字符编码类型  "UTF-8"
        /// </summary>
        private static string charset = "UTF-8";

        /// <summary>
        /// 进行正则匹配的 pattern
        /// </summary>
        private static string pattern = "\\{([a-zA-Z0-9-_]+)}";

        /// <summary>
        /// JdcloudClient 对象信息
        /// </summary>
        protected JdcloudClient JdcloudClient;

        /// <summary>
        /// http 请求的方法
        /// </summary>
        public virtual string Method { get; }
        /// <summary>
        /// 请求url
        /// </summary>
        public virtual string Url { get; }


        /// <summary>
        /// 设置请求的 JdcloudClient 对象
        /// </summary>
        /// <param name="client">请求的 JdcloudClient </param>
        /// <returns>JdcloudExecutor 对象信息</returns>
        public JdcloudExecutor Client(JdcloudClient client)
        {
            this.JdcloudClient = client;
            return this;
        }

        /// <summary>
        ///  执行api 请求方法
        ///  在.NET 4.5 以上版本使用Httpclient 进行调用
        ///  在.Net 4 版本 使用HttpWebRequest 进行调用
        /// </summary>
        /// <typeparam name="R">继承 JdcloudResponse 的类 包含错误的结果信息 </typeparam>
        /// <typeparam name="R2"> 继承JdcloudResult  请求的结果信息</typeparam>
        /// <typeparam name="T">请求参数对象 继承JdcloudRequest</typeparam>
        /// <param name="request">请求参数</param>
        /// <returns>
        ///  如果Http 请求状态为ok(200) 返回 成功请求后得到的结果 如果返回 200 内容为null返回null
        ///  如果Http 请求返回状态不为（OK）200 则返回错误信息，Error内的code 返回 Http 请求的错误码，message 返回服务器返回的异常
        /// </returns>
#if NET40||NET35
        public R Execute<R,R2,T>(T request) where T: JdcloudRequest where R2:JdcloudResult where R : JdcloudResponse<R2>,new()
#else
        public async Task<R> Execute<R,R2,T>(T request) where T: JdcloudRequest where R2:JdcloudResult where R : JdcloudResponse<R2>,new()
#endif
        {
            string version = request.Version;
            version = CheckImportantParams(version);
            CheckRequest(request);
            try
            {
                var httpRequestConfig = JdcloudClient.HttpRequestConfig;
                string uri = Url;
                uri = ReplaceUrl(uri, request);
                string protocol = httpRequestConfig.Protocol.ToString();
                string endPoint = JdcloudClient.Endpoint;
                string realEndPoint = JdcloudClient.RealEndPoints;
                StringBuilder host = new StringBuilder()
                    .Append(protocol)
                    .Append("://")
                    .Append(endPoint);


#if NET35
                StringBuilder signingHost = new StringBuilder()
                 .Append(protocol)
                 .Append("://")
                 .Append(string.IsNullOrEmpty(realEndPoint)|| string.IsNullOrEmpty(realEndPoint.Trim())? endPoint : realEndPoint);
#else
                     StringBuilder signingHost = new StringBuilder()
                    .Append(protocol)
                    .Append("://")
                    .Append( string.IsNullOrWhiteSpace(realEndPoint)? endPoint : realEndPoint);
#endif


                StringBuilder path = new StringBuilder()
                    .Append("/")
                    .Append(version)
                    .Append(uri);

                string paramsStr = GetParams(request);
                
                byte[] bodyContent = null;
                string contentStr = GetContent(request);
#if NET35
                if (!string.IsNullOrEmpty(contentStr)&& !string.IsNullOrEmpty(contentStr))
#else
                if (!string.IsNullOrWhiteSpace(contentStr))
#endif
                {
                    bodyContent = System.Text.Encoding.UTF8.GetBytes(contentStr);
                }
                string url = host.ToString() + path.ToString() + paramsStr;
                SignRequest signRequest = new SignRequest(signingHost.ToString(),
                     path.ToString(),request.RegionId,JdcloudClient.ServiceName,
                     JdcloudClient.CredentialsProvider.GetCredentials(),
                     Method, JdcloudClient.MIME_JSON, contentStr,url, paramsStr);
                ISignatureComposer signer = new SignatureComposer();
                var header =  signer.Sign(signRequest);
                if (header != null)
                {
                    if (!header.ContainsKey("User-Agent"))
                    {
                        header.Add("User-Agent", JdcloudClient.UserAgent);
                    }
                }
                SetCustomHeader(ref header);
#if NET40 || NET35
                var result = HttpClientUtil.ExecuteHttpRequest(url, bodyContent, header, Method, httpRequestConfig.RequestTimeout);
#else
                var result = await  HttpClientUtil.ExecuteHttpRequest(JdcloudClient.HttpClient, url, bodyContent, header, Method).ConfigureAwait(false);
#endif
                if (result != null)
                {
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        if (result.ReturnValue != null)
                        {
                            string resultStr = result.ReturnValue;
#if NET35
                            if (!(string.IsNullOrEmpty(resultStr) || string.IsNullOrEmpty(resultStr)))
#else
                            if (!String.IsNullOrWhiteSpace(resultStr))
#endif
                            {
                                var responseResult = JsonConvert.DeserializeObject<R>(resultStr);
                                responseResult.HttpResponse = result.HttpSDKResponse;
                                return responseResult;
                            }
                        }

                    }
                    else
                    {
                         
                        if (result.ReturnValue != null && result.ReturnValue.Count() > 0)
                        {
                            string resultStr = result.ReturnValue;
#if NET35
                            if (!string.IsNullOrEmpty(resultStr) && !string.IsNullOrEmpty(resultStr))
#else
                            if (!String.IsNullOrWhiteSpace(resultStr))
#endif
                            {
                                return JsonConvert.DeserializeObject<R>(resultStr);
                            }
                        }
                        return new R() { Error = new ServiceError() { Code = (int)result.StatusCode, Message = $"the gateway return {result.StatusCode.ToString() }" }, HttpResponse = result.HttpSDKResponse };
                    }
                } 
            }
            catch (Exception ex)
            {
                throw new Exception("call sign and httpclient error.",ex);
            } 
            return null;
        }

        /// <summary>
        /// 设置自定义头信息，注意.NET的方法只能设置不存在的头信息，如果需要修改，需要修改此方法
        /// </summary>
        /// <param name="header">请求的http 头信息字典</param>
        public void SetCustomHeader(ref Dictionary<string, string> header)
        {
            var customHeaders = JdcloudClient.GetCustomHeader();
            foreach (var item in customHeaders)
            {
#if NET35
                if (string.IsNullOrEmpty(item.Key) || string.IsNullOrEmpty(item.Key.Trim()))
#else
                if (string.IsNullOrWhiteSpace(item.Key))
#endif
                {
                    continue;
                }
                string value = item.Value; 
                if ("x-jdcloud-pin" == item.Key.ToLower().Trim()
                    || "x-jdcloud-erp" == item.Key.ToLower().Trim()
                    || "x-jdcloud-security-token" == item.Key.ToLower().Trim()
                    || "x-jdcloud-session-token" == item.Key.ToLower().Trim())
                {
                    value = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(value));
                }
                if (!header.ContainsKey(item.Key))
                {
                    header.Add(item.Key, value);
                }
                else
                {
                    //var value = header[item.Key];
                    header[item.Key] = value;
                }
            }
        }

        /// <summary>
        /// 请求url 参数格式化替换
        /// </summary>
        /// <param name="httpUrl">要替换的url</param>
        /// <param name="request">请求的参数信息</param>
        /// <returns>替换后的url 信息</returns>
        public string ReplaceUrl(string httpUrl, JdcloudRequest request)
        {
#if NET35
            if (string.IsNullOrEmpty(httpUrl)||string.IsNullOrEmpty(httpUrl.Trim()))
#else
            if (string.IsNullOrWhiteSpace(httpUrl))
#endif
            {
                return string.Empty;
            } 
            if (httpUrl.IndexOf("{") < 0)
            {
                return httpUrl;
            }
            var matchs = Regex.Matches(httpUrl, pattern);
            if (matchs != null && matchs.Count > 0)
            {
                int i = 1;
                foreach (Match item in matchs)
                {
                    i++; 

                    string fieldName = item.Groups[1].Value;
                    var paramValue = GetRequestValue(fieldName, request);

                    if (!string.IsNullOrEmpty(paramValue)) {
                        paramValue = Uri.EscapeUriString(paramValue);
                    } 
                    httpUrl = httpUrl.Replace(item.Value, paramValue);
                }
            }
            return httpUrl;
        }

        /// <summary>
        /// 检查参数是否填写完整
        /// 此方法与java 定义的不同 java 为feild .net 使用property
        /// </summary>
        /// <param name="request">请求的参数信息</param>
        public void CheckRequest(Object request)
        {
            try
            {
                var properties = request.GetType().GetProperties();
                foreach (var item in properties)
                {
#if NET40 || NET35
                    
                    var requiredAttribute =  item.GetCustomAttributes(typeof(RequiredAttribute),false);
                    if (requiredAttribute != null&& requiredAttribute.Length>0)
                    {
                        var value = item.GetValue(request,null);
                        if (value == null)
                        {
                            throw new ArgumentNullException($"field {item.Name} can not be null,please set value for it.");
                        }
                    }
#else
                    var required = item.GetCustomAttribute<RequiredAttribute>();
                    if (required != null)
                    {
                        var value = item.GetValue(request);
                        if (value == null)
                        {
                            throw new ArgumentNullException($"field {item.Name} can not be null,please set value for it.");
                        }
                    }

#endif
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        /// <summary>
        /// 检查版本号等重要参数信息
        /// </summary>
        /// <param name="v">版本号</param>
        /// <returns>版本号信息</returns>
        protected string CheckImportantParams(string v)
        {
            if (JdcloudClient == null)
            {
                throw new ArgumentNullException("JdcloudClient not set.");
            }
#if NET35
            if (string.IsNullOrEmpty(v) || string.IsNullOrEmpty(v.Trim()))
#else
            if (string.IsNullOrWhiteSpace(v))
#endif
            {
                v = JdcloudClient.Version;
            }
#if NET35
            if (string.IsNullOrEmpty(v) || string.IsNullOrEmpty(v.Trim()))
#else
            if (string.IsNullOrWhiteSpace(v))
#endif
            {
                throw new ArgumentNullException("Version not set.");
            }
#if NET35
            if (string.IsNullOrEmpty(JdcloudClient.Endpoint) || string.IsNullOrEmpty(JdcloudClient.Endpoint.Trim()))
#else
            if (string.IsNullOrWhiteSpace(JdcloudClient.Endpoint))
#endif
            {
                throw new ArgumentNullException("endpoint not set.");
            }
#if NET35
            if (string.IsNullOrEmpty(JdcloudClient.ServiceName) || string.IsNullOrEmpty(JdcloudClient.ServiceName.Trim()))
#else
            if (string.IsNullOrWhiteSpace(JdcloudClient.ServiceName))
#endif
            {
                throw new ArgumentNullException("serviceName not set.");
            }

            return v;
        }

        /// <summary>
        /// 获取参数对应的值信息
        /// </summary>
        /// <param name="propertyName">参数名称</param>
        /// <param name="request">请求参数封装类</param>
        /// <returns>请求参数的值</returns>
        private string GetRequestValue(string propertyName, JdcloudRequest request)
        {

            PropertyInfo propertyInfo = null; 
            var properties = request.GetType().GetProperties();
            if (properties != null && properties.Length > 0)
            {
                propertyInfo = properties.Where(p => p.Name.ToLower() == propertyName.ToLower()).FirstOrDefault();
            }

            if (propertyInfo == null)
            {
                throw new Exception($"can not get the propertyInfo of {propertyName},please check.");
            }
#if NET40 || NET35
            object value = propertyInfo.GetValue(request,null);
#else
            object value = propertyInfo.GetValue(request);
#endif
            if (value == null)
            {
                throw new Exception($"field {propertyName} not set.");
            }

            return value.ToString();
        }

        /// <summary>
        /// 获取请求的Http body 的内容
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求body 内容</returns>
        private string GetContent(JdcloudRequest request)
        {
            if (request == null)
            {
                return string.Empty;
            }

            string method = Method;
            if (SdkHttpMethod.DELETE.ToString().ToLower()== method.ToLower()
             || SdkHttpMethod.GET.ToString().ToLower() == method.ToLower()
             || SdkHttpMethod.HEAD.ToString().ToLower() == method.ToLower())
            {
                return null;
            }
            string contentStr = JsonUtil.ObjectToJson(request);
#if NET35
            if (!string.IsNullOrEmpty(contentStr) && !string.IsNullOrEmpty(contentStr.Trim()))
#else
            if (!string.IsNullOrWhiteSpace(contentStr))
#endif
            {
                contentStr = contentStr.Replace(System.Environment.NewLine, "");
            }
            return contentStr;
        }


        /// <summary>
        /// 获取 url 连接串参数
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求 quary param string </returns>
        private string GetParams(JdcloudRequest request)
        {
            if (request == null)
            {
                return string.Empty;
            }

            string method = Method;
            if (SdkHttpMethod.DELETE.ToString().ToLower() == method.ToLower()
                || SdkHttpMethod.GET.ToString().ToLower() == method.ToLower()
                || SdkHttpMethod.HEAD.ToString().ToLower() == method.ToLower())
            { 
                JsonSerializer jsonSerializer = new JsonSerializer();
                //json 格式化，转换为小驼峰的形式
                jsonSerializer.ContractResolver = new CamelCasePropertyNamesContractResolver();
                JObject jObject = JObject.FromObject(request, jsonSerializer);
                Dictionary<string, string> paramDic = new Dictionary<string, string>();
                string paramsStr = "";
                paramDic = CreateParam(jObject);
                if (paramDic != null)
                {
                    var paramDicOrder = paramDic.OrderBy(p => p.Key);
                    StringBuilder paramStrBuilder = new StringBuilder();
                    foreach (var item in paramDicOrder)
                    {
                        string value = item.Value; // System.Web.HttpUtility.UrlEncode(item.Value, Encoding.GetEncoding(charset));
                        Regex reg = new Regex(@"%[a-f0-9]{2}");
                        value = reg.Replace(value, m => m.Value.ToUpperInvariant());
                        paramStrBuilder.Append("&").Append(item.Key).Append("=").Append(value);
                    }
                    paramsStr = paramStrBuilder.ToString();
                } 
#if NET35
                if (!string.IsNullOrEmpty(paramsStr)&& !string.IsNullOrEmpty(paramsStr.Trim()))
#else
                if (!string.IsNullOrWhiteSpace(paramsStr))
#endif
                {
                    return "?" + paramsStr.Substring(1);
                }
                else
                {
                    return string.Empty;
                }
            } 
            return string.Empty;
        }

        /// <summary>
        /// 创建get 等请求使用的query string
        /// </summary>
        /// <param name="jObject">Json 对象</param>
        /// <param name="superName">上一级的名称</param>
        /// <returns>query string</returns>
        private Dictionary<string,string> CreateParam(JToken jObject, string superName = "")
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
           // StringBuilder builder = new StringBuilder();
            if (jObject.GetType() == typeof(JArray))
            {
               var  arrayParamDic=  ArrayParam(jObject, superName);
                if (arrayParamDic != null)
                {
                    foreach (var item in arrayParamDic)
                    {
                        dic.Add(item.Key, item.Value);
                    }
                }
                
            }
            else
            {
                var objectParamDic = ObjectParam(jObject, superName);
                if (objectParamDic != null)
                {
                    foreach (var item in objectParamDic)
                    {
                        dic.Add(item.Key, item.Value);
                    }
                }
            }
            return dic;
        }


        /// <summary>
        /// 创建get 等请求使用的query string ， 解析数组对象
        /// </summary>
        /// <param name="jObject">Json 对象</param>
        /// <param name="superName">上一级的名称</param>
        /// <returns>query string</returns>
        private Dictionary<string,string> ArrayParam(JToken jObject,   string superName="")
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (jObject.GetType() != typeof(JArray))
            {
                return null;
            }
            var jArrayObject = (JArray)jObject;
            for (int i = 0; i < jArrayObject.Count; i++)
            {
                if (jArrayObject != null && jArrayObject.Count > 0)
                {
                    if (jArrayObject[i].GetType() == typeof(JValue))
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                 
                        stringBuilder.Append(superName);
                        stringBuilder.Append(".");
                        stringBuilder.Append(i+1); 
                        string encodeStr = Regex.Replace(jArrayObject[i].ToString(), "^\"|\"$", "");
 
                        string value = Uri.EscapeDataString(encodeStr);

                         dic.Add(stringBuilder.ToString(), value);
                    }
                    else
                    {
                        var createParamDic = CreateParam(jArrayObject[i], superName + "." + (i+1));
                        if (createParamDic != null)
                        {
                            foreach (var item in createParamDic)
                            {
                                dic.Add(item.Key,item.Value);
                            }
                        }
                    }
                } 
            }
            return dic;
        }

 
        /// <summary>
        /// 创建get 等请求使用的query string，解析Object 对象
        /// </summary>
        /// <param name="jToken">json 对象</param> 
        /// <param name="superName">父类名称</param>
        private Dictionary<string,string> ObjectParam(JToken jToken,   string superName = "")
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var jObject = (JObject)jToken;
            foreach (var item in jObject)
            {
                string name = item.Key;
                if (Url.IndexOf("{" + name + "}") > -1)
                {
                    continue;
                }
                var valueJObject =  item.Value;
                string pname = CreateParamKey(superName, name);
                if (valueJObject.GetType() == typeof(JValue))
                {
#if NET35
                    if (!string.IsNullOrEmpty(valueJObject.ToString())&& !string.IsNullOrEmpty(valueJObject.ToString().Trim()))
#else
                    if (!string.IsNullOrWhiteSpace(valueJObject.ToString()))
#endif
                    {
                       
                        string encodeStr = Regex.Replace(valueJObject.ToString(), "^\"|\"$", "");
#if NET35 || NET40
                        string value = System.Web.HttpUtility.UrlEncode(encodeStr, Encoding.GetEncoding(charset));
                        
#else
                        string value = System.Net.WebUtility.UrlEncode(encodeStr);
                        value = value.Replace("+", "%20");

#endif
                        dic.Add(pname,value);
                    } 
                }
                else
                { 
                     var createParamDic = CreateParam(valueJObject, pname);
                    if (createParamDic != null)
                    {
                        foreach (var paramDic in createParamDic)
                        {
                            dic.Add(paramDic.Key, paramDic.Value);
                        }
                    }
                }

            }
            return dic;
        }

        /// <summary>
        /// 生成query param 的 key值
        /// </summary>
        /// <param name="superName">父类名称</param>
        /// <param name="name">当前字段名称</param>
        /// <returns>query param 的 key值</returns>
        private string CreateParamKey(string superName, string name)
        {

#if NET35
            if (string.IsNullOrEmpty(superName)|| string.IsNullOrEmpty(superName.Trim()))
            {
                return name;
            }
#else
            
            if (string.IsNullOrWhiteSpace(superName))
            {
                return name;
            }
#endif
            return $"{superName}.{name}" ; 
        }
    }



    
}
