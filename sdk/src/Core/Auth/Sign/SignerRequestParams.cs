using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Utils;
using JDCloudSDK.Core.Constant;

namespace JDCloudSDK.Core.Auth.Sign
{
    /// <summary>
    /// 签名参数类
    /// </summary>
    public class SignerRequestParams
    {

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="request">http 请求信息</param>
        /// <param name="signingDateOverride">要重写的时间信息</param>
        /// <param name="regionNameOverride">要重写的region name</param>
        /// <param name="serviceName">要重写的service name</param>
        /// <param name="signingAlgorithm">要使用的加密算法字符串</param>
        public SignerRequestParams(SdkHttpRequest request,
                               DateTime? signingDateOverride, string regionNameOverride,
                               string serviceName, string signingAlgorithm)
        {
#if NET35
            if (string.IsNullOrEmpty(signingAlgorithm) || string.IsNullOrEmpty(signingAlgorithm.Trim()))
#else
            if (string.IsNullOrWhiteSpace(signingAlgorithm))
#endif     
            {
                throw new ArgumentNullException("Signing Algorithm can not be null.");
            }
            this.Request = request ?? throw new ArgumentNullException("Request can not be null.");
            DateTime dateTimeUtcNow = signingDateOverride==null?DateTime.UtcNow:signingDateOverride.Value; 
            this.FormattedSigningDate = dateTimeUtcNow.ToString("yyyyMMdd");  
            this.ServiceName = serviceName;
            this.RegionName = ParseRegion(request, regionNameOverride);
            this.Scope = GenerateScope(this.FormattedSigningDate, this.ServiceName, this.RegionName);
            this.FormattedSigningDateTime = dateTimeUtcNow.ToString("yyyyMMdd'T'HHmmss'Z'");
            this.SigningAlgorithm = signingAlgorithm;

        }



        /// <summary>
        /// 获取当前传入的区域信息
        /// </summary>
        /// <param name="request">http 请求信息</param>
        /// <param name="regionNameOverride">  region name 字符串</param>
        /// <returns>格式化后的region 信息 </returns>
        private string ParseRegion(SdkHttpRequest request, string regionNameOverride)
        {
#if NET35
            return !string.IsNullOrEmpty(regionNameOverride)&& !string.IsNullOrEmpty(regionNameOverride.Trim()) ? regionNameOverride
                  : HostNameUtils.ParseRegion(request.GetEndpoint().Host
                  , this.ServiceName);
#else
            return !string.IsNullOrWhiteSpace(regionNameOverride)? regionNameOverride
                    : HostNameUtils.ParseRegion(request.GetEndpoint().Host
                    , this.ServiceName);
#endif

        }

        /// <summary>
        /// Returns the scope to be used for the signing.
        /// </summary>
        /// <param name="dateStamp">日期戳</param>
        /// <param name="serviceName">服务名</param>
        /// <param name="regionName">区域名</param>
        /// <returns>Scope 字符串</returns>
        private string GenerateScope(string dateStamp, string serviceName, string regionName)
        {
            StringBuilder stringBuilder = new StringBuilder(); 
            stringBuilder.Append(dateStamp)
                .Append("/")
                .Append(regionName)
                .Append("/")
                .Append(serviceName)
                .Append("/")
                .Append(ParameterConstant.JDCLOUD_TERMINATOR); 
            return stringBuilder.ToString();
        }

        /// <summary>
        /// 获取当前的request实例
        /// </summary>
        /// <returns>http 请求 request实例</returns>
        public SdkHttpRequest Request { get; }

        /// <summary>
        /// 返回scope
        /// </summary>
        /// <returns>Scope</returns>
        public string Scope { get; }

        /// <summary>
        /// 返回签名的UTC时间 格式为 “yyyyMMdd'T'HHmmss'Z'”
        /// </summary>
        /// <returns>签名的UTC时间</returns>
        public string FormattedSigningDateTime { get; }

        /// <summary>
        /// 获取区域名称
        /// </summary>
        /// <returns>区域名称</returns>
        public string RegionName { get; }

        /// <summary>
        /// 返回请求的服务的名称
        /// </summary>
        /// <returns>服务的名称</returns>
        public string ServiceName { get; }

        /// <summary>
        /// 签名日期的UTC 格式 
        /// </summary>
        /// <returns>签名日期的UTC 格式 </returns>
        public string FormattedSigningDate { get; }

        /// <summary>
        /// 返回签名算法名称字符串
        /// </summary>
        /// <returns>签名算法名称字符串</returns>
        public string SigningAlgorithm { get; }

    }
}
