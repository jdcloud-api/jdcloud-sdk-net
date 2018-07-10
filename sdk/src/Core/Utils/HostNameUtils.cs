using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace JDCloudSDK.Core.Utils
{
    /// <summary>
    /// host name 工具
    /// </summary>
    public  class HostNameUtils
    {
        /// <summary>
        /// s3版本region 获取 pattern
        /// </summary>
        public const string S3_ENDPOINT_PATTERN = @"^(?:.+\.)?s3[.-]([a-z0-9-]+)$";


        /// <summary>
        /// 标准 cloudsearch endpoint 获取 region pattern
        /// </summary>
        public const string STANDARD_CLOUDSEARCH_ENDPOINT_PATTERN = @"^(?:.+\.)?([a-z0-9-]+)\.cloudsearch$";

        /// <summary>
        /// 扩展的 cloudsearch endpoint 获取 region pattern
        /// </summary>
        public const string EXTENDED_CLOUDSEARCH_ENDPOINT_PATTERN = @"^(?:.+\.)?([a-z0-9-]+)\.cloudsearch\..+";


        /// <summary>
        /// this mothed now not use in the call mothed ,so do not use this 
        /// </summary>
        /// <param name="host">要获取Region 的host</param>
        /// <param name="serviceHint">服务名称</param>
        /// <returns>进行正则匹配后的region信息</returns>
        public static string ParseRegion(string host, string serviceHint)
        {
            //TODO 这个是需要进行修改的方法，当前在调用没有使用，日后需要进行修改
#if NET35
            if (string.IsNullOrEmpty(host)|| string.IsNullOrEmpty(host.Trim()))
#else
             if (string.IsNullOrWhiteSpace(host))
#endif

            {
                throw new ArgumentNullException("hostname cannot be null");
            }

            string regionNameInInternalConfig = ParseRegionNameByInternalConfig(host);
#if NET35
            if (!string.IsNullOrEmpty(regionNameInInternalConfig)&& !string.IsNullOrEmpty(regionNameInInternalConfig.Trim()))
#else
            if (!string.IsNullOrWhiteSpace(regionNameInInternalConfig))
#endif
            {
                return regionNameInInternalConfig;
            }
#if NET35
            if (!string.IsNullOrEmpty(serviceHint) && !string.IsNullOrEmpty(serviceHint.Trim()))
#else
            if (!string.IsNullOrWhiteSpace(serviceHint))
#endif
            {
                if ("cloudsearch" == serviceHint && !host.StartsWith("cloudsearch."))
                {
                    Match match = Regex.Match(host, EXTENDED_CLOUDSEARCH_ENDPOINT_PATTERN);
                    if (match.Success)
                    {
                        return match.Groups[0].Value;
                    }
                }
                string patternStr = @"^(?:.+\.)?" + serviceHint + @"[.-]([a-z0-9-]+)\.";
                Match matcher = Regex.Match(host,patternStr);
                if (matcher.Success)
                {
                    if (matcher.Groups.Count > 1)
                    {
                        return matcher.Groups[1] != null ? matcher.Groups[1].Value : "cn-north-1";
                    }
                    else
                    {
                        return "cn-north-1";
                    } 
                }

            }

            return "cn-north-1";
        }

        /// <summary>
        /// 进行地域信息格式化获取
        /// </summary>
        /// <param name="host">host name</param>
        /// <returns>the configured region name if the given host name matches any of the host-to-region mappings in the internal config; otherwise return null.</returns>
        private static string ParseRegionNameByInternalConfig(string host)
        {

            //TODO java 的 代码中直接返回了null 内部内容进行了注释，此位置暂时保留当前
            //的定义方式，待了解详细需求后再次进行修改
            return null;
        }
    }
}
