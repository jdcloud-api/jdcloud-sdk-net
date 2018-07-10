using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Constant;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Core.Model;
using JDCloudSDK.Core.Utils;

namespace JDCloudSDK.Core.Auth.Sign
{

    /// <summary>
    /// 签名实现方法
    /// </summary>
    public class SignatureComposer : ISignatureComposer
    {
        /// <summary>
        ///  进行签名操作 
        /// </summary>
        /// <param name="signRequest">http请求信息</param> 
        /// <returns>返回签名后的需要添加的HTTP header 信息</returns>
        public Dictionary<string, string> Sign(SignRequest signRequest)
        {
            Dictionary<string, string> header = new Dictionary<string, string>();
 
            // v4signer
            JdCloudSigner signer = new JdCloudSigner();
            signer.SetRegionName(signRequest.Region);
            signer.SetServiceName(signRequest.ServiceName);

            String nonceId = Guid.NewGuid().ToString().ToLower();  

            //the default http request mothed is `GET` 
            SdkHttpMethod method = SdkHttpMethod.GET;
#if NET35
            if (!string.IsNullOrEmpty(signRequest.RequestMothed) && !string.IsNullOrEmpty(signRequest.RequestMothed.Trim()))
            {
                method =(SdkHttpMethod) Enum.Parse(typeof(SdkHttpMethod),signRequest.RequestMothed.ToUpper());
            }
#else
            if (!string.IsNullOrWhiteSpace(signRequest.RequestMothed))
            {
                if (!Enum.TryParse<SdkHttpMethod>(signRequest.RequestMothed.ToUpper(), out method))
                {
                    throw new ArgumentException("the http request mothed cast fail , not support .");
                }
            }
#endif

                Uri endPoint = new Uri(signRequest.Host);
            // Builder
#if NET35
            string signRequestContent =   string.IsNullOrEmpty(signRequest.RequestContent)|| string.IsNullOrEmpty(signRequest.RequestContent.Trim()) ? null : signRequest.RequestContent;
            SdkHttpFullRequestBuilder reqBuilder = DefaultSdkHttpFullRequest.Builder()
                   .HttpMethod(method)
                   .Endpoint(endPoint)
                   .ResourcePath(SdkHttpUtils.UrlEncode(signRequest.Path, true))
                   .Header(ParameterConstant.X_JDCLOUD_NONCE, nonceId)
                   // .Header(ParameterConstant.CONTENT_TYPE, signRequest.ContentType)
                   .Content(signRequestContent)
                   .QueryParameter(signRequest.QueryParam);
#else
            SdkHttpFullRequestBuilder reqBuilder = DefaultSdkHttpFullRequest.Builder() 
                    .HttpMethod(method)
                    .Endpoint(endPoint)
                    .ResourcePath(SdkHttpUtils.UrlEncode(signRequest.Path, true))
                    .Header(ParameterConstant.X_JDCLOUD_NONCE, nonceId)
                   // .Header(ParameterConstant.CONTENT_TYPE, signRequest.ContentType)
                    .Content(string.IsNullOrWhiteSpace(signRequest.RequestContent) ? null : signRequest.RequestContent)
                    .QueryParameter(signRequest.QueryParam);
#endif
            //对http header 进行处理， 如果 请求为get head delete 默认不放置content-type 签名内不包含content-type
            if (method != SdkHttpMethod.GET && method != SdkHttpMethod.DELETE && method != SdkHttpMethod.HEAD)
            {
                reqBuilder.Header(ParameterConstant.CONTENT_TYPE, signRequest.ContentType);
                header.Add(ParameterConstant.CONTENT_TYPE, signRequest.ContentType);
            }
           

            // sign
            SdkHttpFullRequest signed = signer.Sign(reqBuilder, new Credentials(signRequest.Credentials.AccessKeyId(), signRequest.Credentials.SecretAccessKey()));

            var signedHeader = signed.GetHeaders();
            header.Add(ParameterConstant.X_JDCLOUD_NONCE, nonceId);
            header.Add(ParameterConstant.X_JDCLOUD_DATE, signedHeader[ParameterConstant.X_JDCLOUD_DATE][0]);
            header.Add(ParameterConstant.AUTHORIZATION, signedHeader[ParameterConstant.AUTHORIZATION][0]);
           
            foreach (var item in signedHeader)
            {
                if (!header.ContainsKey(item.Key))
                {
                    header.Add(item.Key, item.Value[0]);
                } 
            } 
            return header;
        }
    }
}
